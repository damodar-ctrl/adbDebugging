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
using System.IO;

namespace adbDebugging
{
    public partial class Form1 : Form
    {
        //Naik project 001
        // Colors for neumorphic design
        private readonly Color baseColor = Color.FromArgb(225, 230, 238);  // Light grayish-blue base
        private readonly Color textColor = Color.FromArgb(70, 80, 95);     // Dark blue-gray text
        private readonly Color accentColor = Color.FromArgb(103, 125, 203); // Purple-blue accent
        private readonly Color shadowDark = Color.FromArgb(190, 200, 214); // Dark shadow
        private readonly Color shadowLight = Color.FromArgb(255, 255, 255); // Light highlight

        // Custom controls collection for neumorphic style
        private List<Control> neumorphicControls = new List<Control>();

        public Form1()
        {
            InitializeComponent();
            ApplyNeumorphicTheme();
            ConfigureCustomTabControl();

            // Add save functionality
            saveContact.Click += (s, e) => SaveContentToFile(displaycontact.Text, "contacts.txt");
            savesms.Click += (s, e) => SaveContentToFile(displaySms.Text, "sms.txt");
            savecalllogs.Click += (s, e) => SaveContentToFile(displaycalllogs.Text, "call_logs.txt");
            savedriverinfo.Click += (s, e) => SaveContentToFile(displaydeviceinfo.Text, "device_info.txt");
            saveaccounts.Click += (s, e) => SaveContentToFile(displayaccounts.Text, "accounts.txt");

            // Status indicator
            statusIndicator.BackColor = Color.FromArgb(255, 128, 128); // Start with red (disconnected)

            // Check ADB connection on startup
            CheckAdbConnection();
        }

        private void ApplyNeumorphicTheme()
        {
            // Form styling
            this.BackColor = baseColor;
            this.ForeColor = textColor;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Text = "ADB Debugging Tool";
            this.Font = new Font("Segoe UI", 9F, FontStyle.Regular);

            // Create a shadow effect for the form
            this.DropShadow();

            // Apply neumorphic style to all buttons
            foreach (Control control in GetAllControls(this))
            {
                if (control is Button button)
                {
                    StyleNeumorphicButton(button);
                }
                else if (control is TextBox textBox)
                {
                    StyleNeumorphicTextBox(textBox);
                }
                else if (control is TabPage tabPage)
                {
                    tabPage.BackColor = baseColor;
                    tabPage.ForeColor = textColor;
                    tabPage.Padding = new Padding(10);
                }
            }

            // Style the tab control
            Contact.Appearance = TabAppearance.FlatButtons;
            Contact.ItemSize = new Size(120, 35);
            Contact.SizeMode = TabSizeMode.Fixed;
            Contact.DrawMode = TabDrawMode.OwnerDrawFixed;
            Contact.Padding = new Point(12, 8);
            Contact.BackColor = baseColor;
            Contact.ForeColor = textColor;
        }

        // Collection of all controls including nested ones
        private IEnumerable<Control> GetAllControls(Control container)
        {
            List<Control> controlList = new List<Control>();
            foreach (Control c in container.Controls)
            {
                controlList.Add(c);
                controlList.AddRange(GetAllControls(c));
            }
            return controlList;
        }

