using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL_GSCPMS_OOP_PROJECT.Forms.Accounts
{
    public partial class Consent : Form
    {
        public Consent()
        {
            InitializeComponent();
        }

        private void Authorize_Click(object sender, EventArgs e)
        {
            login start = new login();
            start.Show();
            this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register register = new register();
            register.Show();
            this.Close();
        }
    }
}
