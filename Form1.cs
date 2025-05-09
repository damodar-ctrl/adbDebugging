using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace adbDebugging
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ApplyDarkTheme();
            ApplyGradientBackground();
        }

        private void ApplyDarkTheme()
        {
            // Form styling
            this.BackColor = Color.FromArgb(30, 30, 36);
            this.ForeColor = Color.WhiteSmoke;

            // TabControl styling
            Contact.Appearance = TabAppearance.FlatButtons;
            Contact.ItemSize = new Size(100, 30);
            Contact.SizeMode = TabSizeMode.Fixed;
            Contact.DrawMode = TabDrawMode.OwnerDrawFixed;

            // TabPages styling
            foreach (TabPage tab in Contact.TabPages)
            {
                tab.BackColor = Color.FromArgb(40, 40, 48);
                tab.ForeColor = Color.WhiteSmoke;
            }

            // Buttons styling
            foreach (Control control in this.Controls)
            {
                if (control is Button button)
                {
                    button.FlatStyle = FlatStyle.Flat;
                    button.BackColor = Color.FromArgb(50, 50, 60);
                    button.ForeColor = Color.WhiteSmoke;
                    button.FlatAppearance.BorderColor = Color.FromArgb(70, 70, 80);
                    button.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 70, 80);
                    button.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 90, 100);
                }
                else if (control is TextBox textBox)
                {
                    textBox.BackColor = Color.FromArgb(50, 50, 60);
                    textBox.ForeColor = Color.WhiteSmoke;
                    textBox.BorderStyle = BorderStyle.FixedSingle;
                }
            }
        }

        private void ApplyGradientBackground()
        {
            this.Paint += (sender, e) =>
            {
                Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
                using (LinearGradientBrush brush = new LinearGradientBrush(rect,
                    Color.FromArgb(20, 20, 25),
                    Color.FromArgb(40, 40, 50),
                    45f))
                {
                    e.Graphics.FillRectangle(brush, rect);
                }
            };
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            using (LinearGradientBrush brush = new LinearGradientBrush(rect,
                Color.FromArgb(20, 20, 25),
                Color.FromArgb(40, 40, 50),
                45f))
            {
                e.Graphics.FillRectangle(brush, rect);
            }
        }

        // Handle tab drawing for custom appearance
        private void Contact_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabControl tabControl = (TabControl)sender;
            TabPage tabPage = tabControl.TabPages[e.Index];
            Rectangle tabRect = tabControl.GetTabRect(e.Index);

            // Background
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(40, 40, 48)))
            {
                e.Graphics.FillRectangle(brush, e.Bounds);
            }

            // Highlight selected tab
            if (e.State == DrawItemState.Selected)
            {
                using (LinearGradientBrush brush = new LinearGradientBrush(
                    tabRect,
                    Color.FromArgb(70, 70, 80),
                    Color.FromArgb(50, 50, 60),
                    LinearGradientMode.Vertical))
                {
                    e.Graphics.FillRectangle(brush, tabRect);
                }
            }

            // Tab text
            TextRenderer.DrawText(e.Graphics, tabPage.Text, tabPage.Font,
                tabRect, tabPage.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        public string RunAdbCommand(string args)
        {
            ProcessStartInfo psi = new ProcessStartInfo("adb", args)
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process process = Process.Start(psi))
            {
                return process.StandardOutput.ReadToEnd();
            }
        }

        // Load Contacts
        private void loadContact_Click(object sender, EventArgs e)
        {
            string command = "shell content query --uri content://contacts/phones/";
            string output = RunAdbCommand(command);
            displaycontact.Text = output;
        }

        // Load SMS Messages
        private void loadSMS_Click(object sender, EventArgs e)
        {
            string command = "shell content query --uri content://sms/";
            string output = RunAdbCommand(command);
            displaySms.Text = output;
        }

        // Load Call Logs
        private void loadCalllogs_Click(object sender, EventArgs e)
        {
            string command = "shell content query --uri content://call_log/calls/";
            string output = RunAdbCommand(command);
            displaycalllogs.Text = output;
        }

        // Load Device Info (CPU and Memory)
        private void loaddeviceinfo_Click(object sender, EventArgs e)
        {
            string cpuInfo = RunAdbCommand("shell cat /proc/cpuinfo");
            string memInfo = RunAdbCommand("shell cat /proc/meminfo");
            string deviceModel = RunAdbCommand("shell getprop ro.product.model");
            string androidVersion = RunAdbCommand("shell getprop ro.build.version.release");
            string battery = RunAdbCommand("shell dumpsys battery");
            string imei = RunAdbCommand("shell service call iphonesubinfo 1");

            displaydeviceinfo.Text =
                "Model: " + deviceModel +
                "\nAndroid Version: " + androidVersion +
                "\n\nCPU Info:\n" + cpuInfo +
                "\nMemory Info:\n" + memInfo +
                "\n\nBattery Info:\n" + battery +
                "\nIMEI Info:\n" + imei;
        }

        // Load Accounts
        private void loadaccounts_Click(object sender, EventArgs e)
        {
            string command = "shell dumpsys account";
            string output = RunAdbCommand(command);
            displayaccounts.Text = output;
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void tabPage1_Click(object sender, EventArgs e) { }
        private void button6_Click(object sender, EventArgs e) { }
        private void button8_Click(object sender, EventArgs e) { }
    }
}