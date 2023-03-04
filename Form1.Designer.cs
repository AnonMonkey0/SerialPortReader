namespace SerialArduinoReader
{
    partial class SerialPortReader
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SerialPortReader));
            this.cbAvailablePorts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtReceivedData = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCommand = new System.Windows.Forms.Label();
            this.txtSender = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.serPort = new System.IO.Ports.SerialPort(this.components);
            this.btnReloadPorts = new System.Windows.Forms.Button();
            this.lblPortNotSelected = new System.Windows.Forms.Label();
            this.lblNothingIsConnected = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enabledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deactivatedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showClearButtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doNotShowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.clearReceivedDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webpageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbAvailablePorts
            // 
            resources.ApplyResources(this.cbAvailablePorts, "cbAvailablePorts");
            this.cbAvailablePorts.FormattingEnabled = true;
            this.cbAvailablePorts.Name = "cbAvailablePorts";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnConnect
            // 
            resources.ApplyResources(this.btnConnect, "btnConnect");
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtReceivedData
            // 
            this.txtReceivedData.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.txtReceivedData, "txtReceivedData");
            this.txtReceivedData.Name = "txtReceivedData";
            this.txtReceivedData.ReadOnly = true;
            this.txtReceivedData.TextChanged += new System.EventHandler(this.txtReceivedData_TextChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // lblCommand
            // 
            resources.ApplyResources(this.lblCommand, "lblCommand");
            this.lblCommand.Name = "lblCommand";
            // 
            // txtSender
            // 
            resources.ApplyResources(this.txtSender, "txtSender");
            this.txtSender.Name = "txtSender";
            // 
            // btnSend
            // 
            resources.ApplyResources(this.btnSend, "btnSend");
            this.btnSend.Name = "btnSend";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // serPort
            // 
            this.serPort.PortName = "COM3";
            this.serPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serPort_DataReceived);
            // 
            // btnReloadPorts
            // 
            resources.ApplyResources(this.btnReloadPorts, "btnReloadPorts");
            this.btnReloadPorts.Name = "btnReloadPorts";
            this.btnReloadPorts.UseVisualStyleBackColor = true;
            this.btnReloadPorts.Click += new System.EventHandler(this.btnReloadPorts_Click);
            // 
            // lblPortNotSelected
            // 
            resources.ApplyResources(this.lblPortNotSelected, "lblPortNotSelected");
            this.lblPortNotSelected.ForeColor = System.Drawing.Color.Red;
            this.lblPortNotSelected.Name = "lblPortNotSelected";
            // 
            // lblNothingIsConnected
            // 
            resources.ApplyResources(this.lblNothingIsConnected, "lblNothingIsConnected");
            this.lblNothingIsConnected.ForeColor = System.Drawing.Color.Red;
            this.lblNothingIsConnected.Name = "lblNothingIsConnected";
            // 
            // btnDisconnect
            // 
            resources.ApplyResources(this.btnDisconnect, "btnDisconnect");
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnClear
            // 
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.Name = "btnClear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // connectToolStripMenuItem
            // 
            resources.ApplyResources(this.connectToolStripMenuItem, "connectToolStripMenuItem");
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            resources.ApplyResources(this.disconnectToolStripMenuItem, "disconnectToolStripMenuItem");
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // exitToolStripMenuItem
            // 
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendingToolStripMenuItem,
            this.showClearButtonToolStripMenuItem,
            this.toolStripMenuItem3,
            this.clearReceivedDataToolStripMenuItem,
            this.toolStripMenuItem4});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            resources.ApplyResources(this.toolsToolStripMenuItem, "toolsToolStripMenuItem");
            // 
            // sendingToolStripMenuItem
            // 
            this.sendingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enabledToolStripMenuItem,
            this.deactivatedToolStripMenuItem});
            this.sendingToolStripMenuItem.Name = "sendingToolStripMenuItem";
            resources.ApplyResources(this.sendingToolStripMenuItem, "sendingToolStripMenuItem");
            // 
            // enabledToolStripMenuItem
            // 
            this.enabledToolStripMenuItem.Checked = true;
            this.enabledToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enabledToolStripMenuItem.Name = "enabledToolStripMenuItem";
            resources.ApplyResources(this.enabledToolStripMenuItem, "enabledToolStripMenuItem");
            this.enabledToolStripMenuItem.Click += new System.EventHandler(this.enabledToolStripMenuItem_Click);
            // 
            // deactivatedToolStripMenuItem
            // 
            this.deactivatedToolStripMenuItem.Name = "deactivatedToolStripMenuItem";
            resources.ApplyResources(this.deactivatedToolStripMenuItem, "deactivatedToolStripMenuItem");
            this.deactivatedToolStripMenuItem.Click += new System.EventHandler(this.deactivatedToolStripMenuItem_Click);
            // 
            // showClearButtonToolStripMenuItem
            // 
            this.showClearButtonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.doNotShowToolStripMenuItem});
            this.showClearButtonToolStripMenuItem.Name = "showClearButtonToolStripMenuItem";
            resources.ApplyResources(this.showClearButtonToolStripMenuItem, "showClearButtonToolStripMenuItem");
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Checked = true;
            this.showToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            resources.ApplyResources(this.showToolStripMenuItem, "showToolStripMenuItem");
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // doNotShowToolStripMenuItem
            // 
            this.doNotShowToolStripMenuItem.Name = "doNotShowToolStripMenuItem";
            resources.ApplyResources(this.doNotShowToolStripMenuItem, "doNotShowToolStripMenuItem");
            this.doNotShowToolStripMenuItem.Click += new System.EventHandler(this.doNotShowToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
            // 
            // clearReceivedDataToolStripMenuItem
            // 
            resources.ApplyResources(this.clearReceivedDataToolStripMenuItem, "clearReceivedDataToolStripMenuItem");
            this.clearReceivedDataToolStripMenuItem.Name = "clearReceivedDataToolStripMenuItem";
            this.clearReceivedDataToolStripMenuItem.Click += new System.EventHandler(this.clearReceivedDataToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            resources.ApplyResources(this.toolStripMenuItem4, "toolStripMenuItem4");
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.exportReceivedToTxtToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.webpageToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // webpageToolStripMenuItem
            // 
            resources.ApplyResources(this.webpageToolStripMenuItem, "webpageToolStripMenuItem");
            this.webpageToolStripMenuItem.Name = "webpageToolStripMenuItem";
            this.webpageToolStripMenuItem.Click += new System.EventHandler(this.webpageToolStripMenuItem_Click);
            // 
            // SerialPortReader
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.lblNothingIsConnected);
            this.Controls.Add(this.lblPortNotSelected);
            this.Controls.Add(this.btnReloadPorts);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtSender);
            this.Controls.Add(this.lblCommand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtReceivedData);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbAvailablePorts);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "SerialPortReader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SerialPortReader_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbAvailablePorts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtReceivedData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCommand;
        private System.Windows.Forms.TextBox txtSender;
        private System.Windows.Forms.Button btnSend;
        private System.IO.Ports.SerialPort serPort;
        private System.Windows.Forms.Button btnReloadPorts;
        private System.Windows.Forms.Label lblPortNotSelected;
        private System.Windows.Forms.Label lblNothingIsConnected;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showClearButtonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doNotShowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webpageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearReceivedDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem sendingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enabledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deactivatedToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
    }
}

