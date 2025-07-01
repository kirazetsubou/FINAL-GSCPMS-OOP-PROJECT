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
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect,
        int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        public Resetpass()
        {
            InitializeComponent();
        }

        private void Password_ContentChanged(object sender, EventArgs e)
        {
            CheckPasswordMatch();
        }

        private void Confirmpassword_ContentChanged(object sender, EventArgs e)
        {
            CheckPasswordMatch();
        }
        private void CheckPasswordMatch()
        {
            string pass = Password.Content.Trim();
            string confirm = Confirmpassword.Content.Trim();

            if (string.IsNullOrEmpty(confirm))
            {
                Matchstatus.Text = "Both passwords must match";
                Matchstatus.ForeColor = Color.Gray;
                // placeholder icon
                return;
            }

            if (pass == confirm)
            {
                Matchstatus.Text = "Passwords match";
                Matchstatus.ForeColor = Color.FromArgb(0, 200, 120); // green
                // ✔ icon
            }
            else
            {
                Matchstatus.Text = "Passwords do not match";
                Matchstatus.ForeColor = Color.FromArgb(255, 85, 85); // red
                 // ❌ icon
            }
        }

        private void Showpass_CheckedChanged(object sender, EventArgs e)
        {
            Password.PasswordChar = !Showpass.Checked;
            Confirmpassword.PasswordChar = !Showpass.Checked;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            string pass = Password.Content.Trim();
            string confirm = Confirmpassword.Content.Trim();

            if (pass == confirm && !string.IsNullOrEmpty(pass))
            {
                MessageBox.Show(
                    "Password reset successful!\nYou can now log in.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                login log = new login();
                log.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show(
                    "Passwords do not match. Please check again.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
