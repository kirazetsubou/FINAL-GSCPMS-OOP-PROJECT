namespace FINAL_GSCPMS_OOP_PROJECT.Forms.Accounts
{
    partial class reg1
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
            this.smallLabel4 = new ReaLTaiizor.Controls.SmallLabel();
            this.smallLabel6 = new ReaLTaiizor.Controls.SmallLabel();
            this.BDate = new ReaLTaiizor.Controls.PoisonDateTime();
            this.Gender = new ReaLTaiizor.Controls.HopeComboBox();
            this.smallLabel5 = new ReaLTaiizor.Controls.SmallLabel();
            this.Suffix = new ReaLTaiizor.Controls.HopeComboBox();
            this.Fname = new ReaLTaiizor.Controls.HopeTextBox();
            this.smallLabel1 = new ReaLTaiizor.Controls.SmallLabel();
            this.smallLabel2 = new ReaLTaiizor.Controls.SmallLabel();
            this.Lname = new ReaLTaiizor.Controls.HopeTextBox();
            this.MI = new ReaLTaiizor.Controls.HopeTextBox();
            this.smallLabel3 = new ReaLTaiizor.Controls.SmallLabel();
            this.SuspendLayout();
            // 
            // FoxBigLabel1
            // 
            this.FoxBigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.FoxBigLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F);
            this.FoxBigLabel1.ForeColor = System.Drawing.Color.Black;
            this.FoxBigLabel1.Line = ReaLTaiizor.Controls.FoxBigLabel.Direction.Bottom;
            this.FoxBigLabel1.LineColor = System.Drawing.Color.Black;
            this.FoxBigLabel1.Location = new System.Drawing.Point(203, 4);
            this.FoxBigLabel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FoxBigLabel1.Name = "FoxBigLabel1";
            this.FoxBigLabel1.Size = new System.Drawing.Size(344, 50);
            this.FoxBigLabel1.TabIndex = 13;
            this.FoxBigLabel1.Text = "Create Your Account";
            // 
            // smallLabel4
            // 
            this.smallLabel4.AutoSize = true;
            this.smallLabel4.BackColor = System.Drawing.Color.Transparent;
            this.smallLabel4.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.smallLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.smallLabel4.Location = new System.Drawing.Point(480, 244);
            this.smallLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.smallLabel4.Name = "smallLabel4";
            this.smallLabel4.Size = new System.Drawing.Size(41, 19);
            this.smallLabel4.TabIndex = 21;
            this.smallLabel4.Text = "Suffix";
            // 
            // smallLabel6
            // 
            this.smallLabel6.AutoSize = true;
            this.smallLabel6.BackColor = System.Drawing.Color.Transparent;
            this.smallLabel6.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.smallLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.smallLabel6.Location = new System.Drawing.Point(481, 353);
            this.smallLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.smallLabel6.Name = "smallLabel6";
            this.smallLabel6.Size = new System.Drawing.Size(65, 19);
            this.smallLabel6.TabIndex = 25;
            this.smallLabel6.Text = "Birthdate";
            // 
            // BDate
            // 
            this.BDate.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium;
            this.BDate.Location = new System.Drawing.Point(484, 377);
            this.BDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.BDate.Name = "BDate";
            this.BDate.Size = new System.Drawing.Size(265, 30);
            this.BDate.TabIndex = 26;
            // 
            // Gender
            // 
            this.Gender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Gender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Gender.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Gender.FormattingEnabled = true;
            this.Gender.ItemHeight = 30;
            this.Gender.Items.AddRange(new object[] {
            "Male ",
            "Female"});
            this.Gender.Location = new System.Drawing.Point(37, 368);
            this.Gender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(372, 36);
            this.Gender.TabIndex = 22;
            this.Gender.Text = "Select Gender";
            // 
            // smallLabel5
            // 
            this.smallLabel5.AutoSize = true;
            this.smallLabel5.BackColor = System.Drawing.Color.Transparent;
            this.smallLabel5.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.smallLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.smallLabel5.Location = new System.Drawing.Point(35, 348);
            this.smallLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.smallLabel5.Name = "smallLabel5";
            this.smallLabel5.Size = new System.Drawing.Size(54, 19);
            this.smallLabel5.TabIndex = 23;
            this.smallLabel5.Text = "Gender";
            // 
            // Suffix
            // 
            this.Suffix.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Suffix.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Suffix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Suffix.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Suffix.FormattingEnabled = true;
            this.Suffix.ItemHeight = 30;
            this.Suffix.Items.AddRange(new object[] {
            "Select Suffix",
            "Sr.",
            "Jr.",
            "II.",
            "III."});
            this.Suffix.Location = new System.Drawing.Point(484, 265);
            this.Suffix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Suffix.Name = "Suffix";
            this.Suffix.Size = new System.Drawing.Size(283, 36);
            this.Suffix.TabIndex = 20;
            this.Suffix.Text = "Select Suffix";
            // 
            // Fname
            // 
            this.Fname.BackColor = System.Drawing.Color.White;
            this.Fname.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.Fname.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.Fname.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.Fname.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Fname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.Fname.Hint = "";
            this.Fname.Location = new System.Drawing.Point(35, 100);
            this.Fname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Fname.MaxLength = 32767;
            this.Fname.Multiline = false;
            this.Fname.Name = "Fname";
            this.Fname.PasswordChar = '\0';
            this.Fname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Fname.SelectedText = "";
            this.Fname.SelectionLength = 0;
            this.Fname.SelectionStart = 0;
            this.Fname.Size = new System.Drawing.Size(733, 43);
            this.Fname.TabIndex = 14;
            this.Fname.TabStop = false;
            this.Fname.UseSystemPasswordChar = false;
            // 
            // smallLabel1
            // 
            this.smallLabel1.AutoSize = true;
            this.smallLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smallLabel1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.smallLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.smallLabel1.Location = new System.Drawing.Point(35, 76);
            this.smallLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.smallLabel1.Name = "smallLabel1";
            this.smallLabel1.Size = new System.Drawing.Size(75, 19);
            this.smallLabel1.TabIndex = 15;
            this.smallLabel1.Text = "First Name";
            // 
            // smallLabel2
            // 
            this.smallLabel2.AutoSize = true;
            this.smallLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smallLabel2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.smallLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.smallLabel2.Location = new System.Drawing.Point(35, 160);
            this.smallLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.smallLabel2.Name = "smallLabel2";
            this.smallLabel2.Size = new System.Drawing.Size(74, 19);
            this.smallLabel2.TabIndex = 16;
            this.smallLabel2.Text = "Last Name";
            // 
            // Lname
            // 
            this.Lname.BackColor = System.Drawing.Color.White;
            this.Lname.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.Lname.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.Lname.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.Lname.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Lname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.Lname.Hint = "";
            this.Lname.Location = new System.Drawing.Point(35, 183);
            this.Lname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Lname.MaxLength = 32767;
            this.Lname.Multiline = false;
            this.Lname.Name = "Lname";
            this.Lname.PasswordChar = '\0';
            this.Lname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Lname.SelectedText = "";
            this.Lname.SelectionLength = 0;
            this.Lname.SelectionStart = 0;
            this.Lname.Size = new System.Drawing.Size(733, 43);
            this.Lname.TabIndex = 17;
            this.Lname.TabStop = false;
            this.Lname.UseSystemPasswordChar = false;
            // 
            // MI
            // 
            this.MI.BackColor = System.Drawing.Color.White;
            this.MI.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.MI.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.MI.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.MI.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.MI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.MI.Hint = "";
            this.MI.Location = new System.Drawing.Point(35, 265);
            this.MI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MI.MaxLength = 32767;
            this.MI.Multiline = false;
            this.MI.Name = "MI";
            this.MI.PasswordChar = '\0';
            this.MI.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MI.SelectedText = "";
            this.MI.SelectionLength = 0;
            this.MI.SelectionStart = 0;
            this.MI.Size = new System.Drawing.Size(376, 43);
            this.MI.TabIndex = 18;
            this.MI.TabStop = false;
            this.MI.UseSystemPasswordChar = false;
            // 
            // smallLabel3
            // 
            this.smallLabel3.AutoSize = true;
            this.smallLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smallLabel3.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.smallLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.smallLabel3.Location = new System.Drawing.Point(35, 241);
            this.smallLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.smallLabel3.Name = "smallLabel3";
            this.smallLabel3.Size = new System.Drawing.Size(88, 19);
            this.smallLabel3.TabIndex = 19;
            this.smallLabel3.Text = "Middle Initial";
            // 
            // reg1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.BDate);
            this.Controls.Add(this.smallLabel6);
            this.Controls.Add(this.smallLabel5);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.smallLabel4);
            this.Controls.Add(this.Suffix);
            this.Controls.Add(this.smallLabel3);
            this.Controls.Add(this.MI);
            this.Controls.Add(this.Lname);
            this.Controls.Add(this.smallLabel2);
            this.Controls.Add(this.smallLabel1);
            this.Controls.Add(this.Fname);
            this.Controls.Add(this.FoxBigLabel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "reg1";
            this.Size = new System.Drawing.Size(803, 458);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal ReaLTaiizor.Controls.FoxBigLabel FoxBigLabel1;
        private ReaLTaiizor.Controls.SmallLabel smallLabel4;
        private ReaLTaiizor.Controls.SmallLabel smallLabel6;
        private ReaLTaiizor.Controls.PoisonDateTime BDate;
        private ReaLTaiizor.Controls.HopeComboBox Gender;
        private ReaLTaiizor.Controls.SmallLabel smallLabel5;
        private ReaLTaiizor.Controls.HopeComboBox Suffix;
        private ReaLTaiizor.Controls.HopeTextBox Fname;
        private ReaLTaiizor.Controls.SmallLabel smallLabel1;
        private ReaLTaiizor.Controls.SmallLabel smallLabel2;
        private ReaLTaiizor.Controls.HopeTextBox Lname;
        private ReaLTaiizor.Controls.HopeTextBox MI;
        private ReaLTaiizor.Controls.SmallLabel smallLabel3;
    }
}
