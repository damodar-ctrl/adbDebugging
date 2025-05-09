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
            this.Contact.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // Contact
            // 
            this.Contact.Controls.Add(this.tabPage1);
            this.Contact.Controls.Add(this.tabPage2);
            this.Contact.Controls.Add(this.tabPage3);
            this.Contact.Controls.Add(this.tabPage4);
            this.Contact.Controls.Add(this.tabPage5);
            this.Contact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contact.Location = new System.Drawing.Point(0, 0);
            this.Contact.Name = "Contact";
            this.Contact.SelectedIndex = 0;
            this.Contact.Size = new System.Drawing.Size(800, 450);
            this.Contact.TabIndex = 0;
            this.Contact.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.Contact_DrawItem);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.tabPage1.Controls.Add(this.displaycontact);
            this.tabPage1.Controls.Add(this.saveContact);
            this.tabPage1.Controls.Add(this.loadContact);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 412);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Contacts";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // displaycontact
            // 
            this.displaycontact.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displaycontact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.displaycontact.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.displaycontact.Location = new System.Drawing.Point(8, 41);
            this.displaycontact.Multiline = true;
            this.displaycontact.Name = "displaycontact";
            this.displaycontact.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.displaycontact.Size = new System.Drawing.Size(776, 363);
            this.displaycontact.TabIndex = 2;
            // 
            // saveContact
            // 
            this.saveContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveContact.Location = new System.Drawing.Point(89, 8);
            this.saveContact.Name = "saveContact";
            this.saveContact.Size = new System.Drawing.Size(75, 27);
            this.saveContact.TabIndex = 1;
            this.saveContact.Text = "Save";
            this.saveContact.UseVisualStyleBackColor = true;
            // 
            // loadContact
            // 
            this.loadContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadContact.Location = new System.Drawing.Point(8, 8);
            this.loadContact.Name = "loadContact";
            this.loadContact.Size = new System.Drawing.Size(75, 27);
            this.loadContact.TabIndex = 0;
            this.loadContact.Text = "Load";
            this.loadContact.UseVisualStyleBackColor = true;
            this.loadContact.Click += new System.EventHandler(this.loadContact_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.tabPage2.Controls.Add(this.displaySms);
            this.tabPage2.Controls.Add(this.loadSMS);
            this.tabPage2.Controls.Add(this.savesms);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 412);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SMS";
            // 
            // displaySms
            // 
            this.displaySms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displaySms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.displaySms.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.displaySms.Location = new System.Drawing.Point(8, 41);
            this.displaySms.Multiline = true;
            this.displaySms.Name = "displaySms";
            this.displaySms.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.displaySms.Size = new System.Drawing.Size(776, 363);
            this.displaySms.TabIndex = 5;
            // 
            // loadSMS
            // 
            this.loadSMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadSMS.Location = new System.Drawing.Point(8, 8);
            this.loadSMS.Name = "loadSMS";
            this.loadSMS.Size = new System.Drawing.Size(75, 27);
            this.loadSMS.TabIndex = 3;
            this.loadSMS.Text = "Load";
            this.loadSMS.UseVisualStyleBackColor = true;
            this.loadSMS.Click += new System.EventHandler(this.loadSMS_Click);
            // 
            // savesms
            // 
            this.savesms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savesms.Location = new System.Drawing.Point(89, 8);
            this.savesms.Name = "savesms";
            this.savesms.Size = new System.Drawing.Size(75, 27);
            this.savesms.TabIndex = 4;
            this.savesms.Text = "Save";
            this.savesms.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.tabPage3.Controls.Add(this.displaycalllogs);
            this.tabPage3.Controls.Add(this.loadCalllogs);
            this.tabPage3.Controls.Add(this.savecalllogs);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 412);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Call Logs";
            // 
            // displaycalllogs
            // 
            this.displaycalllogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displaycalllogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.displaycalllogs.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.displaycalllogs.Location = new System.Drawing.Point(8, 41);
            this.displaycalllogs.Multiline = true;
            this.displaycalllogs.Name = "displaycalllogs";
            this.displaycalllogs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.displaycalllogs.Size = new System.Drawing.Size(776, 363);
            this.displaycalllogs.TabIndex = 8;
            // 
            // loadCalllogs
            // 
            this.loadCalllogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadCalllogs.Location = new System.Drawing.Point(8, 8);
            this.loadCalllogs.Name = "loadCalllogs";
            this.loadCalllogs.Size = new System.Drawing.Size(75, 27);
            this.loadCalllogs.TabIndex = 6;
            this.loadCalllogs.Text = "Load";
            this.loadCalllogs.UseVisualStyleBackColor = true;
            this.loadCalllogs.Click += new System.EventHandler(this.loadCalllogs_Click);
            // 
            // savecalllogs
            // 
            this.savecalllogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savecalllogs.Location = new System.Drawing.Point(89, 8);
            this.savecalllogs.Name = "savecalllogs";
            this.savecalllogs.Size = new System.Drawing.Size(75, 27);
            this.savecalllogs.TabIndex = 7;
            this.savecalllogs.Text = "Save";
            this.savecalllogs.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.tabPage4.Controls.Add(this.displaydeviceinfo);
            this.tabPage4.Controls.Add(this.loaddeviceinfo);
            this.tabPage4.Controls.Add(this.savedriverinfo);
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(792, 412);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Device Info";
            // 
            // displaydeviceinfo
            // 
            this.displaydeviceinfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displaydeviceinfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.displaydeviceinfo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.displaydeviceinfo.Location = new System.Drawing.Point(8, 41);
            this.displaydeviceinfo.Multiline = true;
            this.displaydeviceinfo.Name = "displaydeviceinfo";
            this.displaydeviceinfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.displaydeviceinfo.Size = new System.Drawing.Size(776, 363);
            this.displaydeviceinfo.TabIndex = 11;
            // 
            // loaddeviceinfo
            // 
            this.loaddeviceinfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loaddeviceinfo.Location = new System.Drawing.Point(8, 8);
            this.loaddeviceinfo.Name = "loaddeviceinfo";
            this.loaddeviceinfo.Size = new System.Drawing.Size(75, 27);
            this.loaddeviceinfo.TabIndex = 9;
            this.loaddeviceinfo.Text = "Load";
            this.loaddeviceinfo.UseVisualStyleBackColor = true;
            this.loaddeviceinfo.Click += new System.EventHandler(this.loaddeviceinfo_Click);
            // 
            // savedriverinfo
            // 
            this.savedriverinfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savedriverinfo.Location = new System.Drawing.Point(89, 8);
            this.savedriverinfo.Name = "savedriverinfo";
            this.savedriverinfo.Size = new System.Drawing.Size(75, 27);
            this.savedriverinfo.TabIndex = 10;
            this.savedriverinfo.Text = "Save";
            this.savedriverinfo.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.tabPage5.Controls.Add(this.displayaccounts);
            this.tabPage5.Controls.Add(this.loadaccounts);
            this.tabPage5.Controls.Add(this.saveaccounts);
            this.tabPage5.Location = new System.Drawing.Point(4, 34);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(792, 412);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Accounts";
            // 
            // displayaccounts
            // 
            this.displayaccounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayaccounts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.displayaccounts.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.displayaccounts.Location = new System.Drawing.Point(8, 41);
            this.displayaccounts.Multiline = true;
            this.displayaccounts.Name = "displayaccounts";
            this.displayaccounts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.displayaccounts.Size = new System.Drawing.Size(776, 363);
            this.displayaccounts.TabIndex = 14;
            // 
            // loadaccounts
            // 
            this.loadaccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadaccounts.Location = new System.Drawing.Point(8, 8);
            this.loadaccounts.Name = "loadaccounts";
            this.loadaccounts.Size = new System.Drawing.Size(75, 27);
            this.loadaccounts.TabIndex = 12;
            this.loadaccounts.Text = "Load";
            this.loadaccounts.UseVisualStyleBackColor = true;
            this.loadaccounts.Click += new System.EventHandler(this.loadaccounts_Click);
            // 
            // saveaccounts
            // 
            this.saveaccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveaccounts.Location = new System.Drawing.Point(89, 8);
            this.saveaccounts.Name = "saveaccounts";
            this.saveaccounts.Size = new System.Drawing.Size(75, 27);
            this.saveaccounts.TabIndex = 13;
            this.saveaccounts.Text = "Save";
            this.saveaccounts.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Contact);
            this.Name = "Form1";
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Contact;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox displaycontact;
        private System.Windows.Forms.Button saveContact;
        private System.Windows.Forms.Button loadContact;
        private System.Windows.Forms.TextBox displaySms;
        private System.Windows.Forms.Button loadSMS;
        private System.Windows.Forms.Button savesms;
        private System.Windows.Forms.TextBox displaycalllogs;
        private System.Windows.Forms.Button loadCalllogs;
        private System.Windows.Forms.Button savecalllogs;
        private System.Windows.Forms.TextBox displaydeviceinfo;
        private System.Windows.Forms.Button loaddeviceinfo;
        private System.Windows.Forms.Button savedriverinfo;
        private System.Windows.Forms.TextBox displayaccounts;
        private System.Windows.Forms.Button loadaccounts;
        private System.Windows.Forms.Button saveaccounts;
    }
}