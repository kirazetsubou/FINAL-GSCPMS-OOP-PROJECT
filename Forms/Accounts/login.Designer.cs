namespace FINAL_GSCPMS_OOP_PROJECT
{
    partial class login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.AdsPanel = new CuoreUI.Controls.cuiPanel();
            this.MainPic = new ReaLTaiizor.Controls.HopePictureBox();
            this.OverlayPic = new ReaLTaiizor.Controls.HopePictureBox();
            this.Username = new CuoreUI.Controls.cuiTextBox();
            this.smallLabel4 = new ReaLTaiizor.Controls.SmallLabel();
            this.create = new System.Windows.Forms.LinkLabel();
            this.smallLabel5 = new ReaLTaiizor.Controls.SmallLabel();
            this.smallLabel3 = new ReaLTaiizor.Controls.SmallLabel();
            this.btnLogin = new CuoreUI.Controls.cuiButton();
            this.Password = new CuoreUI.Controls.cuiTextBox();
            this.Showpass = new ReaLTaiizor.Controls.HopeCheckBox();
            this.Forget = new System.Windows.Forms.LinkLabel();
            this.Slidetimer = new System.Windows.Forms.Timer(this.components);
            this.Fadetimer = new System.Windows.Forms.Timer(this.components);
            this.cuiButton1 = new CuoreUI.Controls.cuiButton();
            this.Exit = new CuoreUI.Controls.cuiButton();
            this.AdsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OverlayPic)).BeginInit();
            this.SuspendLayout();
            // 
            // AdsPanel
            // 
            this.AdsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AdsPanel.Controls.Add(this.MainPic);
            this.AdsPanel.Controls.Add(this.OverlayPic);
            this.AdsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.AdsPanel.Location = new System.Drawing.Point(0, 0);
            this.AdsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.AdsPanel.Name = "AdsPanel";
            this.AdsPanel.OutlineThickness = 1F;
            this.AdsPanel.PanelColor = System.Drawing.Color.Transparent;
            this.AdsPanel.PanelOutlineColor = System.Drawing.Color.Transparent;
            this.AdsPanel.Rounding = new System.Windows.Forms.Padding(50);
            this.AdsPanel.Size = new System.Drawing.Size(329, 491);
            this.AdsPanel.TabIndex = 2;
            // 
            // MainPic
            // 
            this.MainPic.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.MainPic.BackgroundImage = global::FINAL_GSCPMS_OOP_PROJECT.Properties.Resources._509419587_2439523766418370_2887840080118874903_n;
            this.MainPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPic.Location = new System.Drawing.Point(0, 0);
            this.MainPic.Margin = new System.Windows.Forms.Padding(2);
            this.MainPic.Name = "MainPic";
            this.MainPic.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.MainPic.Size = new System.Drawing.Size(329, 491);
            this.MainPic.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.MainPic.TabIndex = 0;
            this.MainPic.TabStop = false;
            this.MainPic.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // OverlayPic
            // 
            this.OverlayPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.OverlayPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OverlayPic.Location = new System.Drawing.Point(0, 0);
            this.OverlayPic.Margin = new System.Windows.Forms.Padding(2);
            this.OverlayPic.Name = "OverlayPic";
            this.OverlayPic.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.OverlayPic.Size = new System.Drawing.Size(329, 491);
            this.OverlayPic.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.OverlayPic.TabIndex = 1;
            this.OverlayPic.TabStop = false;
            this.OverlayPic.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.OverlayPic.Paint += new System.Windows.Forms.PaintEventHandler(this.OverlayPic_Paint);
            // 
            // Username
            // 
            this.Username.BackgroundColor = System.Drawing.Color.White;
            this.Username.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Username.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.Username.Content = "";
            this.Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Username.FocusBackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.Username.FocusBorderColor = System.Drawing.Color.Red;
            this.Username.FocusImageTint = System.Drawing.Color.DimGray;
            this.Username.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.Color.Black;
            this.Username.Image = null;
            this.Username.ImageExpand = new System.Drawing.Point(10, 10);
            this.Username.ImageOffset = new System.Drawing.Point(5, 5);
            this.Username.Location = new System.Drawing.Point(366, 151);
            this.Username.Margin = new System.Windows.Forms.Padding(4);
            this.Username.Multiline = false;
            this.Username.Name = "Username";
            this.Username.NormalImageTint = System.Drawing.Color.White;
            this.Username.Padding = new System.Windows.Forms.Padding(16, 14, 16, 0);
            this.Username.PasswordChar = false;
            this.Username.PlaceholderColor = System.Drawing.Color.Black;
            this.Username.PlaceholderText = " Email";
            this.Username.Rounding = new System.Windows.Forms.Padding(25);
            this.Username.Size = new System.Drawing.Size(266, 45);
            this.Username.TabIndex = 15;
            this.Username.TextOffset = new System.Drawing.Size(0, 0);
            this.Username.UnderlinedStyle = true;
            // 
            // smallLabel4
            // 
            this.smallLabel4.AutoSize = true;
            this.smallLabel4.BackColor = System.Drawing.Color.Transparent;
            this.smallLabel4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smallLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.smallLabel4.Location = new System.Drawing.Point(380, 60);
            this.smallLabel4.Name = "smallLabel4";
            this.smallLabel4.Size = new System.Drawing.Size(247, 37);
            this.smallLabel4.TabIndex = 9;
            this.smallLabel4.Text = "Welcome Back";
            // 
            // create
            // 
            this.create.AutoSize = true;
            this.create.BackColor = System.Drawing.Color.Transparent;
            this.create.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.create.Location = new System.Drawing.Point(546, 392);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(47, 12);
            this.create.TabIndex = 8;
            this.create.TabStop = true;
            this.create.Text = "Sign Up";
            this.create.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.create_LinkClicked);
            // 
            // smallLabel5
            // 
            this.smallLabel5.AutoSize = true;
            this.smallLabel5.BackColor = System.Drawing.Color.Transparent;
            this.smallLabel5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smallLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.smallLabel5.Location = new System.Drawing.Point(413, 114);
            this.smallLabel5.Name = "smallLabel5";
            this.smallLabel5.Size = new System.Drawing.Size(197, 14);
            this.smallLabel5.TabIndex = 10;
            this.smallLabel5.Text = "Login to your account to continue";
            // 
            // smallLabel3
            // 
            this.smallLabel3.AutoSize = true;
            this.smallLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smallLabel3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smallLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.smallLabel3.Location = new System.Drawing.Point(407, 392);
            this.smallLabel3.Name = "smallLabel3";
            this.smallLabel3.Size = new System.Drawing.Size(133, 12);
            this.smallLabel3.TabIndex = 7;
            this.smallLabel3.Text = "Dont have an account?";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.CheckButton = false;
            this.btnLogin.Checked = false;
            this.btnLogin.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnLogin.CheckedForeColor = System.Drawing.Color.White;
            this.btnLogin.CheckedImageTint = System.Drawing.Color.White;
            this.btnLogin.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnLogin.Content = "LOGIN";
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.HoverBackground = System.Drawing.Color.White;
            this.btnLogin.HoveredImageTint = System.Drawing.Color.White;
            this.btnLogin.HoverForeColor = System.Drawing.Color.Black;
            this.btnLogin.HoverOutline = System.Drawing.Color.Aqua;
            this.btnLogin.Image = null;
            this.btnLogin.ImageAutoCenter = true;
            this.btnLogin.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnLogin.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnLogin.Location = new System.Drawing.Point(407, 326);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.NormalBackground = System.Drawing.Color.White;
            this.btnLogin.NormalForeColor = System.Drawing.Color.Black;
            this.btnLogin.NormalImageTint = System.Drawing.Color.White;
            this.btnLogin.NormalOutline = System.Drawing.Color.DeepSkyBlue;
            this.btnLogin.OutlineThickness = 1F;
            this.btnLogin.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.btnLogin.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnLogin.PressedImageTint = System.Drawing.Color.White;
            this.btnLogin.PressedOutline = System.Drawing.Color.Red;
            this.btnLogin.Rounding = new System.Windows.Forms.Padding(25);
            this.btnLogin.Size = new System.Drawing.Size(186, 45);
            this.btnLogin.TabIndex = 14;
            this.btnLogin.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnLogin.TextOffset = new System.Drawing.Point(0, 0);
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Password
            // 
            this.Password.BackgroundColor = System.Drawing.Color.White;
            this.Password.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.Password.Content = "";
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password.FocusBackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.Password.FocusBorderColor = System.Drawing.Color.Red;
            this.Password.FocusImageTint = System.Drawing.Color.White;
            this.Password.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.Color.Black;
            this.Password.Image = null;
            this.Password.ImageExpand = new System.Drawing.Point(0, 0);
            this.Password.ImageOffset = new System.Drawing.Point(0, 0);
            this.Password.Location = new System.Drawing.Point(366, 214);
            this.Password.Margin = new System.Windows.Forms.Padding(4);
            this.Password.Multiline = false;
            this.Password.Name = "Password";
            this.Password.NormalImageTint = System.Drawing.Color.White;
            this.Password.Padding = new System.Windows.Forms.Padding(16, 14, 16, 0);
            this.Password.PasswordChar = true;
            this.Password.PlaceholderColor = System.Drawing.SystemColors.WindowText;
            this.Password.PlaceholderText = "Password";
            this.Password.Rounding = new System.Windows.Forms.Padding(25);
            this.Password.Size = new System.Drawing.Size(266, 45);
            this.Password.TabIndex = 16;
            this.Password.TextOffset = new System.Drawing.Size(0, 0);
            this.Password.UnderlinedStyle = true;
            // 
            // Showpass
            // 
            this.Showpass.AutoSize = true;
            this.Showpass.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Showpass.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.Showpass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Showpass.DisabledColor = System.Drawing.Color.White;
            this.Showpass.DisabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.Showpass.Enable = true;
            this.Showpass.EnabledCheckedColor = System.Drawing.Color.DeepSkyBlue;
            this.Showpass.EnabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.Showpass.EnabledUncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(158)))), ((int)(((byte)(161)))));
            this.Showpass.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Showpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.Showpass.Location = new System.Drawing.Point(366, 287);
            this.Showpass.Name = "Showpass";
            this.Showpass.Size = new System.Drawing.Size(117, 20);
            this.Showpass.TabIndex = 5;
            this.Showpass.Text = "Show Password";
            this.Showpass.UseVisualStyleBackColor = false;
            this.Showpass.CheckedChanged += new System.EventHandler(this.Showpass_CheckedChanged);
            // 
            // Forget
            // 
            this.Forget.AutoSize = true;
            this.Forget.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Forget.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.Forget.Location = new System.Drawing.Point(566, 290);
            this.Forget.Name = "Forget";
            this.Forget.Size = new System.Drawing.Size(105, 12);
            this.Forget.TabIndex = 6;
            this.Forget.TabStop = true;
            this.Forget.Text = "Forgot password?";
            this.Forget.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forget_LinkClicked);
            // 
            // Slidetimer
            // 
            this.Slidetimer.Tick += new System.EventHandler(this.Slidetimer_Tick);
            // 
            // Fadetimer
            // 
            this.Fadetimer.Tick += new System.EventHandler(this.Fadetimer_Tick);
            // 
            // cuiButton1
            // 
            this.cuiButton1.CheckButton = false;
            this.cuiButton1.Checked = false;
            this.cuiButton1.CheckedBackground = System.Drawing.Color.Gainsboro;
            this.cuiButton1.CheckedForeColor = System.Drawing.Color.Red;
            this.cuiButton1.CheckedImageTint = System.Drawing.Color.White;
            this.cuiButton1.CheckedOutline = System.Drawing.Color.DeepSkyBlue;
            this.cuiButton1.Content = "Sign in with google";
            this.cuiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cuiButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiButton1.ForeColor = System.Drawing.Color.Black;
            this.cuiButton1.HoverBackground = System.Drawing.Color.White;
            this.cuiButton1.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton1.HoverForeColor = System.Drawing.Color.DeepSkyBlue;
            this.cuiButton1.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton1.Image = global::FINAL_GSCPMS_OOP_PROJECT.Properties.Resources.google;
            this.cuiButton1.ImageAutoCenter = false;
            this.cuiButton1.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton1.ImageOffset = new System.Drawing.Point(25, 0);
            this.cuiButton1.Location = new System.Drawing.Point(407, 418);
            this.cuiButton1.Name = "cuiButton1";
            this.cuiButton1.NormalBackground = System.Drawing.Color.White;
            this.cuiButton1.NormalForeColor = System.Drawing.Color.Black;
            this.cuiButton1.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton1.NormalOutline = System.Drawing.Color.DeepSkyBlue;
            this.cuiButton1.OutlineThickness = 1F;
            this.cuiButton1.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.cuiButton1.PressedForeColor = System.Drawing.Color.DeepSkyBlue;
            this.cuiButton1.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton1.PressedOutline = System.Drawing.Color.Red;
            this.cuiButton1.Rounding = new System.Windows.Forms.Padding(25);
            this.cuiButton1.Size = new System.Drawing.Size(186, 52);
            this.cuiButton1.TabIndex = 18;
            this.cuiButton1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.cuiButton1.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.CheckButton = false;
            this.Exit.Checked = false;
            this.Exit.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.Exit.CheckedForeColor = System.Drawing.Color.White;
            this.Exit.CheckedImageTint = System.Drawing.Color.White;
            this.Exit.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.Exit.Content = "";
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.Black;
            this.Exit.HoverBackground = System.Drawing.Color.White;
            this.Exit.HoveredImageTint = System.Drawing.Color.White;
            this.Exit.HoverForeColor = System.Drawing.Color.Black;
            this.Exit.HoverOutline = System.Drawing.Color.Aqua;
            this.Exit.Image = global::FINAL_GSCPMS_OOP_PROJECT.Properties.Resources.Cancel;
            this.Exit.ImageAutoCenter = true;
            this.Exit.ImageExpand = new System.Drawing.Point(15, 15);
            this.Exit.ImageOffset = new System.Drawing.Point(0, 0);
            this.Exit.Location = new System.Drawing.Point(633, 12);
            this.Exit.Name = "Exit";
            this.Exit.NormalBackground = System.Drawing.Color.White;
            this.Exit.NormalForeColor = System.Drawing.Color.Black;
            this.Exit.NormalImageTint = System.Drawing.Color.White;
            this.Exit.NormalOutline = System.Drawing.Color.Transparent;
            this.Exit.OutlineThickness = 1F;
            this.Exit.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.Exit.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Exit.PressedImageTint = System.Drawing.Color.White;
            this.Exit.PressedOutline = System.Drawing.Color.Red;
            this.Exit.Rounding = new System.Windows.Forms.Padding(20);
            this.Exit.Size = new System.Drawing.Size(49, 45);
            this.Exit.TabIndex = 19;
            this.Exit.TextAlignment = System.Drawing.StringAlignment.Center;
            this.Exit.TextOffset = new System.Drawing.Point(0, 0);
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 491);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.cuiButton1);
            this.Controls.Add(this.AdsPanel);
            this.Controls.Add(this.smallLabel3);
            this.Controls.Add(this.create);
            this.Controls.Add(this.smallLabel4);
            this.Controls.Add(this.smallLabel5);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Showpass);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Forget);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 1040);
            this.MinimumSize = new System.Drawing.Size(190, 40);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.login_MouseDown);
            this.AdsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OverlayPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CuoreUI.Controls.cuiPanel AdsPanel;
        private CuoreUI.Controls.cuiTextBox Username;
        private ReaLTaiizor.Controls.SmallLabel smallLabel4;
        private System.Windows.Forms.LinkLabel create;
        private ReaLTaiizor.Controls.SmallLabel smallLabel5;
        private ReaLTaiizor.Controls.SmallLabel smallLabel3;
        private CuoreUI.Controls.cuiButton btnLogin;
        private CuoreUI.Controls.cuiTextBox Password;
        private ReaLTaiizor.Controls.HopeCheckBox Showpass;
        private System.Windows.Forms.LinkLabel Forget;
        private System.Windows.Forms.Timer Slidetimer;
        private System.Windows.Forms.Timer Fadetimer;
        private ReaLTaiizor.Controls.HopePictureBox OverlayPic;
        private ReaLTaiizor.Controls.HopePictureBox MainPic;
        private CuoreUI.Controls.cuiButton cuiButton1;
        private CuoreUI.Controls.cuiButton Exit;
    }
}

