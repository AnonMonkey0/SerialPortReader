using System;
using System.Diagnostics;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace SerialArduinoReader
{
    public partial class SerialPortReader : Form
    {
        private string receivedData;

        public SerialPortReader()
        {
            InitializeComponent();
            FetchAvailablePorts();
            lblPortNotSelected.Visible = false;
            lblNothingIsConnected.Visible = false;
            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
            connectToolStripMenuItem.Enabled = true;
            disconnectToolStripMenuItem.Enabled = false;
            showToolStripMenuItem.Checked = true;
            doNotShowToolStripMenuItem.Checked = false;
        }

        void FetchAvailablePorts()
        {
            cbAvailablePorts.Items.Clear();
            String[] ports = SerialPort.GetPortNames();
            cbAvailablePorts.Items.AddRange(ports);
        }

        void Connect()
        {
            string[] portsArray = cbAvailablePorts.Items.OfType<string>().ToArray();
            int index = Array.IndexOf(portsArray, cbAvailablePorts.Text);

            if (cbAvailablePorts.Text == "")
            {
                lblPortNotSelected.Text = "Port not selected";
                lblPortNotSelected.Visible = true;
            }
            else if (index == -1)
            {
                lblPortNotSelected.Text = "Port doesn't exist";
                lblPortNotSelected.Visible = true;
            }
            else
            {
                lblPortNotSelected.Visible = false;

                serPort = new SerialPort();

                serPort.BaudRate = 9600;
                serPort.PortName = cbAvailablePorts.Text;
                serPort.Parity = Parity.None;
                serPort.DataBits = 8;
                serPort.DtrEnable = true;
                serPort.StopBits = StopBits.One;
                serPort.ReadBufferSize = 10000000;
                serPort.DataReceived += serPort_DataReceived;

                try
                {
                    serPort.Open();
                    Thread.Sleep(1000);
                    btnConnect.Enabled = false;
                    btnDisconnect.Enabled = true;
                    connectToolStripMenuItem.Enabled = false;
                    disconnectToolStripMenuItem.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        void Disconnect()
        {
            try
            {
                serPort.Close();
                btnConnect.Enabled = true;
                btnDisconnect.Enabled = false;
                connectToolStripMenuItem.Enabled = true;
                disconnectToolStripMenuItem.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void serPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            receivedData = serPort.ReadLine();

            this.Invoke(new Action(ProcessingData));
        }

        private void ProcessingData()
        {
            txtReceivedData.Text += receivedData.ToString() + Environment.NewLine;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (serPort.IsOpen)
            {
                lblNothingIsConnected.Visible = false;
                serPort.WriteLine(txtSender.Text.ToString());
            }
            else
            {
                lblNothingIsConnected.Text = "Port isn't connected";
                lblNothingIsConnected.Visible = true;
            }
        }

        private void SerialPortReader_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                serPort.Close();
            }
            catch
            {
            }
        }

        private void btnReloadPorts_Click(object sender, EventArgs e)
        {
            FetchAvailablePorts();
        }

        private void txtReceivedData_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            textBox.SelectionStart = textBox.Text.Length;
            textBox.ScrollToCaret();
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            Disconnect();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtReceivedData.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Disconnect();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (showToolStripMenuItem.Checked == false)
            {
                showToolStripMenuItem.Checked = true;
                doNotShowToolStripMenuItem.Checked = false;

                btnClear.Visible = true;
            }
        }

        private void doNotShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (doNotShowToolStripMenuItem.Checked == false)
            {
                showToolStripMenuItem.Checked = false;
                doNotShowToolStripMenuItem.Checked = true;

                btnClear.Visible = false;
            }
        }

        private void clearReceivedDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtReceivedData.Clear();
        }

        private void exportReceivedToTxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Pliki tekstowe (*.txt)|*.txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                {
                    sw.Write(txtReceivedData.Text);
                }

                MessageBox.Show("Received data saved succesfully.", "File saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void webpageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string url = "http://www.example.com";
            Process.Start(url);
        }

        private void enabledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (enabledToolStripMenuItem.Checked == false)
            {
                enabledToolStripMenuItem.Checked = true;
                deactivatedToolStripMenuItem.Checked = false;

                lblCommand.Visible = true;
                txtSender.Visible = true;
                btnSend.Visible = true;
            }
        }

        private void deactivatedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (deactivatedToolStripMenuItem.Checked == false)
            {
                enabledToolStripMenuItem.Checked = false;
                deactivatedToolStripMenuItem.Checked = true;

                lblCommand.Visible = false;
                txtSender.Visible = false;
                btnSend.Visible = false;
            }
        }
    }
}

