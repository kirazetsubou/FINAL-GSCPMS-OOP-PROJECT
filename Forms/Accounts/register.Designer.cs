namespace FINAL_GSCPMS_OOP_PROJECT.Forms.Accounts
{
    partial class register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(register));
            this.smallLabel3 = new ReaLTaiizor.Controls.SmallLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.displaypanel = new GSPMS.RPanel();
            this.cuiColorPicker1 = new CuoreUI.Components.cuiColorPicker(this.components);
            this.trackerProgress = new CuoreUI.Controls.cuiProgressTrackerHorizontal();
            this.Adspanel = new CuoreUI.Controls.cuiPanel();
            this.MainPic = new ReaLTaiizor.Controls.HopePictureBox();
            this.OverlayPic = new ReaLTaiizor.Controls.HopePictureBox();
            this.btnBack = new CuoreUI.Controls.cuiButton();
            this.btnNext = new CuoreUI.Controls.cuiButton();
            this.Slidetimer = new System.Windows.Forms.Timer(this.components);
            this.Fadetimer = new System.Windows.Forms.Timer(this.components);
            this.Adspanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OverlayPic)).BeginInit();
            this.SuspendLayout();
            // 
            // smallLabel3
            // 
            this.smallLabel3.AutoSize = true;
            this.smallLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smallLabel3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smallLabel3.ForeColor = System.Drawing.Color.Black;
            this.smallLabel3.Location = new System.Drawing.Point(46, 605);
            this.smallLabel3.Name = "smallLabel3";
            this.smallLabel3.Size = new System.Drawing.Size(157, 14);
            this.smallLabel3.TabIndex = 9;
            this.smallLabel3.Text = "Already have an account?";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.linkLabel2.Location = new System.Drawing.Point(209, 603);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(47, 14);
            this.linkLabel2.TabIndex = 10;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Sign In";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // displaypanel
            // 
            this.displaypanel.BackColor = System.Drawing.Color.LightGray;
            this.displaypanel.BorderColor = System.Drawing.Color.White;
            this.displaypanel.Edge = 20;
            this.displaypanel.Location = new System.Drawing.Point(343, 71);
            this.displaypanel.Name = "displaypanel";
            this.displaypanel.Size = new System.Drawing.Size(601, 528);
            this.displaypanel.TabIndex = 11;
            this.displaypanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.displaypanel_MouseMove);
            // 
            // cuiColorPicker1
            // 
            this.cuiColorPicker1.Color = System.Drawing.Color.Empty;
            this.cuiColorPicker1.EnableThemeChangeButton = true;
            this.cuiColorPicker1.Theme = CuoreUI.Components.Forms.ColorPickerForm.Themes.Dark;
            // 
            // trackerProgress
            // 
            this.trackerProgress.AutoRounding = true;
            this.trackerProgress.BackgroundImage = global::FINAL_GSCPMS_OOP_PROJECT.Properties.Resources._473571710_1028756222602780_3200496696713397802_n_removebg_preview;
            this.trackerProgress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.trackerProgress.CompletedColor = System.Drawing.Color.DeepSkyBlue;
            this.trackerProgress.CurrentTaskForeColor = System.Drawing.Color.Red;
            this.trackerProgress.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackerProgress.ForeColor = System.Drawing.SystemColors.ControlText;
            this.trackerProgress.LineThickness = 4;
            this.trackerProgress.Location = new System.Drawing.Point(346, 32);
            this.trackerProgress.Margin = new System.Windows.Forms.Padding(2);
            this.trackerProgress.Name = "trackerProgress";
            this.trackerProgress.Rounding = 15;
            this.trackerProgress.ShowSymbols = true;
            this.trackerProgress.Size = new System.Drawing.Size(598, 45);
            this.trackerProgress.TabIndex = 0;
            this.trackerProgress.TaskForeColor = System.Drawing.Color.DeepSkyBlue;
            this.trackerProgress.Tasks = new string[] {
        "Create Account",
        "Address Details",
        "Account Setup"};
            this.trackerProgress.TasksProgress = 2;
            this.trackerProgress.Text = "cuiProgressTrackerHorizontal1";
            this.trackerProgress.TrackColor = System.Drawing.Color.DeepSkyBlue;
            // 
            // Adspanel
            // 
            this.Adspanel.Controls.Add(this.MainPic);
            this.Adspanel.Controls.Add(this.OverlayPic);
            this.Adspanel.Location = new System.Drawing.Point(20, 32);
            this.Adspanel.Margin = new System.Windows.Forms.Padding(2);
            this.Adspanel.Name = "Adspanel";
            this.Adspanel.OutlineThickness = 1F;
            this.Adspanel.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.Adspanel.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.Adspanel.Rounding = new System.Windows.Forms.Padding(25);
            this.Adspanel.Size = new System.Drawing.Size(302, 528);
            this.Adspanel.TabIndex = 15;
            // 
            // MainPic
            // 
            this.MainPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.MainPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPic.Location = new System.Drawing.Point(0, 0);
            this.MainPic.Name = "MainPic";
            this.MainPic.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.MainPic.Size = new System.Drawing.Size(302, 528);
            this.MainPic.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.MainPic.TabIndex = 1;
            this.MainPic.TabStop = false;
            this.MainPic.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // OverlayPic
            // 
            this.OverlayPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.OverlayPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OverlayPic.Location = new System.Drawing.Point(0, 0);
            this.OverlayPic.Name = "OverlayPic";
            this.OverlayPic.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.OverlayPic.Size = new System.Drawing.Size(302, 528);
            this.OverlayPic.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.OverlayPic.TabIndex = 0;
            this.OverlayPic.TabStop = false;
            this.OverlayPic.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.OverlayPic.Paint += new System.Windows.Forms.PaintEventHandler(this.OverlayPic_Paint);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.CheckButton = false;
            this.btnBack.Checked = false;
            this.btnBack.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnBack.CheckedForeColor = System.Drawing.Color.White;
            this.btnBack.CheckedImageTint = System.Drawing.Color.White;
            this.btnBack.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnBack.Content = "Back";
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.HoverBackground = System.Drawing.Color.White;
            this.btnBack.HoveredImageTint = System.Drawing.Color.White;
            this.btnBack.HoverForeColor = System.Drawing.Color.Black;
            this.btnBack.HoverOutline = System.Drawing.Color.Aqua;
            this.btnBack.Image = null;
            this.btnBack.ImageAutoCenter = true;
            this.btnBack.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnBack.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnBack.Location = new System.Drawing.Point(441, 642);
            this.btnBack.Name = "btnBack";
            this.btnBack.NormalBackground = System.Drawing.Color.White;
            this.btnBack.NormalForeColor = System.Drawing.Color.Black;
            this.btnBack.NormalImageTint = System.Drawing.Color.White;
            this.btnBack.NormalOutline = System.Drawing.Color.DeepSkyBlue;
            this.btnBack.OutlineThickness = 1F;
            this.btnBack.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.btnBack.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnBack.PressedImageTint = System.Drawing.Color.White;
            this.btnBack.PressedOutline = System.Drawing.Color.Red;
            this.btnBack.Rounding = new System.Windows.Forms.Padding(25);
            this.btnBack.Size = new System.Drawing.Size(160, 45);
            this.btnBack.TabIndex = 16;
            this.btnBack.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnBack.TextOffset = new System.Drawing.Point(0, 0);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.CheckButton = false;
            this.btnNext.Checked = false;
            this.btnNext.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnNext.CheckedForeColor = System.Drawing.Color.White;
            this.btnNext.CheckedImageTint = System.Drawing.Color.White;
            this.btnNext.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnNext.Content = "Next";
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.HoverBackground = System.Drawing.Color.White;
            this.btnNext.HoveredImageTint = System.Drawing.Color.White;
            this.btnNext.HoverForeColor = System.Drawing.Color.Black;
            this.btnNext.HoverOutline = System.Drawing.Color.Aqua;
            this.btnNext.Image = null;
            this.btnNext.ImageAutoCenter = true;
            this.btnNext.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnNext.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnNext.Location = new System.Drawing.Point(748, 642);
            this.btnNext.Name = "btnNext";
            this.btnNext.NormalBackground = System.Drawing.Color.White;
            this.btnNext.NormalForeColor = System.Drawing.Color.Black;
            this.btnNext.NormalImageTint = System.Drawing.Color.White;
            this.btnNext.NormalOutline = System.Drawing.Color.DeepSkyBlue;
            this.btnNext.OutlineThickness = 1F;
            this.btnNext.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.btnNext.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnNext.PressedImageTint = System.Drawing.Color.White;
            this.btnNext.PressedOutline = System.Drawing.Color.Red;
            this.btnNext.Rounding = new System.Windows.Forms.Padding(25);
            this.btnNext.Size = new System.Drawing.Size(152, 45);
            this.btnNext.TabIndex = 17;
            this.btnNext.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnNext.TextOffset = new System.Drawing.Point(0, 0);
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // Slidetimer
            // 
            this.Slidetimer.Tick += new System.EventHandler(this.Slidetimer_Tick);
            // 
            // Fadetimer
            // 
            this.Fadetimer.Tick += new System.EventHandler(this.Fadetimer_Tick);
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(983, 715);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.smallLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.trackerProgress);
            this.Controls.Add(this.displaypanel);
            this.Controls.Add(this.Adspanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "register";
            this.Load += new System.EventHandler(this.register_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.register_MouseDown);
            this.Adspanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OverlayPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GSPMS.RPanel displaypanel;
        private ReaLTaiizor.Controls.SmallLabel smallLabel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private CuoreUI.Components.cuiColorPicker cuiColorPicker1;
        private CuoreUI.Controls.cuiProgressTrackerHorizontal trackerProgress;
        private CuoreUI.Controls.cuiPanel Adspanel;
        private CuoreUI.Controls.cuiButton btnBack;
        private CuoreUI.Controls.cuiButton btnNext;
        private ReaLTaiizor.Controls.HopePictureBox MainPic;
        private ReaLTaiizor.Controls.HopePictureBox OverlayPic;
        private System.Windows.Forms.Timer Slidetimer;
        private System.Windows.Forms.Timer Fadetimer;
    }
}