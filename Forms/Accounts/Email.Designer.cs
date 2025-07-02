namespace FINAL_GSCPMS_OOP_PROJECT.Forms.Accounts
{
    partial class Email
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Email));
            this.dungeonHeaderLabel1 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.nightLabel1 = new ReaLTaiizor.Controls.NightLabel();
            this.Gmail = new CuoreUI.Controls.cuiButton();
            this.EmailIcon = new CuoreUI.Controls.cuiPictureBox();
            this.SuspendLayout();
            // 
            // dungeonHeaderLabel1
            // 
            this.dungeonHeaderLabel1.AutoSize = true;
            this.dungeonHeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.dungeonHeaderLabel1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.dungeonHeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonHeaderLabel1.Location = new System.Drawing.Point(59, 225);
            this.dungeonHeaderLabel1.Name = "dungeonHeaderLabel1";
            this.dungeonHeaderLabel1.Size = new System.Drawing.Size(128, 20);
            this.dungeonHeaderLabel1.TabIndex = 2;
            this.dungeonHeaderLabel1.Text = "Check your email";
            // 
            // nightLabel1
            // 
            this.nightLabel1.AutoSize = true;
            this.nightLabel1.BackColor = System.Drawing.Color.Transparent;
            this.nightLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nightLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(127)))));
            this.nightLabel1.Location = new System.Drawing.Point(31, 258);
            this.nightLabel1.Name = "nightLabel1";
            this.nightLabel1.Size = new System.Drawing.Size(168, 30);
            this.nightLabel1.TabIndex = 3;
            this.nightLabel1.Text = "We\'ve sent a password recover\r\n instructions to\r\n";
            // 
            // Gmail
            // 
            this.Gmail.BackColor = System.Drawing.Color.Transparent;
            this.Gmail.CheckButton = false;
            this.Gmail.Checked = false;
            this.Gmail.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.Gmail.CheckedForeColor = System.Drawing.Color.White;
            this.Gmail.CheckedImageTint = System.Drawing.Color.White;
            this.Gmail.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.Gmail.Content = "Open Gmail";
            this.Gmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gmail.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Gmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gmail.ForeColor = System.Drawing.Color.Black;
            this.Gmail.HoverBackground = System.Drawing.Color.White;
            this.Gmail.HoveredImageTint = System.Drawing.Color.White;
            this.Gmail.HoverForeColor = System.Drawing.Color.Black;
            this.Gmail.HoverOutline = System.Drawing.Color.Aqua;
            this.Gmail.Image = null;
            this.Gmail.ImageAutoCenter = true;
            this.Gmail.ImageExpand = new System.Drawing.Point(0, 0);
            this.Gmail.ImageOffset = new System.Drawing.Point(0, 0);
            this.Gmail.Location = new System.Drawing.Point(34, 323);
            this.Gmail.Name = "Gmail";
            this.Gmail.NormalBackground = System.Drawing.Color.White;
            this.Gmail.NormalForeColor = System.Drawing.Color.Black;
            this.Gmail.NormalImageTint = System.Drawing.Color.White;
            this.Gmail.NormalOutline = System.Drawing.Color.DeepSkyBlue;
            this.Gmail.OutlineThickness = 1F;
            this.Gmail.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.Gmail.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Gmail.PressedImageTint = System.Drawing.Color.White;
            this.Gmail.PressedOutline = System.Drawing.Color.Red;
            this.Gmail.Rounding = new System.Windows.Forms.Padding(25);
            this.Gmail.Size = new System.Drawing.Size(186, 45);
            this.Gmail.TabIndex = 27;
            this.Gmail.TextAlignment = System.Drawing.StringAlignment.Center;
            this.Gmail.TextOffset = new System.Drawing.Point(0, 0);
            this.Gmail.Click += new System.EventHandler(this.Gmail_Click);
            // 
            // EmailIcon
            // 
            this.EmailIcon.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.EmailIcon.BackgroundImage = global::FINAL_GSCPMS_OOP_PROJECT.Properties.Resources._513185099_1647695195886936_3901401864525456360_n;
            this.EmailIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EmailIcon.Content = null;
            this.EmailIcon.ImageTint = System.Drawing.Color.White;
            this.EmailIcon.Location = new System.Drawing.Point(49, 12);
            this.EmailIcon.Name = "EmailIcon";
            this.EmailIcon.OutlineThickness = 1F;
            this.EmailIcon.PanelOutlineColor = System.Drawing.Color.Empty;
            this.EmailIcon.Rotation = 0;
            this.EmailIcon.Rounding = new System.Windows.Forms.Padding(8);
            this.EmailIcon.Size = new System.Drawing.Size(150, 210);
            this.EmailIcon.TabIndex = 0;
            this.EmailIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EmailIcon_MouseDown);
            // 
            // Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 403);
            this.Controls.Add(this.Gmail);
            this.Controls.Add(this.nightLabel1);
            this.Controls.Add(this.dungeonHeaderLabel1);
            this.Controls.Add(this.EmailIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Email";
            this.Text = "Email";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Email_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CuoreUI.Controls.cuiPictureBox EmailIcon;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel1;
        private ReaLTaiizor.Controls.NightLabel nightLabel1;
        private CuoreUI.Controls.cuiButton Gmail;
    }
}