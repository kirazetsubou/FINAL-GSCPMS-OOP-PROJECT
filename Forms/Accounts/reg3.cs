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
    public partial class reg3 : UserControl
    {
        public reg3()
        {
            InitializeComponent();
            PassTimer.Interval = 200; // milliseconds
            PassTimer.Tick += PassTimer_Tick;
            PassTimer.Start();
        }

        private void hopeCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            Password.PasswordChar = !hopeCheckBox1.Checked;
            Confirmpassword.PasswordChar = !hopeCheckBox1.Checked;
        }

        private void PassTimer_Tick(object sender, EventArgs e)
        {
            CheckPasswordMatch();
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
            string email = Email.Content.Trim();
            string contact = ContactNumber.Content.Trim();

            // === Email empty check ===
            if (string.IsNullOrEmpty(email))
            {
                Matchstatus.Text = "Email address is required";
                Matchstatus.ForeColor = Color.OrangeRed;
                Iconstatus.Image = Properties.Resources.warning__3_;
                Iconstatus.SizeMode = PictureBoxSizeMode.StretchImage;
                return;
            }

            // === Contact number empty check ===
            if (string.IsNullOrEmpty(contact))
            {
                Matchstatus.Text = "Contact number is required";
                Matchstatus.ForeColor = Color.OrangeRed;
                Iconstatus.Image = Properties.Resources.warning__3_;
                Iconstatus.SizeMode = PictureBoxSizeMode.StretchImage;
                return;
            }

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
    }
}
