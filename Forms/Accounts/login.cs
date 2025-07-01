using FINAL_GSCPMS_OOP_PROJECT.Forms.Accounts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FINAL_GSCPMS_OOP_PROJECT
{
    public partial class login : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public string connectionString = "Data Source=192.168.100.226,1433;Initial Catalog=Employee;Persist Security Info=True;User ID=Stephen;Password=***********;Trust Server Certificate=True;";

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        private List<Image> imageList = new List<Image>();
        private int currentIndex = 0;
        private float fadeStep = 0.05f; // Lower = smoother
        private float currentOpacity = 0;

        public login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        private void login_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void Showpass_CheckedChanged(object sender, EventArgs e)
        {
            Password.PasswordChar = !Showpass.Checked;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Employees WHERE Username = @username AND Password = @password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", Username.Text);
                cmd.Parameters.AddWithValue("@password", Password.Text);

                int result = (int)cmd.ExecuteScalar();
                if (result > 0)
                {
                    MessageBox.Show("Login successful!");
                    // Proceed to next form or dashboard
                }
                else
                {
                    MessageBox.Show("Invalid credentials.");
                }
            }
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_Load(object sender, EventArgs e)
        {
            // Load images (from files or Resources)
            imageList.Add(Properties.Resources._473571710_1028756222602780_3200496696713397802_n_removebg_preview);
            imageList.Add(Properties.Resources._509419587_2439523766418370_2887840080118874903_n);
            imageList.Add(Properties.Resources.image_2025_04_11_181516953_removebg_preview);

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

        private void forget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgotpass forgot = new forgotpass();
            forgot.Show();
            this.Hide();
        }

        private void create_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register reg = new register();
            reg.Show();
            this.Hide();
        }
    }
}