        private void StyleNeumorphicButton(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.BackColor = baseColor;
            button.ForeColor = textColor;
            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.MouseOverBackColor = baseColor;
            button.FlatAppearance.MouseDownBackColor = baseColor;
            button.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            button.Height = 35;
            button.Cursor = Cursors.Hand;

            // Add to collection for painting
            neumorphicControls.Add(button);

            // Custom painting for neumorphic effect
            button.Paint += (sender, e) =>
            {
                Button btn = (Button)sender;
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                Rectangle rect = new Rectangle(0, 0, btn.Width, btn.Height);
                Rectangle innerRect = new Rectangle(3, 3, btn.Width - 6, btn.Height - 6);

                // Draw base shape with rounded corners
                using (GraphicsPath path = CreateRoundedRectangle(rect, 10))
                {
                    // Different style when pressed
                    if (btn.FlatAppearance.BorderColor == accentColor)
                    {
                        // Pressed state (inset effect)
                        using (SolidBrush baseBrush = new SolidBrush(Color.FromArgb(215, 220, 228)))
                        {
                            g.FillPath(baseBrush, path);
                        }

                        // Inner shadow
                        DrawInnerShadow(g, rect, 10);
                    }
                    else
                    {
                        // Normal state (outset effect)
                        using (SolidBrush baseBrush = new SolidBrush(baseColor))
                        {
                            g.FillPath(baseBrush, path);
                        }

                        // Shadow and highlight
                        DrawNeumorphicShadow(g, rect, 10);
                    }
                }

                // Draw text centered
                TextRenderer.DrawText(e.Graphics, btn.Text, btn.Font,
                    rect, btn.Enabled ? btn.ForeColor : Color.Gray,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);
            };

            // Handle mouse events to animate the button
            button.MouseDown += (sender, e) =>
            {
                Button btn = (Button)sender;
                btn.FlatAppearance.BorderColor = accentColor;
                btn.Invalidate();
            };

            button.MouseUp += (sender, e) =>
            {
                Button btn = (Button)sender;
                btn.FlatAppearance.BorderColor = Color.SteelBlue;
                btn.Invalidate();
            };

            button.MouseLeave += (sender, e) =>
            {
                Button btn = (Button)sender;
                btn.FlatAppearance.BorderColor = Color.SteelBlue;
                btn.Invalidate();
            };
        }

        private void StyleNeumorphicTextBox(TextBox textBox)
        {
            textBox.BorderStyle = BorderStyle.None;
            textBox.BackColor = Color.FromArgb(215, 220, 228);
            textBox.ForeColor = textColor;
            textBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular);

            // Create a panel to host the textbox with neumorphic effect
            Panel textBoxContainer = new Panel
            {
                Dock = textBox.Dock,
                Location = textBox.Location,
                Size = textBox.Size,
                Anchor = textBox.Anchor,
                Padding = new Padding(10),
                BackColor = baseColor
            };

            // Get the parent and index of the textbox
            Control parent = textBox.Parent;
            int index = parent.Controls.GetChildIndex(textBox);

            // Remove the textbox from its parent
            parent.Controls.Remove(textBox);

            // Adjust the textbox to fit inside the panel
            textBox.Dock = DockStyle.Fill;
            textBox.Location = new Point(10, 10);

            // Add the textbox to the panel
            textBoxContainer.Controls.Add(textBox);

            // Add the panel to the parent at the same index
            parent.Controls.Add(textBoxContainer);
            parent.Controls.SetChildIndex(textBoxContainer, index);

            // Add neumorphic shadow to the panel
            textBoxContainer.Paint += (sender, e) =>
            {
                Panel panel = (Panel)sender;
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                Rectangle rect = new Rectangle(0, 0, panel.Width, panel.Height);
                using (GraphicsPath path = CreateRoundedRectangle(rect, 10))
                {
                    using (SolidBrush baseBrush = new SolidBrush(baseColor))
                    {
                        g.FillPath(baseBrush, path);
                    }

                    // Inner shadow for inset effect
                    DrawInnerShadow(g, rect, 10);
                }
            };
        }

