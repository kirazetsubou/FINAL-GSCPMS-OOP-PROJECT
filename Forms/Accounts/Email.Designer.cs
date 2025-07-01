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
            this.dungeonHeaderLabel1 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.nightLabel1 = new ReaLTaiizor.Controls.NightLabel();
            this.Gmail = new CuoreUI.Controls.cuiButton();
            this.cuiPictureBox1 = new CuoreUI.Controls.cuiPictureBox();
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
            // cuiPictureBox1
            // 
            this.cuiPictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cuiPictureBox1.BackgroundImage = global::FINAL_GSCPMS_OOP_PROJECT.Properties.Resources._513185099_1647695195886936_3901401864525456360_n;
            this.cuiPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cuiPictureBox1.Content = null;
            this.cuiPictureBox1.ImageTint = System.Drawing.Color.White;
            this.cuiPictureBox1.Location = new System.Drawing.Point(49, 12);
            this.cuiPictureBox1.Name = "cuiPictureBox1";
            this.cuiPictureBox1.OutlineThickness = 1F;
            this.cuiPictureBox1.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox1.Rotation = 0;
            this.cuiPictureBox1.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox1.Size = new System.Drawing.Size(150, 210);
            this.cuiPictureBox1.TabIndex = 0;
            // 
            // Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 403);
            this.Controls.Add(this.Gmail);
            this.Controls.Add(this.nightLabel1);
            this.Controls.Add(this.dungeonHeaderLabel1);
            this.Controls.Add(this.cuiPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Email";
            this.Text = "Email";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CuoreUI.Controls.cuiPictureBox cuiPictureBox1;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel1;
        private ReaLTaiizor.Controls.NightLabel nightLabel1;
        private CuoreUI.Controls.cuiButton Gmail;
    }
}