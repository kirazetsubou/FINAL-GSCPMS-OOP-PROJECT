using System.Windows.Forms;

namespace FINAL_GSCPMS_OOP_PROJECT.Forms.Accounts
{
    partial class reg2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FoxBigLabel1 = new ReaLTaiizor.Controls.FoxBigLabel();
            this.smallLabel5 = new ReaLTaiizor.Controls.SmallLabel();
            this.smallLabel2 = new ReaLTaiizor.Controls.SmallLabel();
            this.smallLabel1 = new ReaLTaiizor.Controls.SmallLabel();
            this.smallLabel3 = new ReaLTaiizor.Controls.SmallLabel();
            this.smallLabel6 = new ReaLTaiizor.Controls.SmallLabel();
            this.Email = new CuoreUI.Controls.cuiTextBox();
            this.cuiTextBox1 = new CuoreUI.Controls.cuiTextBox();
            this.cmbProvinces = new CuoreUI.Controls.cuiComboBox();
            this.cmbCity = new CuoreUI.Controls.cuiComboBox();
            this.cmbBrgy = new CuoreUI.Controls.cuiComboBox();
            this.District = new CuoreUI.Controls.cuiComboBox();
            this.smallLabel4 = new ReaLTaiizor.Controls.SmallLabel();
            this.SuspendLayout();
            // 
            // FoxBigLabel1
            // 
            this.FoxBigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.FoxBigLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoxBigLabel1.ForeColor = System.Drawing.Color.Black;
            this.FoxBigLabel1.Line = ReaLTaiizor.Controls.FoxBigLabel.Direction.Bottom;
            this.FoxBigLabel1.LineColor = System.Drawing.Color.Black;
            this.FoxBigLabel1.Location = new System.Drawing.Point(184, 3);
            this.FoxBigLabel1.Name = "FoxBigLabel1";
            this.FoxBigLabel1.Size = new System.Drawing.Size(228, 41);
            this.FoxBigLabel1.TabIndex = 14;
            this.FoxBigLabel1.Text = "Address Details";
            // 
            // smallLabel5
            // 
            this.smallLabel5.AutoSize = true;
            this.smallLabel5.BackColor = System.Drawing.Color.Transparent;
            this.smallLabel5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smallLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.smallLabel5.Location = new System.Drawing.Point(26, 62);
            this.smallLabel5.Name = "smallLabel5";
            this.smallLabel5.Size = new System.Drawing.Size(86, 14);
            this.smallLabel5.TabIndex = 25;
            this.smallLabel5.Text = "State/Province";
            // 
            // smallLabel2
            // 
            this.smallLabel2.AutoSize = true;
            this.smallLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smallLabel2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smallLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.smallLabel2.Location = new System.Drawing.Point(26, 147);
            this.smallLabel2.Name = "smallLabel2";
            this.smallLabel2.Size = new System.Drawing.Size(28, 14);
            this.smallLabel2.TabIndex = 29;
            this.smallLabel2.Text = "City";
            // 
            // smallLabel1
            // 
            this.smallLabel1.AutoSize = true;
            this.smallLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smallLabel1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smallLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.smallLabel1.Location = new System.Drawing.Point(36, 312);
            this.smallLabel1.Name = "smallLabel1";
            this.smallLabel1.Size = new System.Drawing.Size(102, 14);
            this.smallLabel1.TabIndex = 31;
            this.smallLabel1.Text = "House no., Street";
            // 
            // smallLabel3
            // 
            this.smallLabel3.AutoSize = true;
            this.smallLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smallLabel3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smallLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.smallLabel3.Location = new System.Drawing.Point(301, 312);
            this.smallLabel3.Name = "smallLabel3";
            this.smallLabel3.Size = new System.Drawing.Size(73, 14);
            this.smallLabel3.TabIndex = 33;
            this.smallLabel3.Text = "Postal Code";
            // 
            // smallLabel6
            // 
            this.smallLabel6.AutoSize = true;
            this.smallLabel6.BackColor = System.Drawing.Color.Transparent;
            this.smallLabel6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smallLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.smallLabel6.Location = new System.Drawing.Point(301, 229);
            this.smallLabel6.Name = "smallLabel6";
            this.smallLabel6.Size = new System.Drawing.Size(57, 14);
            this.smallLabel6.TabIndex = 35;
            this.smallLabel6.Text = "Barangay";
            // 
            // Email
            // 
            this.Email.BackgroundColor = System.Drawing.Color.White;
            this.Email.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Email.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.Email.Content = "";
            this.Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Email.FocusBackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.Email.FocusBorderColor = System.Drawing.Color.Red;
            this.Email.FocusImageTint = System.Drawing.Color.DimGray;
            this.Email.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.ForeColor = System.Drawing.Color.Black;
            this.Email.Image = null;
            this.Email.ImageExpand = new System.Drawing.Point(10, 10);
            this.Email.ImageOffset = new System.Drawing.Point(5, 5);
            this.Email.Location = new System.Drawing.Point(26, 330);
            this.Email.Margin = new System.Windows.Forms.Padding(4);
            this.Email.Multiline = false;
            this.Email.Name = "Email";
            this.Email.NormalImageTint = System.Drawing.Color.White;
            this.Email.Padding = new System.Windows.Forms.Padding(16, 14, 16, 0);
            this.Email.PasswordChar = false;
            this.Email.PlaceholderColor = System.Drawing.Color.Black;
            this.Email.PlaceholderText = "";
            this.Email.Rounding = new System.Windows.Forms.Padding(25);
            this.Email.Size = new System.Drawing.Size(239, 45);
            this.Email.TabIndex = 37;
            this.Email.TextOffset = new System.Drawing.Size(0, 0);
            this.Email.UnderlinedStyle = true;
            // 
            // cuiTextBox1
            // 
            this.cuiTextBox1.BackgroundColor = System.Drawing.Color.White;
            this.cuiTextBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cuiTextBox1.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.cuiTextBox1.Content = "";
            this.cuiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cuiTextBox1.FocusBackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.cuiTextBox1.FocusBorderColor = System.Drawing.Color.Red;
            this.cuiTextBox1.FocusImageTint = System.Drawing.Color.DimGray;
            this.cuiTextBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiTextBox1.ForeColor = System.Drawing.Color.Black;
            this.cuiTextBox1.Image = null;
            this.cuiTextBox1.ImageExpand = new System.Drawing.Point(10, 10);
            this.cuiTextBox1.ImageOffset = new System.Drawing.Point(5, 5);
            this.cuiTextBox1.Location = new System.Drawing.Point(290, 330);
            this.cuiTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.cuiTextBox1.Multiline = false;
            this.cuiTextBox1.Name = "cuiTextBox1";
            this.cuiTextBox1.NormalImageTint = System.Drawing.Color.White;
            this.cuiTextBox1.Padding = new System.Windows.Forms.Padding(16, 14, 16, 0);
            this.cuiTextBox1.PasswordChar = false;
            this.cuiTextBox1.PlaceholderColor = System.Drawing.Color.Black;
            this.cuiTextBox1.PlaceholderText = "";
            this.cuiTextBox1.Rounding = new System.Windows.Forms.Padding(25);
            this.cuiTextBox1.Size = new System.Drawing.Size(159, 45);
            this.cuiTextBox1.TabIndex = 38;
            this.cuiTextBox1.TextOffset = new System.Drawing.Size(0, 0);
            this.cuiTextBox1.UnderlinedStyle = true;
            // 
            // cmbProvinces
            // 
            this.cmbProvinces.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbProvinces.ButtonCursor = System.Windows.Forms.Cursors.Arrow;
            this.cmbProvinces.ButtonHoverBackground = System.Drawing.Color.LightBlue;
            this.cmbProvinces.ButtonHoverOutline = System.Drawing.Color.Empty;
            this.cmbProvinces.ButtonNormalBackground = System.Drawing.Color.LightSkyBlue;
            this.cmbProvinces.ButtonNormalOutline = System.Drawing.Color.Empty;
            this.cmbProvinces.ButtonPressedBackground = System.Drawing.Color.LightSkyBlue;
            this.cmbProvinces.ButtonPressedOutline = System.Drawing.Color.Empty;
            this.cmbProvinces.DropDownBackgroundColor = System.Drawing.Color.White;
            this.cmbProvinces.DropDownOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbProvinces.ExpandArrowColor = System.Drawing.Color.DeepSkyBlue;
            this.cmbProvinces.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProvinces.ForeColor = System.Drawing.Color.Gray;
            this.cmbProvinces.Items = new string[] {
        "Metro Manila"};
            this.cmbProvinces.Location = new System.Drawing.Point(26, 81);
            this.cmbProvinces.Name = "cmbProvinces";
            this.cmbProvinces.NoSelectionDropdownText = "Empty";
            this.cmbProvinces.NoSelectionText = "Select Province";
            this.cmbProvinces.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cmbProvinces.OutlineThickness = 1F;
            this.cmbProvinces.Rounding = 25;
            this.cmbProvinces.Size = new System.Drawing.Size(556, 46);
            this.cmbProvinces.TabIndex = 39;
            // 
            // cmbCity
            // 
            this.cmbCity.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbCity.ButtonCursor = System.Windows.Forms.Cursors.Arrow;
            this.cmbCity.ButtonHoverBackground = System.Drawing.Color.LightBlue;
            this.cmbCity.ButtonHoverOutline = System.Drawing.Color.Empty;
            this.cmbCity.ButtonNormalBackground = System.Drawing.Color.LightSkyBlue;
            this.cmbCity.ButtonNormalOutline = System.Drawing.Color.Empty;
            this.cmbCity.ButtonPressedBackground = System.Drawing.Color.LightSkyBlue;
            this.cmbCity.ButtonPressedOutline = System.Drawing.Color.Empty;
            this.cmbCity.DropDownBackgroundColor = System.Drawing.Color.White;
            this.cmbCity.DropDownOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbCity.ExpandArrowColor = System.Drawing.Color.DeepSkyBlue;
            this.cmbCity.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCity.ForeColor = System.Drawing.Color.Gray;
            this.cmbCity.Items = new string[] {
        "Caloocan City"};
            this.cmbCity.Location = new System.Drawing.Point(29, 164);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.NoSelectionDropdownText = "Empty";
            this.cmbCity.NoSelectionText = "Select City";
            this.cmbCity.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cmbCity.OutlineThickness = 1F;
            this.cmbCity.Rounding = 25;
            this.cmbCity.Size = new System.Drawing.Size(553, 45);
            this.cmbCity.TabIndex = 40;
            // 
            // cmbBrgy
            // 
            this.cmbBrgy.AllowDrop = true;
            this.cmbBrgy.AutoScroll = true;
            this.cmbBrgy.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbBrgy.ButtonCursor = System.Windows.Forms.Cursors.Arrow;
            this.cmbBrgy.ButtonHoverBackground = System.Drawing.Color.LightBlue;
            this.cmbBrgy.ButtonHoverOutline = System.Drawing.Color.Empty;
            this.cmbBrgy.ButtonNormalBackground = System.Drawing.Color.LightSkyBlue;
            this.cmbBrgy.ButtonNormalOutline = System.Drawing.Color.Empty;
            this.cmbBrgy.ButtonPressedBackground = System.Drawing.Color.LightSkyBlue;
            this.cmbBrgy.ButtonPressedOutline = System.Drawing.Color.Empty;
            this.cmbBrgy.DropDownBackgroundColor = System.Drawing.Color.White;
            this.cmbBrgy.DropDownOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbBrgy.ExpandArrowColor = System.Drawing.Color.DeepSkyBlue;
            this.cmbBrgy.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBrgy.ForeColor = System.Drawing.Color.Gray;
            this.cmbBrgy.Items = new string[] {
        ""};
            this.cmbBrgy.Location = new System.Drawing.Point(290, 246);
            this.cmbBrgy.Name = "cmbBrgy";
            this.cmbBrgy.NoSelectionDropdownText = "Empty";
            this.cmbBrgy.NoSelectionText = "Select Barangay";
            this.cmbBrgy.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cmbBrgy.OutlineThickness = 1F;
            this.cmbBrgy.Rounding = 25;
            this.cmbBrgy.Size = new System.Drawing.Size(222, 45);
            this.cmbBrgy.TabIndex = 41;
            // 
            // District
            // 
            this.District.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.District.ButtonCursor = System.Windows.Forms.Cursors.Arrow;
            this.District.ButtonHoverBackground = System.Drawing.Color.LightBlue;
            this.District.ButtonHoverOutline = System.Drawing.Color.Empty;
            this.District.ButtonNormalBackground = System.Drawing.Color.LightSkyBlue;
            this.District.ButtonNormalOutline = System.Drawing.Color.Empty;
            this.District.ButtonPressedBackground = System.Drawing.Color.LightSkyBlue;
            this.District.ButtonPressedOutline = System.Drawing.Color.Empty;
            this.District.DropDownBackgroundColor = System.Drawing.Color.White;
            this.District.DropDownOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.District.ExpandArrowColor = System.Drawing.Color.DeepSkyBlue;
            this.District.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.District.ForeColor = System.Drawing.Color.Gray;
            this.District.Items = new string[0];
            this.District.Location = new System.Drawing.Point(26, 246);
            this.District.Name = "District";
            this.District.NoSelectionDropdownText = "Empty";
            this.District.NoSelectionText = "Select District";
            this.District.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.District.OutlineThickness = 1F;
            this.District.Rounding = 25;
            this.District.Size = new System.Drawing.Size(207, 45);
            this.District.TabIndex = 42;
            this.District.SelectedIndexChanged += new System.EventHandler(this.District_SelectedIndexChanged);
            // 
            // smallLabel4
            // 
            this.smallLabel4.AutoSize = true;
            this.smallLabel4.BackColor = System.Drawing.Color.Transparent;
            this.smallLabel4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smallLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.smallLabel4.Location = new System.Drawing.Point(26, 229);
            this.smallLabel4.Name = "smallLabel4";
            this.smallLabel4.Size = new System.Drawing.Size(46, 14);
            this.smallLabel4.TabIndex = 43;
            this.smallLabel4.Text = "District";
            // 
            // reg2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.smallLabel4);
            this.Controls.Add(this.District);
            this.Controls.Add(this.cmbBrgy);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.cmbProvinces);
            this.Controls.Add(this.cuiTextBox1);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.smallLabel6);
            this.Controls.Add(this.smallLabel3);
            this.Controls.Add(this.smallLabel1);
            this.Controls.Add(this.smallLabel2);
            this.Controls.Add(this.smallLabel5);
            this.Controls.Add(this.FoxBigLabel1);
            this.Name = "reg2";
            this.Size = new System.Drawing.Size(619, 472);
            this.Load += new System.EventHandler(this.reg2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal ReaLTaiizor.Controls.FoxBigLabel FoxBigLabel1;
        private ReaLTaiizor.Controls.SmallLabel smallLabel5;
        private ReaLTaiizor.Controls.SmallLabel smallLabel2;
        private ReaLTaiizor.Controls.SmallLabel smallLabel1;
        private ReaLTaiizor.Controls.SmallLabel smallLabel3;
        private ReaLTaiizor.Controls.SmallLabel smallLabel6;
        private CuoreUI.Controls.cuiTextBox Email;
        private CuoreUI.Controls.cuiTextBox cuiTextBox1;
        private CuoreUI.Controls.cuiComboBox cmbProvinces;
        private CuoreUI.Controls.cuiComboBox cmbCity;
        private CuoreUI.Controls.cuiComboBox cmbBrgy;
        private CuoreUI.Controls.cuiComboBox District;
        private ReaLTaiizor.Controls.SmallLabel smallLabel4;
    }
}