        private void ConfigureCustomTabControl()
        {
            // Setup custom drawing for tab control
            Contact.DrawItem += (sender, e) =>
            {
                Graphics g = e.Graphics;
                TabControl tabControl = (TabControl)sender;
                TabPage tabPage = tabControl.TabPages[e.Index];
                Rectangle tabRect = tabControl.GetTabRect(e.Index);

                g.SmoothingMode = SmoothingMode.AntiAlias;

                // Adjust tab rectangle for better spacing
                tabRect.Inflate(-2, -2);

                // Fill background with base color
                using (SolidBrush brush = new SolidBrush(baseColor))
                {
                    g.FillRectangle(brush, e.Bounds);
                }

                // Create a rounded rectangle for the tab
                using (GraphicsPath path = CreateRoundedRectangle(tabRect, 8))
                {
                    // Check if the tab is selected
                    if (e.Index == tabControl.SelectedIndex)
                    {
                        // Selected tab - more prominent with accent highlight
                        using (LinearGradientBrush brush = new LinearGradientBrush(
                            tabRect,
                            Color.FromArgb(215, 220, 228),
                            baseColor,
                            LinearGradientMode.Vertical))
                        {
                            g.FillPath(brush, path);
                        }

                        // Top accent line
                        using (Pen accentPen = new Pen(accentColor, 3))
                        {
                            g.DrawLine(accentPen, tabRect.Left + 5, tabRect.Top, tabRect.Right - 5, tabRect.Top);
                        }

                        // Subtle shadow effect
                        DrawNeumorphicShadow(g, tabRect, 8, 0.5f);
                    }
                    else
                    {
                        // Unselected tab - more subtle
                        using (SolidBrush brush = new SolidBrush(baseColor))
                        {
                            g.FillPath(brush, path);
                        }
                        // Very subtle shadow
                        DrawNeumorphicShadow(g, tabRect, 8, 0.3f);
                    }

                    // Draw the text with a subtle shadow for depth
                    Color textShadowColor = Color.FromArgb(50, shadowDark);
                    Rectangle textRectShadow = new Rectangle(tabRect.X + 1, tabRect.Y + 1, tabRect.Width, tabRect.Height);
                    TextRenderer.DrawText(g, tabPage.Text, new Font("Segoe UI", 9, FontStyle.Regular),
                        textRectShadow, textShadowColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

                    // Main text
                    Color tabTextColor = e.Index == tabControl.SelectedIndex ? accentColor : textColor;
                    TextRenderer.DrawText(g, tabPage.Text, new Font("Segoe UI", 9, FontStyle.Regular),
                        tabRect, tabTextColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                }
            };
        }

        #region Helper Methods for Neumorphic Drawing

        private GraphicsPath CreateRoundedRectangle(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;

            // Top-left corner
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            // Top-right corner
            path.AddArc(rect.X + rect.Width - diameter - 1, rect.Y, diameter, diameter, 270, 90);
            // Bottom-right corner
            path.AddArc(rect.X + rect.Width - diameter - 1, rect.Y + rect.Height - diameter - 1, diameter, diameter, 0, 90);
            // Bottom-left corner
            path.AddArc(rect.X, rect.Y + rect.Height - diameter - 1, diameter, diameter, 90, 90);
            path.CloseFigure();

            return path;
        }

        private void DrawNeumorphicShadow(Graphics g, Rectangle rect, int radius, float intensity = 1.0f)
        {
            // Create shadow and highlight position
            Rectangle shadowRect = new Rectangle(rect.X + 2, rect.Y + 2, rect.Width - 4, rect.Height - 4);
            Rectangle highlightRect = new Rectangle(rect.X - 2, rect.Y - 2, rect.Width - 4, rect.Height - 4);

            // Calculate alpha values based on intensity
            int darkAlpha = (int)(90 * intensity);
            int lightAlpha = (int)(180 * intensity);

            // Shadow path
            using (GraphicsPath shadowPath = CreateRoundedRectangle(shadowRect, radius))
            {
                using (PathGradientBrush shadowBrush = new PathGradientBrush(shadowPath))
                {
                    shadowBrush.CenterColor = Color.FromArgb(darkAlpha, shadowDark);
                    shadowBrush.SurroundColors = new Color[] { Color.FromArgb(0, shadowDark) };
                    shadowBrush.FocusScales = new PointF(0.95f, 0.95f);
                    g.FillPath(shadowBrush, shadowPath);
                }
            }

            // Highlight path
            using (GraphicsPath highlightPath = CreateRoundedRectangle(highlightRect, radius))
            {
                using (PathGradientBrush highlightBrush = new PathGradientBrush(highlightPath))
                {
                    highlightBrush.CenterColor = Color.FromArgb(lightAlpha, shadowLight);
                    highlightBrush.SurroundColors = new Color[] { Color.FromArgb(0, shadowLight) };
                    highlightBrush.FocusScales = new PointF(0.95f, 0.95f);
                    g.FillPath(highlightBrush, highlightPath);
                }
            }
        }

        private void DrawInnerShadow(Graphics g, Rectangle rect, int radius)
        {
            // Create inner shadow effect (for pressed buttons or inset areas)
            Rectangle innerRect = new Rectangle(rect.X + 2, rect.Y + 2, rect.Width - 4, rect.Height - 4);

            // Top-left inner shadow (darker)
            using (GraphicsPath shadowPath1 = CreateRoundedRectangle(innerRect, radius))
            {
                using (Pen shadowPen1 = new Pen(Color.FromArgb(40, shadowDark), 2))
                {
                    g.DrawPath(shadowPen1, shadowPath1);
                }
            }

            // Bottom-right inner highlight (lighter)
            Rectangle innerHighlightRect = new Rectangle(rect.X + 1, rect.Y + 1, rect.Width - 2, rect.Height - 2);
            using (GraphicsPath highlightPath = CreateRoundedRectangle(innerHighlightRect, radius))
            {
                using (Pen highlightPen = new Pen(Color.FromArgb(30, shadowLight), 1))
                {
                    g.DrawPath(highlightPen, highlightPath);
                }
            }
        }

        private void DropShadow()
        {
            // Add a shadow to the form
            const int CS_DROPSHADOW = 0x00020000;
            this.CreateParams.ClassStyle |= CS_DROPSHADOW;
        }

        #endregion

        #region ADB Command Methods

        public string RunAdbCommand(string args)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo("adb", args)
                {
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (Process process = Process.Start(psi))
                {
                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();

                    if (!string.IsNullOrEmpty(error) && (output == null || output.Trim().Length == 0))
                    {
                        return "Error: " + error;
                    }

                    return output;
                }
            }
            catch (Exception ex)
            {
                return "Error executing ADB command: " + ex.Message;
            }
        }

        private void CheckAdbConnection()
        {
            try
            {
                string devices = RunAdbCommand("devices");
                if (devices.Contains("device") && !devices.Contains("no devices") && devices.Split('\n').Length > 2)
                {
                    // Device connected
                    statusIndicator.BackColor = Color.FromArgb(128, 255, 128); // Green
                    connectionStatusLabel.Text = "Device Connected";

                    // Get device name
                    string deviceModel = RunAdbCommand("shell getprop ro.product.model").Trim();
                    if (!string.IsNullOrEmpty(deviceModel))
                    {
                        connectionStatusLabel.Text += " - " + deviceModel;
                    }
                }
                else
                {
                    // No device
                    statusIndicator.BackColor = Color.FromArgb(255, 128, 128); // Red
                    connectionStatusLabel.Text = "No Device Connected";
                }
            }
            catch
            {
                statusIndicator.BackColor = Color.FromArgb(255, 128, 128); // Red
                connectionStatusLabel.Text = "ADB Not Found";
            }
        }

        private void SaveContentToFile(string content, string filename)
        {
            SaveFileDialog saveDialog = new SaveFileDialog
            {
                FileName = filename,
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                Title = "Save Content"
            };

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(saveDialog.FileName, content);
                    MessageBox.Show("Content saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        #region Button Click Events

        // Load Contacts
        private void loadContact_Click(object sender, EventArgs e)
        {
            try
            {
                string command = "shell content query --uri content://contacts/phones/";
                string output = RunAdbCommand(command);
                displaycontact.Text = output;
                CheckAdbConnection(); // Refresh connection status
            }
            catch (Exception ex)
            {
                displaycontact.Text = "Error: " + ex.Message;
            }
        }

        // Load SMS Messages
        private void loadSMS_Click(object sender, EventArgs e)
        {
            try
            {
                string command = "shell content query --uri content://sms/";
                string output = RunAdbCommand(command);
                displaySms.Text = output;
                CheckAdbConnection(); // Refresh connection status
            }
            catch (Exception ex)
            {
                displaySms.Text = "Error: " + ex.Message;
            }
        }

        // Load Call Logs
        private void loadCalllogs_Click(object sender, EventArgs e)
        {
            try
            {
                string command = "shell content query --uri content://call_log/calls/";
                string output = RunAdbCommand(command);
                displaycalllogs.Text = output;
                CheckAdbConnection(); // Refresh connection status
            }
            catch (Exception ex)
            {
                displaycalllogs.Text = "Error: " + ex.Message;
            }
        }

        // Load Device Info (CPU and Memory)
        private void loaddeviceinfo_Click(object sender, EventArgs e)
        {
            try
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

                CheckAdbConnection(); // Refresh connection status
            }
            catch (Exception ex)
            {
                displaydeviceinfo.Text = "Error: " + ex.Message;
            }
        }

        // Load Accounts
        private void loadaccounts_Click(object sender, EventArgs e)
        {
            try
            {
                string command = "shell dumpsys account";
                string output = RunAdbCommand(command);
                displayaccounts.Text = output;
                CheckAdbConnection(); // Refresh connection status
            }
            catch (Exception ex)
            {
                displayaccounts.Text = "Error: " + ex.Message;
            }
        }

        // Check ADB Connection Button
        private void checkConnectionBtn_Click(object sender, EventArgs e)
        {
            CheckAdbConnection();
        }

        #endregion

        private void tabPage1_Click(object sender, EventArgs e) { }
    }
}