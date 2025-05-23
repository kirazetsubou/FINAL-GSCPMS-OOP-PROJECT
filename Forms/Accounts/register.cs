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
    public partial class register : Form
    {
        // Track current step and control
        private UserControl currentChildForm;
        private int currentStep = 1;

        // Step UserControls
        private reg1 reg1Control = new reg1();
        private reg2 reg2Control = new reg2();
        private reg3 reg3Control = new reg3();

        public register()
        {
            InitializeComponent();
        }

        private void register_Load(object sender, EventArgs e)
        {
            // Initialize progress tracker items once
          
            currentStep = 1;

            OpenChildForm(reg1Control);
            UpdateProgressTracker();
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
            childForm.BringToFront();
            childForm.Show();

            UpdateButtonVisibility();
            UpdateProgressTracker();
        }

        private void UpdateButtonVisibility()
        {
            btnBack.Visible = (currentStep > 1);
            btnNext.Visible = (currentStep < 3);
            btnRegister.Visible = (currentStep == 3);
        }

        private void UpdateProgressTracker()
        {
            // Set current progress (0-based index)
            trackerProgress.TasksProgress = currentStep;


            // Optional: refresh visual appearance
            trackerProgress.Invalidate();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentStep == 1)
            {
                currentStep = 2;
                OpenChildForm(reg2Control);
            }
            else if (currentStep == 2)
            {
                currentStep = 3;
                OpenChildForm(reg3Control);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (currentStep == 3)
            {
                currentStep = 2;
                OpenChildForm(reg2Control);
            }
            else if (currentStep == 2)
            {
                currentStep = 1;
                OpenChildForm(reg1Control);
            }
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login loginForm = new login();
            loginForm.Show();
            this.Hide();
        }
    }
}
