using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL_GSCPMS_OOP_PROJECT.Forms.Accounts
{
    public partial class Resetpass : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public string connectionString = "Data Source=192.168.100.226,1433;Initial Catalog=Employee;Persist Security Info=True;User ID=Stephen;Password=***********;Trust Server Certificate=True;";

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        public Resetpass()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            PassTimer.Interval = 200; // milliseconds
            PassTimer.Tick += PassTimer_Tick;
            PassTimer.Start();
        }
        private void Resetpass_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Password_ContentChanged(object sender, EventArgs e)
        {
            CheckPasswordMatch();
        }

        private void Confirmpassword_ContentChanged(object sender, EventArgs e)
        {
            CheckPasswordMatch();
        }
       
      
        private void Showpass_CheckedChanged(object sender, EventArgs e)
        {
            Password.PasswordChar = !Showpass.Checked;
            Confirmpassword.PasswordChar = !Showpass.Checked;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            string pass = Password.Content.Trim();
            string confirm = Confirmpassword.Content.Trim();

            // Check if password is strong
            if (!IsPasswordStrong(pass))
            {
                MessageBox.Show(
                    "⚠ Password must be at least 8 characters and contain:\n• Uppercase\n• Lowercase\n• Number\n• Symbol",
                    "Weak Password",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Check if confirm password is empty
            if (string.IsNullOrEmpty(confirm))
            {
                MessageBox.Show(
                    "Please confirm your password.",
                    "Confirmation Missing",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Check if passwords match
            if (pass != confirm && confirm != pass)
            {
                MessageBox.Show(
                    "Passwords do not match. Please check and try again.",
                    "Mismatch",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            // If all checks pass
            MessageBox.Show(
                "Password reset successful!\nYou can now log in.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            // Optional: Close/reset
            // this.Close();
        }
        private bool IsPasswordStrong(string password)
        {
            if (password.Length < 8)
                return false;

            bool hasUpper = password.Any(char.IsUpper);
            bool hasLower = password.Any(char.IsLower);
            bool hasDigit = password.Any(char.IsDigit);
            bool hasSpecial = password.Any(ch => !char.IsLetterOrDigit(ch));

            return hasUpper && hasLower && hasDigit && hasSpecial;
        }
        private void CheckPasswordMatch()
        {
            string pass = Password.Content.Trim();
            string confirm = Confirmpassword.Content.Trim();

            // If confirm field is empty, show neutral hint
            if (string.IsNullOrEmpty(pass) && pass == confirm)
            {
                Matchstatus.Text = "Both passwords must match";
                Matchstatus.ForeColor = Color.Gray;
                Iconstatus.Image = Properties.Resources.warning__4_;
                Iconstatus.SizeMode = PictureBoxSizeMode.StretchImage;
                return;
            }

            // Check for password strength first
            if (!IsPasswordStrong(pass))
            {
                Matchstatus.Text = "Password must be at least 8 characters\nwith uppercase, lowercase, number & symbol";
                Matchstatus.ForeColor = Color.OrangeRed;
                Iconstatus.Image = Properties.Resources.warning__2_;
                Iconstatus.SizeMode = PictureBoxSizeMode.StretchImage;
                // custom orange ⚠ icon
                return;
            }

            // Match check
            if (pass == confirm)
            {
                Matchstatus.Text = "Passwords match";
                Matchstatus.ForeColor = Color.FromArgb(0, 200, 120);
                Iconstatus.Image = Properties.Resources.check;
                Iconstatus.SizeMode = PictureBoxSizeMode.StretchImage;// green ✔
            }
            else
            {
                Matchstatus.Text = "Passwords do not match";
                Matchstatus.ForeColor = Color.FromArgb(255, 85, 85);
                Iconstatus.Image = Properties.Resources.warning;
                Iconstatus.SizeMode = PictureBoxSizeMode.StretchImage;// red ✖
            }
        }

        private void PassTimer_Tick(object sender, EventArgs e)
        {
            CheckPasswordMatch();
        }
    }
}
