using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL_GSCPMS_OOP_PROJECT.Forms.Admin
{
    public partial class admin : Form
    {
        private UserControl currentChildForm;

        public admin()
        {
            InitializeComponent();
        }

        private void admin_Load(object sender, EventArgs e)
        {
            OpenChildForm(new admindashboard());
        }
        
        private void OpenChildForm(UserControl childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Hide();
            }
            currentChildForm = childForm;
            childForm.Dock = DockStyle.Fill;
            displaypanel.Controls.Clear();
            displaypanel.Controls.Add(childForm);
            displaypanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

    }
}
