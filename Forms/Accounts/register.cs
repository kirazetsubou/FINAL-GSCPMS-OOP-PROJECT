using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
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
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        private List<Image> imageList = new List<Image>();
        private int currentIndex = 0;
        private float fadeStep = 0.05f; // Lower = smoother
        private float currentOpacity = 0;


        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
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
            // Load images (from files or Resources)
            imageList.Add(Properties.Resources._509419587_2439523766418370_2887840080118874903_n);
            imageList.Add(Properties.Resources._512215710_996936782380198_6384260421581847698_n);
            imageList.Add(Properties.Resources._513826234_501765012998473_3489009582914280092_n);
            imageList.Add(Properties.Resources._514149210_1079235840807255_9117152410366927352_n);
            imageList.Add(Properties.Resources._515093650_1814404569510179_258245541417495643_n);

            // Initial display
            MainPic.Image = imageList[0];
            MainPic.Dock = DockStyle.Fill;
            OverlayPic.Dock = DockStyle.Fill;

            // No border
            MainPic.SizeMode = PictureBoxSizeMode.StretchImage;
            OverlayPic.SizeMode = PictureBoxSizeMode.StretchImage;

            OverlayPic.BackColor = Color.Transparent;

            // Start slideshow
            Slidetimer.Interval = 5000; // 5 seconds between slides
            Slidetimer.Tick += Slidetimer_Tick;
            Slidetimer.Start();

            // Fade timer setup
            Fadetimer.Interval = 50; // ms per fade step
            Fadetimer.Tick += Fadetimer_Tick;
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

            if (currentStep == 3)
            {
                btnNext.Content = "Register";

                // Remove existing handler to avoid multiple assignments
                btnNext.Click -= btnNext_Click;
                btnNext.Click -= btnRegister_Click; // in case it's already attached
                btnNext.Click += btnRegister_Click;
            }
            else
            {
                btnNext.Content = "Next";

                // Make sure it uses the Next handler
                btnNext.Click -= btnRegister_Click;
                btnNext.Click -= btnNext_Click;
                btnNext.Click += btnNext_Click;
            }
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
               
                bool isValid = ValidateAllControls(currentChildForm);

                if (isValid)
                {
                    // Proceed with registration logic
                    MessageBox.Show("All fields are valid. Proceeding with registration.");
                    currentStep = 2;
                    OpenChildForm(reg2Control);
                }
                else
                {
                    MessageBox.Show("Please fill in all required fields.");
                }

            }
            else if (currentStep == 2)
            {
                bool isValid = ValidateAllControls(currentChildForm);
                if (isValid)
                {
                    // Proceed with registration logic
                    MessageBox.Show("All fields are valid. Proceeding with registration.");
                    currentStep = 3;
                    OpenChildForm(reg3Control);
                }
                else
                {
                    MessageBox.Show("Please fill in all required fields.");
                }
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


        private void register_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void rPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void displaypanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void hopePictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            bool isValid = ValidateAllControls(currentChildForm);

            if (isValid)
            {
                // Proceed with registration logic
                MessageBox.Show("All fields are valid. Proceed to login");
                Consent Back = new Consent();
                Back.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill in all required fields.");
            }

        }
        private bool ValidateAllControls(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is TextBox textBox)
                {
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        textBox.BackColor = Color.HotPink;
                        return false;
                    }
                    else
                    {
                        textBox.BackColor = SystemColors.Window;
                    }
                }
                else if (c is ComboBox comboBox)
                {
                    if (comboBox.SelectedIndex == -1)
                    {
                        comboBox.BackColor = Color.HotPink;
                        return false;
                    }
                    else
                    {
                        comboBox.BackColor = SystemColors.Window;
                    }
                }
                else if (c is DateTimePicker dateTimePicker)
                {
                    // Optional: add date range validation
                    if (dateTimePicker.Value == null)
                    {
                        dateTimePicker.CalendarForeColor = Color.Red;
                        return false;
                    }
                    else
                    {
                        dateTimePicker.CalendarForeColor = SystemColors.WindowText;
                    }
                }

                // Recursively validate child controls (e.g., inside panels)
                if (c.HasChildren)
                {
                    if (!ValidateAllControls(c))
                        return false;
                }
            }

            return true;
        }
        private void Slidetimer_Tick(object sender, EventArgs e)
        {
            // Set next image on overlay
            currentIndex = (currentIndex + 1) % imageList.Count;
            OverlayPic.Image = imageList[currentIndex];
            OverlayPic.Visible = true;
            currentOpacity = 0;
            Fadetimer.Start();
        }

        private void Fadetimer_Tick(object sender, EventArgs e)
        {
            currentOpacity += fadeStep;
            if (currentOpacity >= 1.0f)
            {
                // Done fading
                Fadetimer.Stop();
                MainPic.Image = OverlayPic.Image;
                OverlayPic.Visible = false;
            }
            else
            {
                OverlayPic.Invalidate(); // Force redraw
            }
        }

        private void OverlayPic_Paint(object sender, PaintEventArgs e)
        {
            if (OverlayPic.Image != null)
            {
                ColorMatrix matrix = new ColorMatrix();
                matrix.Matrix33 = currentOpacity;

                ImageAttributes attr = new ImageAttributes();
                attr.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                e.Graphics.DrawImage(
                    OverlayPic.Image,
                    new Rectangle(0, 0, OverlayPic.Width, OverlayPic.Height),
                    0, 0,
                    OverlayPic.Image.Width,
                    OverlayPic.Image.Height,
                    GraphicsUnit.Pixel,
                    attr
                );
            }
        }

    }
}
