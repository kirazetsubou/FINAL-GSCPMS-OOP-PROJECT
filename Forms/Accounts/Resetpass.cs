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
            string pass = Password.Text.Trim();
            string confirm = Confirmpassword.Text.Trim();

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

    }
}
