namespace adbDebugging
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Contact = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.displaycontact = new System.Windows.Forms.TextBox();
            this.saveContact = new System.Windows.Forms.Button();
            this.loadContact = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.displaySms = new System.Windows.Forms.TextBox();
            this.loadSMS = new System.Windows.Forms.Button();
            this.savesms = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.displaycalllogs = new System.Windows.Forms.TextBox();
            this.loadCalllogs = new System.Windows.Forms.Button();
            this.savecalllogs = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.displaydeviceinfo = new System.Windows.Forms.TextBox();
            this.loaddeviceinfo = new System.Windows.Forms.Button();
            this.savedriverinfo = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.displayaccounts = new System.Windows.Forms.TextBox();
            this.loadaccounts = new System.Windows.Forms.Button();
            this.saveaccounts = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusIndicator = new System.Windows.Forms.ToolStripStatusLabel();
            this.connectionStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSpacer = new System.Windows.Forms.ToolStripStatusLabel();
            this.checkConnectionBtn = new System.Windows.Forms.Button();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.appTitleLabel = new System.Windows.Forms.Label();
            this.appIconPictureBox = new System.Windows.Forms.PictureBox();
            this.Contact.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appIconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Contact
            // 
            this.Contact.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Contact.Controls.Add(this.tabPage1);
            this.Contact.Controls.Add(this.tabPage2);
            this.Contact.Controls.Add(this.tabPage3);
            this.Contact.Controls.Add(this.tabPage4);
            this.Contact.Controls.Add(this.tabPage5);
            this.Contact.Location = new System.Drawing.Point(20, 80);
            this.Contact.Name = "Contact";
            this.Contact.SelectedIndex = 0;
            this.Contact.Size = new System.Drawing.Size(860, 430);
            this.Contact.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.displaycontact);
            this.tabPage1.Controls.Add(this.saveContact);
            this.tabPage1.Controls.Add(this.loadContact);
            this.tabPage1.Location = new System.Drawing.Point(4, 36);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(852, 390);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Contacts";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // displaycontact
            // 
            this.displaycontact.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displaycontact.Location = new System.Drawing.Point(15, 52);
            this.displaycontact.Multiline = true;
            this.displaycontact.Name = "displaycontact";
            this.displaycontact.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.displaycontact.Size = new System.Drawing.Size(820, 320);
            this.displaycontact.TabIndex = 2;
            // 
            // saveContact
            // 
            this.saveContact.Location = new System.Drawing.Point(105, 15);
            this.saveContact.Name = "saveContact";
            this.saveContact.Size = new System.Drawing.Size(90, 35);
            this.saveContact.TabIndex = 1;
            this.saveContact.Text = "Save";
            this.saveContact.UseVisualStyleBackColor = true;
            // 
            // loadContact
            // 
            this.loadContact.Location = new System.Drawing.Point(15, 15);
            this.loadContact.Name = "loadContact";
            this.loadContact.Size = new System.Drawing.Size(90, 35);
            this.loadContact.TabIndex = 0;
            this.loadContact.Text = "Load";
            this.loadContact.UseVisualStyleBackColor = true;
            this.loadContact.Click += new System.EventHandler(this.loadContact_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.displaySms);
            this.tabPage2.Controls.Add(this.loadSMS);
            this.tabPage2.Controls.Add(this.savesms);
            this.tabPage2.Location = new System.Drawing.Point(4, 36);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(852, 390);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SMS";
            // 
            // displaySms
            // 
            this.displaySms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displaySms.Location = new System.Drawing.Point(15, 52);
            this.displaySms.Multiline = true;
            this.displaySms.Name = "displaySms";
            this.displaySms.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.displaySms.Size = new System.Drawing.Size(820, 320);
            this.displaySms.TabIndex = 2;
            // 
            // loadSMS
            // 
            this.loadSMS.Location = new System.Drawing.Point(15, 15);
            this.loadSMS.Name = "loadSMS";
            this.loadSMS.Size = new System.Drawing.Size(90, 35);
            this.loadSMS.TabIndex = 0;
            this.loadSMS.Text = "Load";
            this.loadSMS.UseVisualStyleBackColor = true;
            this.loadSMS.Click += new System.EventHandler(this.loadSMS_Click);
            // 
            // savesms
            // 
            this.savesms.Location = new System.Drawing.Point(105, 15);
            this.savesms.Name = "savesms";
            this.savesms.Size = new System.Drawing.Size(90, 35);
            this.savesms.TabIndex = 1;
            this.savesms.Text = "Save";
            this.savesms.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.displaycalllogs);
            this.tabPage3.Controls.Add(this.loadCalllogs);
            this.tabPage3.Controls.Add(this.savecalllogs);
            this.tabPage3.Location = new System.Drawing.Point(4, 36);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(852, 390);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Call Logs";
            // 
            // displaycalllogs
            // 
            this.displaycalllogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displaycalllogs.Location = new System.Drawing.Point(15, 52);
            this.displaycalllogs.Multiline = true;
            this.displaycalllogs.Name = "displaycalllogs";
            this.displaycalllogs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.displaycalllogs.Size = new System.Drawing.Size(820, 320);
            this.displaycalllogs.TabIndex = 2;
            // 
            // loadCalllogs
            // 
            this.loadCalllogs.Location = new System.Drawing.Point(15, 15);
            this.loadCalllogs.Name = "loadCalllogs";
            this.loadCalllogs.Size = new System.Drawing.Size(90, 35);
            this.loadCalllogs.TabIndex = 0;
            this.loadCalllogs.Text = "Load";
            this.loadCalllogs.UseVisualStyleBackColor = true;
            this.loadCalllogs.Click += new System.EventHandler(this.loadCalllogs_Click);
            // 
            // savecalllogs
            // 
            this.savecalllogs.Location = new System.Drawing.Point(105, 15);
            this.savecalllogs.Name = "savecalllogs";
            this.savecalllogs.Size = new System.Drawing.Size(90, 35);
            this.savecalllogs.TabIndex = 1;
            this.savecalllogs.Text = "Save";
            this.savecalllogs.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.displaydeviceinfo);
            this.tabPage4.Controls.Add(this.loaddeviceinfo);
            this.tabPage4.Controls.Add(this.savedriverinfo);
            this.tabPage4.Location = new System.Drawing.Point(4, 36);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(852, 390);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Device Info";
            // 
            // displaydeviceinfo
            // 
            this.displaydeviceinfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displaydeviceinfo.Location = new System.Drawing.Point(15, 52);
            this.displaydeviceinfo.Multiline = true;
            this.displaydeviceinfo.Name = "displaydeviceinfo";
            this.displaydeviceinfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.displaydeviceinfo.Size = new System.Drawing.Size(820, 320);
            this.displaydeviceinfo.TabIndex = 2;
            // 
            // loaddeviceinfo
            // 
            this.loaddeviceinfo.Location = new System.Drawing.Point(15, 15);
            this.loaddeviceinfo.Name = "loaddeviceinfo";
            this.loaddeviceinfo.Size = new System.Drawing.Size(90, 35);
            this.loaddeviceinfo.TabIndex = 0;
            this.loaddeviceinfo.Text = "Load";
            this.loaddeviceinfo.UseVisualStyleBackColor = true;
            this.loaddeviceinfo.Click += new System.EventHandler(this.loaddeviceinfo_Click);
            // 
            // savedriverinfo
            // 
            this.savedriverinfo.Location = new System.Drawing.Point(105, 15);
            this.savedriverinfo.Name = "savedriverinfo";
            this.savedriverinfo.Size = new System.Drawing.Size(90, 35);
            this.savedriverinfo.TabIndex = 1;
            this.savedriverinfo.Text = "Save";
            this.savedriverinfo.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.displayaccounts);
            this.tabPage5.Controls.Add(this.loadaccounts);
            this.tabPage5.Controls.Add(this.saveaccounts);
            this.tabPage5.Location = new System.Drawing.Point(4, 36);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(852, 390);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Accounts";
            // 
            // displayaccounts
            // 
            this.displayaccounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayaccounts.Location = new System.Drawing.Point(15, 52);
            this.displayaccounts.Multiline = true;
            this.displayaccounts.Name = "displayaccounts";
            this.displayaccounts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.displayaccounts.Size = new System.Drawing.Size(820, 320);
            this.displayaccounts.TabIndex = 2;
            // 
            // loadaccounts
            // 
            this.loadaccounts.Location = new System.Drawing.Point(15, 15);
            this.loadaccounts.Name = "loadaccounts";
            this.loadaccounts.Size = new System.Drawing.Size(90, 35);
            this.loadaccounts.TabIndex = 0;
            this.loadaccounts.Text = "Load";
            this.loadaccounts.UseVisualStyleBackColor = true;
            this.loadaccounts.Click += new System.EventHandler(this.loadaccounts_Click);
            // 
            // saveaccounts
            // 
            this.saveaccounts.Location = new System.Drawing.Point(105, 15);
            this.saveaccounts.Name = "saveaccounts";
            this.saveaccounts.Size = new System.Drawing.Size(90, 35);
            this.saveaccounts.TabIndex = 1;
            this.saveaccounts.Text = "Save";
            this.saveaccounts.UseVisualStyleBackColor = true;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusIndicator,
            this.connectionStatusLabel,
            this.toolStripSpacer});
            this.statusStrip.Location = new System.Drawing.Point(0, 530);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(900, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusIndicator
            // 
            this.statusIndicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.statusIndicator.Name = "statusIndicator";
            this.statusIndicator.Size = new System.Drawing.Size(13, 17);
            this.statusIndicator.Text = "  ";
            // 
            // connectionStatusLabel
            // 
            this.connectionStatusLabel.Name = "connectionStatusLabel";
            this.connectionStatusLabel.Size = new System.Drawing.Size(118, 17);
            this.connectionStatusLabel.Text = "No Device Connected";
            // 
            // toolStripSpacer
            // 
            this.toolStripSpacer.Name = "toolStripSpacer";
            this.toolStripSpacer.Size = new System.Drawing.Size(754, 17);
            this.toolStripSpacer.Spring = true;
            // 
            // checkConnectionBtn
            // 
            this.checkConnectionBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkConnectionBtn.Location = new System.Drawing.Point(787, 20);
            this.checkConnectionBtn.Name = "checkConnectionBtn";
            this.checkConnectionBtn.Size = new System.Drawing.Size(93, 35);
            this.checkConnectionBtn.TabIndex = 2;
            this.checkConnectionBtn.Text = "Check ADB";
            this.checkConnectionBtn.UseVisualStyleBackColor = true;
            this.checkConnectionBtn.Click += new System.EventHandler(this.checkConnectionBtn_Click);
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.appTitleLabel);
            this.headerPanel.Controls.Add(this.appIconPictureBox);
            this.headerPanel.Controls.Add(this.checkConnectionBtn);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(900, 65);
            this.headerPanel.TabIndex = 3;
            // 
            // appTitleLabel
            // 
            this.appTitleLabel.AutoSize = true;
            this.appTitleLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(95)))));
            this.appTitleLabel.Location = new System.Drawing.Point(70, 22);
            this.appTitleLabel.Name = "appTitleLabel";
            this.appTitleLabel.Size = new System.Drawing.Size(182, 25);
            this.appTitleLabel.TabIndex = 4;
            this.appTitleLabel.Text = "ADB Debugging Tool";
            // 
            // appIconPictureBox
            // 
            this.appIconPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("appIconPictureBox.Image")));
            this.appIconPictureBox.Location = new System.Drawing.Point(20, 15);
            this.appIconPictureBox.Name = "appIconPictureBox";
            this.appIconPictureBox.Size = new System.Drawing.Size(40, 40);
            this.appIconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.appIconPictureBox.TabIndex = 3;
            this.appIconPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 552);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.Contact);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADB Debugging Tool";
            this.Contact.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();                                                                          
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appIconPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Contact;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button loadContact;
        private System.Windows.Forms.Button saveContact;
        private System.Windows.Forms.TextBox displaycontact;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox displaySms;
        private System.Windows.Forms.Button loadSMS;
        private System.Windows.Forms.Button savesms;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox displaycalllogs;
        private System.Windows.Forms.Button loadCalllogs;
        private System.Windows.Forms.Button savecalllogs;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox displaydeviceinfo;
        private System.Windows.Forms.Button loaddeviceinfo;
        private System.Windows.Forms.Button savedriverinfo;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox displayaccounts;
        private System.Windows.Forms.Button loadaccounts;
        private System.Windows.Forms.Button saveaccounts;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusIndicator;
        private System.Windows.Forms.ToolStripStatusLabel connectionStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripSpacer;
        private System.Windows.Forms.Button checkConnectionBtn;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label appTitleLabel;
        private System.Windows.Forms.PictureBox appIconPictureBox;
    }
}