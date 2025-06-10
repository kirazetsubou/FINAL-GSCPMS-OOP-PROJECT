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
        }

        private void hopeCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            hopeTextBox3.UseSystemPasswordChar = !hopeCheckBox1.Checked;
            hopeTextBox4.UseSystemPasswordChar = !hopeCheckBox1.Checked;
        }
    }
}
