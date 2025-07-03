namespace FINAL_GSCPMS_OOP_PROJECT.Forms.Accounts
{
    partial class Privacy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Privacy));
            this.Slider = new CuoreUI.Controls.cuiSliderVertical();
            this.Agree = new ReaLTaiizor.Controls.HopeCheckBox();
            this.btnContinue = new CuoreUI.Controls.cuiButton();
            this.Privacypolicy = new System.Windows.Forms.RichTextBox();
            this.Scroll = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Slider
            // 
            this.Slider.Location = new System.Drawing.Point(434, 196);
            this.Slider.MaxValue = 100F;
            this.Slider.MinValue = 0F;
            this.Slider.Name = "Slider";
            this.Slider.Size = new System.Drawing.Size(24, 412);
            this.Slider.TabIndex = 1;
            this.Slider.ThumbColor = System.Drawing.Color.DeepSkyBlue;
            this.Slider.ThumbOutlineThickness = 3;
            this.Slider.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Slider.UpsideDown = false;
            this.Slider.Value = 100F;
            this.Slider.ValueChanged += new System.EventHandler(this.Slider_ValueChanged);
            // 
            // Agree
            // 
            this.Agree.AutoSize = true;
            this.Agree.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.Agree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Agree.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.Agree.DisabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.Agree.Enable = true;
            this.Agree.EnabledCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.Agree.EnabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.Agree.EnabledUncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(158)))), ((int)(((byte)(161)))));
            this.Agree.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Agree.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.Agree.Location = new System.Drawing.Point(44, 615);
            this.Agree.Name = "Agree";
            this.Agree.Size = new System.Drawing.Size(208, 20);
            this.Agree.TabIndex = 2;
            this.Agree.Text = "Agree with Privacy Policy";
            this.Agree.UseVisualStyleBackColor = true;
            this.Agree.CheckedChanged += new System.EventHandler(this.Agree_CheckedChanged);
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.Transparent;
            this.btnContinue.CheckButton = false;
            this.btnContinue.Checked = false;
            this.btnContinue.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnContinue.CheckedForeColor = System.Drawing.Color.White;
            this.btnContinue.CheckedImageTint = System.Drawing.Color.White;
            this.btnContinue.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnContinue.Content = "Continue";
            this.btnContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinue.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.ForeColor = System.Drawing.Color.Black;
            this.btnContinue.HoverBackground = System.Drawing.Color.White;
            this.btnContinue.HoveredImageTint = System.Drawing.Color.White;
            this.btnContinue.HoverForeColor = System.Drawing.Color.Black;
            this.btnContinue.HoverOutline = System.Drawing.Color.Aqua;
            this.btnContinue.Image = null;
            this.btnContinue.ImageAutoCenter = true;
            this.btnContinue.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnContinue.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnContinue.Location = new System.Drawing.Point(154, 662);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.NormalBackground = System.Drawing.Color.White;
            this.btnContinue.NormalForeColor = System.Drawing.Color.Black;
            this.btnContinue.NormalImageTint = System.Drawing.Color.White;
            this.btnContinue.NormalOutline = System.Drawing.Color.DeepSkyBlue;
            this.btnContinue.OutlineThickness = 1F;
            this.btnContinue.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.btnContinue.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnContinue.PressedImageTint = System.Drawing.Color.White;
            this.btnContinue.PressedOutline = System.Drawing.Color.Red;
            this.btnContinue.Rounding = new System.Windows.Forms.Padding(25);
            this.btnContinue.Size = new System.Drawing.Size(186, 45);
            this.btnContinue.TabIndex = 15;
            this.btnContinue.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnContinue.TextOffset = new System.Drawing.Point(0, 0);
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // Privacypolicy
            // 
            this.Privacypolicy.Location = new System.Drawing.Point(44, 196);
            this.Privacypolicy.Name = "Privacypolicy";
            this.Privacypolicy.ReadOnly = true;
            this.Privacypolicy.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.Privacypolicy.Size = new System.Drawing.Size(384, 412);
            this.Privacypolicy.TabIndex = 16;
            this.Privacypolicy.Text = "";
            // 
            // Scroll
            // 
            this.Scroll.Tick += new System.EventHandler(this.Scroll_Tick);
            // 
            // Privacy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 741);
            this.Controls.Add(this.Privacypolicy);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.Agree);
            this.Controls.Add(this.Slider);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Privacy";
            this.Text = "Privacy";
            this.Load += new System.EventHandler(this.Privacy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CuoreUI.Controls.cuiSliderVertical Slider;
        private ReaLTaiizor.Controls.HopeCheckBox Agree;
        private CuoreUI.Controls.cuiButton btnContinue;
        private System.Windows.Forms.RichTextBox Privacypolicy;
        private System.Windows.Forms.Timer Scroll;
    }
}