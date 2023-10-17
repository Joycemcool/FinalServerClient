


namespace TCPServer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelServer = new System.Windows.Forms.Label();
            this.textIPaddress = new System.Windows.Forms.TextBox();
            this.textConversation = new System.Windows.Forms.TextBox();
            this.labelMessage = new System.Windows.Forms.Label();
            this.textMessage = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.labelClientIP = new System.Windows.Forms.Label();
            this.listBoxClientIP = new System.Windows.Forms.ListBox();
            this.menuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip3
            // 
            this.menuStrip3.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip3.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.connectToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(1205, 42);
            this.menuStrip3.TabIndex = 4;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(96, 38);
            this.toolStripMenuItem1.Text = "Game";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serverToolStripMenuItem,
            this.clientToolStripMenuItem});
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(123, 38);
            this.connectToolStripMenuItem.Text = "Connect";
            // 
            // serverToolStripMenuItem
            // 
            this.serverToolStripMenuItem.Name = "serverToolStripMenuItem";
            this.serverToolStripMenuItem.Size = new System.Drawing.Size(214, 44);
            this.serverToolStripMenuItem.Text = "Server";
            this.serverToolStripMenuItem.Click += new System.EventHandler(this.serverToolStripMenuItem_Click);
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(214, 44);
            this.clientToolStripMenuItem.Text = "Client";
            this.clientToolStripMenuItem.Click += new System.EventHandler(this.clientToolStripMenuItem_Click);
            // 
            // labelServer
            // 
            this.labelServer.AutoSize = true;
            this.labelServer.Location = new System.Drawing.Point(39, 106);
            this.labelServer.Name = "labelServer";
            this.labelServer.Size = new System.Drawing.Size(75, 25);
            this.labelServer.TabIndex = 0;
            this.labelServer.Text = "Server";
            this.labelServer.Click += new System.EventHandler(this.label1_Click);
            // 
            // textIPaddress
            // 
            this.textIPaddress.Location = new System.Drawing.Point(122, 106);
            this.textIPaddress.Name = "textIPaddress";
            this.textIPaddress.Size = new System.Drawing.Size(557, 31);
            this.textIPaddress.TabIndex = 5;
            this.textIPaddress.Text = "127.0.0.1:9000";
            // 
            // textConversation
            // 
            this.textConversation.Location = new System.Drawing.Point(122, 152);
            this.textConversation.Multiline = true;
            this.textConversation.Name = "textConversation";
            this.textConversation.Size = new System.Drawing.Size(552, 250);
            this.textConversation.TabIndex = 6;
            this.textConversation.TextChanged += new System.EventHandler(this.textConversation_TextChanged);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(22, 435);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(100, 25);
            this.labelMessage.TabIndex = 0;
            this.labelMessage.Text = "Message";
            this.labelMessage.Click += new System.EventHandler(this.label1_Click);
            // 
            // textMessage
            // 
            this.textMessage.Location = new System.Drawing.Point(128, 432);
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(557, 31);
            this.textMessage.TabIndex = 5;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(564, 505);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(109, 36);
            this.buttonSend.TabIndex = 7;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // labelClientIP
            // 
            this.labelClientIP.AutoSize = true;
            this.labelClientIP.Location = new System.Drawing.Point(715, 109);
            this.labelClientIP.Name = "labelClientIP";
            this.labelClientIP.Size = new System.Drawing.Size(92, 25);
            this.labelClientIP.TabIndex = 0;
            this.labelClientIP.Text = "Client IP";
            this.labelClientIP.Click += new System.EventHandler(this.label1_Click);
            // 
            // listBoxClientIP
            // 
            this.listBoxClientIP.FormattingEnabled = true;
            this.listBoxClientIP.ItemHeight = 25;
            this.listBoxClientIP.Location = new System.Drawing.Point(717, 147);
            this.listBoxClientIP.Name = "listBoxClientIP";
            this.listBoxClientIP.Size = new System.Drawing.Size(400, 404);
            this.listBoxClientIP.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 633);
            this.Controls.Add(this.listBoxClientIP);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textConversation);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.textIPaddress);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.labelClientIP);
            this.Controls.Add(this.labelServer);
            this.Controls.Add(this.menuStrip3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "TCP/IP Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.Label labelServer;
        private System.Windows.Forms.TextBox textIPaddress;
        private System.Windows.Forms.TextBox textConversation;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label labelClientIP;
        private System.Windows.Forms.ListBox listBoxClientIP;
    }
}

