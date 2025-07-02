namespace FINAL_GSCPMS_OOP_PROJECT.Forms.Accounts
{
    partial class Resetpass
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
            this.Password = new CuoreUI.Controls.cuiTextBox();
            this.Confirmpassword = new CuoreUI.Controls.cuiTextBox();
            this.dungeonHeaderLabel1 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.Reset = new CuoreUI.Controls.cuiButton();
            this.Cancel = new CuoreUI.Controls.cuiButton();
            this.Showpass = new ReaLTaiizor.Controls.HopeCheckBox();
            this.Iconstatus = new System.Windows.Forms.PictureBox();
            this.Matchstatus = new ReaLTaiizor.Controls.DungeonLabel();
            this.PassTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Iconstatus)).BeginInit();
            this.SuspendLayout();
            // 
            // Password
            // 
            this.Password.BackgroundColor = System.Drawing.Color.White;
            this.Password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Password.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.Password.Content = "";
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password.FocusBackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.Password.FocusBorderColor = System.Drawing.Color.Red;
            this.Password.FocusImageTint = System.Drawing.Color.DimGray;
            this.Password.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.Color.Black;
            this.Password.Image = null;
            this.Password.ImageExpand = new System.Drawing.Point(10, 10);
            this.Password.ImageOffset = new System.Drawing.Point(5, 5);
            this.Password.Location = new System.Drawing.Point(141, 119);
            this.Password.Margin = new System.Windows.Forms.Padding(4);
            this.Password.Multiline = false;
            this.Password.Name = "Password";
            this.Password.NormalImageTint = System.Drawing.Color.White;
            this.Password.Padding = new System.Windows.Forms.Padding(16, 14, 16, 0);
            this.Password.PasswordChar = true;
            this.Password.PlaceholderColor = System.Drawing.Color.Black;
            this.Password.PlaceholderText = "Password";
            this.Password.Rounding = new System.Windows.Forms.Padding(25);
            this.Password.Size = new System.Drawing.Size(336, 45);
            this.Password.TabIndex = 26;
            this.Password.TextOffset = new System.Drawing.Size(0, 0);
            this.Password.UnderlinedStyle = true;
            this.Password.ContentChanged += new System.EventHandler(this.Password_ContentChanged);
            // 
            // Confirmpassword
            // 
            this.Confirmpassword.BackgroundColor = System.Drawing.Color.White;
            this.Confirmpassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Confirmpassword.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.Confirmpassword.Content = "";
            this.Confirmpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Confirmpassword.FocusBackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.Confirmpassword.FocusBorderColor = System.Drawing.Color.Red;
            this.Confirmpassword.FocusImageTint = System.Drawing.Color.DimGray;
            this.Confirmpassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirmpassword.ForeColor = System.Drawing.Color.Black;
            this.Confirmpassword.Image = null;
            this.Confirmpassword.ImageExpand = new System.Drawing.Point(10, 10);
            this.Confirmpassword.ImageOffset = new System.Drawing.Point(5, 5);
            this.Confirmpassword.Location = new System.Drawing.Point(141, 186);
            this.Confirmpassword.Margin = new System.Windows.Forms.Padding(4);
            this.Confirmpassword.Multiline = false;
            this.Confirmpassword.Name = "Confirmpassword";
            this.Confirmpassword.NormalImageTint = System.Drawing.Color.White;
            this.Confirmpassword.Padding = new System.Windows.Forms.Padding(16, 14, 16, 0);
            this.Confirmpassword.PasswordChar = true;
            this.Confirmpassword.PlaceholderColor = System.Drawing.Color.Black;
            this.Confirmpassword.PlaceholderText = "Confirm password";
            this.Confirmpassword.Rounding = new System.Windows.Forms.Padding(25);
            this.Confirmpassword.Size = new System.Drawing.Size(336, 45);
            this.Confirmpassword.TabIndex = 27;
            this.Confirmpassword.TextOffset = new System.Drawing.Size(0, 0);
            this.Confirmpassword.UnderlinedStyle = true;
            this.Confirmpassword.ContentChanged += new System.EventHandler(this.Confirmpassword_ContentChanged);
            // 
            // dungeonHeaderLabel1
            // 
            this.dungeonHeaderLabel1.AutoSize = true;
            this.dungeonHeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.dungeonHeaderLabel1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.dungeonHeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonHeaderLabel1.Location = new System.Drawing.Point(137, 63);
            this.dungeonHeaderLabel1.Name = "dungeonHeaderLabel1";
            this.dungeonHeaderLabel1.Size = new System.Drawing.Size(155, 20);
            this.dungeonHeaderLabel1.TabIndex = 28;
            this.dungeonHeaderLabel1.Text = "Reset your password";
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.Transparent;
            this.Reset.CheckButton = false;
            this.Reset.Checked = false;
            this.Reset.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.Reset.CheckedForeColor = System.Drawing.Color.White;
            this.Reset.CheckedImageTint = System.Drawing.Color.White;
            this.Reset.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.Reset.Content = "Reset ";
            this.Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reset.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.ForeColor = System.Drawing.Color.Black;
            this.Reset.HoverBackground = System.Drawing.Color.White;
            this.Reset.HoveredImageTint = System.Drawing.Color.White;
            this.Reset.HoverForeColor = System.Drawing.Color.Black;
            this.Reset.HoverOutline = System.Drawing.Color.Aqua;
            this.Reset.Image = null;
            this.Reset.ImageAutoCenter = true;
            this.Reset.ImageExpand = new System.Drawing.Point(0, 0);
            this.Reset.ImageOffset = new System.Drawing.Point(0, 0);
            this.Reset.Location = new System.Drawing.Point(349, 333);
            this.Reset.Name = "Reset";
            this.Reset.NormalBackground = System.Drawing.Color.White;
            this.Reset.NormalForeColor = System.Drawing.Color.Black;
            this.Reset.NormalImageTint = System.Drawing.Color.White;
            this.Reset.NormalOutline = System.Drawing.Color.DeepSkyBlue;
            this.Reset.OutlineThickness = 1F;
            this.Reset.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.Reset.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Reset.PressedImageTint = System.Drawing.Color.White;
            this.Reset.PressedOutline = System.Drawing.Color.Red;
            this.Reset.Rounding = new System.Windows.Forms.Padding(25);
            this.Reset.Size = new System.Drawing.Size(186, 45);
            this.Reset.TabIndex = 29;
            this.Reset.TextAlignment = System.Drawing.StringAlignment.Center;
            this.Reset.TextOffset = new System.Drawing.Point(0, 0);
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.Transparent;
            this.Cancel.CheckButton = false;
            this.Cancel.Checked = false;
            this.Cancel.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.Cancel.CheckedForeColor = System.Drawing.Color.White;
            this.Cancel.CheckedImageTint = System.Drawing.Color.White;
            this.Cancel.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.Cancel.Content = "Cancel";
            this.Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.ForeColor = System.Drawing.Color.Black;
            this.Cancel.HoverBackground = System.Drawing.Color.White;
            this.Cancel.HoveredImageTint = System.Drawing.Color.White;
            this.Cancel.HoverForeColor = System.Drawing.Color.Black;
            this.Cancel.HoverOutline = System.Drawing.Color.Aqua;
            this.Cancel.Image = null;
            this.Cancel.ImageAutoCenter = true;
            this.Cancel.ImageExpand = new System.Drawing.Point(0, 0);
            this.Cancel.ImageOffset = new System.Drawing.Point(0, 0);
            this.Cancel.Location = new System.Drawing.Point(106, 333);
            this.Cancel.Name = "Cancel";
            this.Cancel.NormalBackground = System.Drawing.Color.White;
            this.Cancel.NormalForeColor = System.Drawing.Color.Black;
            this.Cancel.NormalImageTint = System.Drawing.Color.White;
            this.Cancel.NormalOutline = System.Drawing.Color.DeepSkyBlue;
            this.Cancel.OutlineThickness = 1F;
            this.Cancel.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.Cancel.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Cancel.PressedImageTint = System.Drawing.Color.White;
            this.Cancel.PressedOutline = System.Drawing.Color.Red;
            this.Cancel.Rounding = new System.Windows.Forms.Padding(25);
            this.Cancel.Size = new System.Drawing.Size(186, 45);
            this.Cancel.TabIndex = 30;
            this.Cancel.TextAlignment = System.Drawing.StringAlignment.Center;
            this.Cancel.TextOffset = new System.Drawing.Point(0, 0);
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Showpass
            // 
            this.Showpass.AutoSize = true;
            this.Showpass.BackColor = System.Drawing.Color.LightGray;
            this.Showpass.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.Showpass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Showpass.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.Showpass.DisabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.Showpass.Enable = true;
            this.Showpass.EnabledCheckedColor = System.Drawing.Color.DeepSkyBlue;
            this.Showpass.EnabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.Showpass.EnabledUncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(158)))), ((int)(((byte)(161)))));
            this.Showpass.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Showpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.Showpass.Location = new System.Drawing.Point(141, 292);
            this.Showpass.Name = "Showpass";
            this.Showpass.Size = new System.Drawing.Size(117, 20);
            this.Showpass.TabIndex = 31;
            this.Showpass.Text = "Show Password";
            this.Showpass.UseVisualStyleBackColor = false;
            this.Showpass.CheckedChanged += new System.EventHandler(this.Showpass_CheckedChanged);
            // 
            // Iconstatus
            // 
            this.Iconstatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Iconstatus.Location = new System.Drawing.Point(154, 244);
            this.Iconstatus.Name = "Iconstatus";
            this.Iconstatus.Size = new System.Drawing.Size(20, 20);
            this.Iconstatus.TabIndex = 33;
            this.Iconstatus.TabStop = false;
            // 
            // Matchstatus
            // 
            this.Matchstatus.AutoSize = true;
            this.Matchstatus.BackColor = System.Drawing.Color.Transparent;
            this.Matchstatus.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Matchstatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.Matchstatus.Location = new System.Drawing.Point(180, 244);
            this.Matchstatus.Name = "Matchstatus";
            this.Matchstatus.Size = new System.Drawing.Size(170, 16);
            this.Matchstatus.TabIndex = 33;
            this.Matchstatus.Text = "Both password must  match";
            // 
            // PassTimer
            // 
            this.PassTimer.Tick += new System.EventHandler(this.PassTimer_Tick);
            // 
            // Resetpass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 403);
            this.Controls.Add(this.Iconstatus);
            this.Controls.Add(this.Matchstatus);
            this.Controls.Add(this.Showpass);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.dungeonHeaderLabel1);
            this.Controls.Add(this.Confirmpassword);
            this.Controls.Add(this.Password);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Resetpass";
            this.Text = "Resetpass";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Resetpass_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.Iconstatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CuoreUI.Controls.cuiTextBox Password;
        private CuoreUI.Controls.cuiTextBox Confirmpassword;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel1;
        private CuoreUI.Controls.cuiButton Reset;
        private CuoreUI.Controls.cuiButton Cancel;
        private ReaLTaiizor.Controls.HopeCheckBox Showpass;
        private ReaLTaiizor.Controls.DungeonLabel Matchstatus;
        private System.Windows.Forms.PictureBox Iconstatus;
        private System.Windows.Forms.Timer PassTimer;
    }
}