using CuoreUI.Controls;
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

        private void reg1_Load(object sender, EventArgs e)
        {

            Firstname.KeyPress += (s, ev) => LimitKeyPress(Firstname, ev, 20);
            Lastname.KeyPress += (s, ev) => LimitKeyPress(Lastname, ev, 20);
            MI.KeyPress += (s, ev) => LimitKeyPress(MI, ev, 2);
        }

   
        private void LimitKeyPress(CuoreUI.Controls.cuiTextBox box, KeyPressEventArgs e, int maxLength)
        {
            if (!char.IsControl(e.KeyChar) && box.Content.Length >= maxLength)
            {
                e.Handled = true; // Block extra character

                ToolTip tip = new ToolTip();
                tip.ToolTipTitle = "Limit Reached";
                tip.Show($"Maximum {maxLength} characters allowed.", box, 0, -20, 2000);
            }
        }

    }

}
