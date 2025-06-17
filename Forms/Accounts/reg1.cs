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
    public partial class reg1 : UserControl
    {
        public reg1()
        {
            InitializeComponent();
        }
        public bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(Fname.Text))
            {
                MessageBox.Show(" is required.");
                Fname.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(Lname.Text))
            {
                MessageBox.Show("is required.");
                Lname.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(MI.Text))
            {
                MessageBox.Show("Email is required.");
                MI.Focus();
                return false;
            }

            return true;

        }
        // Optional: Public properties to access input values
        public string Firstname => Fname.Text.Trim();
        public string Lastname => Lname.Text.Trim();
    }
}
