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
            this.cmbProvinces = new ReaLTaiizor.Controls.HopeComboBox();
            this.smallLabel2 = new ReaLTaiizor.Controls.SmallLabel();
            this.hopeComboBox1 = new ReaLTaiizor.Controls.HopeComboBox();
            this.smallLabel1 = new ReaLTaiizor.Controls.SmallLabel();
            this.hopeTextBox1 = new ReaLTaiizor.Controls.HopeTextBox();
            this.smallLabel3 = new ReaLTaiizor.Controls.SmallLabel();
            this.hopeTextBox2 = new ReaLTaiizor.Controls.HopeTextBox();
            this.smallLabel6 = new ReaLTaiizor.Controls.SmallLabel();
            this.cmbBarangay = new ReaLTaiizor.Controls.HopeComboBox();
            this.SuspendLayout();
            // 
            // FoxBigLabel1
            // 
            this.FoxBigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.FoxBigLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F);
            this.FoxBigLabel1.ForeColor = System.Drawing.Color.Black;
            this.FoxBigLabel1.Line = ReaLTaiizor.Controls.FoxBigLabel.Direction.Bottom;
            this.FoxBigLabel1.LineColor = System.Drawing.Color.Black;
            this.FoxBigLabel1.Location = new System.Drawing.Point(191, 3);
            this.FoxBigLabel1.Name = "FoxBigLabel1";
            this.FoxBigLabel1.Size = new System.Drawing.Size(202, 41);
            this.FoxBigLabel1.TabIndex = 14;
            this.FoxBigLabel1.Text = "Address Details";
            // 
            // smallLabel5
            // 
            this.smallLabel5.AutoSize = true;
            this.smallLabel5.BackColor = System.Drawing.Color.Transparent;
            this.smallLabel5.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.smallLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.smallLabel5.Location = new System.Drawing.Point(26, 62);
            this.smallLabel5.Name = "smallLabel5";
            this.smallLabel5.Size = new System.Drawing.Size(80, 13);
            this.smallLabel5.TabIndex = 25;
            this.smallLabel5.Text = "State/Province";
            // 
            // cmbProvinces
            // 
            this.cmbProvinces.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbProvinces.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbProvinces.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProvinces.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbProvinces.FormattingEnabled = true;
            this.cmbProvinces.ItemHeight = 30;
            this.cmbProvinces.Location = new System.Drawing.Point(26, 81);
            this.cmbProvinces.Name = "cmbProvinces";
            this.cmbProvinces.Size = new System.Drawing.Size(556, 36);
            this.cmbProvinces.TabIndex = 24;
            this.cmbProvinces.Text = "Select State/Province";
            // 
            // smallLabel2
            // 
            this.smallLabel2.AutoSize = true;
            this.smallLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smallLabel2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.smallLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.smallLabel2.Location = new System.Drawing.Point(23, 130);
            this.smallLabel2.Name = "smallLabel2";
            this.smallLabel2.Size = new System.Drawing.Size(26, 13);
            this.smallLabel2.TabIndex = 29;
            this.smallLabel2.Text = "City";
            // 
            // hopeComboBox1
            // 
            this.hopeComboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hopeComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.hopeComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hopeComboBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeComboBox1.FormattingEnabled = true;
            this.hopeComboBox1.ItemHeight = 30;
            this.hopeComboBox1.Items.AddRange(new object[] {
            "Caloocan City"});
            this.hopeComboBox1.Location = new System.Drawing.Point(26, 149);
            this.hopeComboBox1.Name = "hopeComboBox1";
            this.hopeComboBox1.Size = new System.Drawing.Size(556, 36);
            this.hopeComboBox1.TabIndex = 28;
            this.hopeComboBox1.Text = "Select City";
            // 
            // smallLabel1
            // 
            this.smallLabel1.AutoSize = true;
            this.smallLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smallLabel1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.smallLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.smallLabel1.Location = new System.Drawing.Point(23, 290);
            this.smallLabel1.Name = "smallLabel1";
            this.smallLabel1.Size = new System.Drawing.Size(96, 13);
            this.smallLabel1.TabIndex = 31;
            this.smallLabel1.Text = "House no., Street";
            // 
            // hopeTextBox1
            // 
            this.hopeTextBox1.BackColor = System.Drawing.Color.White;
            this.hopeTextBox1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.hopeTextBox1.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeTextBox1.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeTextBox1.Hint = "";
            this.hopeTextBox1.Location = new System.Drawing.Point(23, 309);
            this.hopeTextBox1.MaxLength = 32767;
            this.hopeTextBox1.Multiline = false;
            this.hopeTextBox1.Name = "hopeTextBox1";
            this.hopeTextBox1.PasswordChar = '\0';
            this.hopeTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hopeTextBox1.SelectedText = "";
            this.hopeTextBox1.SelectionLength = 0;
            this.hopeTextBox1.SelectionStart = 0;
            this.hopeTextBox1.Size = new System.Drawing.Size(282, 38);
            this.hopeTextBox1.TabIndex = 30;
            this.hopeTextBox1.TabStop = false;
            this.hopeTextBox1.UseSystemPasswordChar = false;
            // 
            // smallLabel3
            // 
            this.smallLabel3.AutoSize = true;
            this.smallLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smallLabel3.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.smallLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.smallLabel3.Location = new System.Drawing.Point(325, 290);
            this.smallLabel3.Name = "smallLabel3";
            this.smallLabel3.Size = new System.Drawing.Size(68, 13);
            this.smallLabel3.TabIndex = 33;
            this.smallLabel3.Text = "Postal Code";
            this.smallLabel3.Click += new System.EventHandler(this.smallLabel3_Click);
            // 
            // hopeTextBox2
            // 
            this.hopeTextBox2.BackColor = System.Drawing.Color.White;
            this.hopeTextBox2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.hopeTextBox2.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeTextBox2.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeTextBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeTextBox2.Hint = "";
            this.hopeTextBox2.Location = new System.Drawing.Point(325, 309);
            this.hopeTextBox2.MaxLength = 32767;
            this.hopeTextBox2.Multiline = false;
            this.hopeTextBox2.Name = "hopeTextBox2";
            this.hopeTextBox2.PasswordChar = '\0';
            this.hopeTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hopeTextBox2.SelectedText = "";
            this.hopeTextBox2.SelectionLength = 0;
            this.hopeTextBox2.SelectionStart = 0;
            this.hopeTextBox2.Size = new System.Drawing.Size(257, 38);
            this.hopeTextBox2.TabIndex = 32;
            this.hopeTextBox2.TabStop = false;
            this.hopeTextBox2.UseSystemPasswordChar = false;
            this.hopeTextBox2.Click += new System.EventHandler(this.hopeTextBox2_Click);
            // 
            // smallLabel6
            // 
            this.smallLabel6.AutoSize = true;
            this.smallLabel6.BackColor = System.Drawing.Color.Transparent;
            this.smallLabel6.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.smallLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.smallLabel6.Location = new System.Drawing.Point(26, 212);
            this.smallLabel6.Name = "smallLabel6";
            this.smallLabel6.Size = new System.Drawing.Size(29, 13);
            this.smallLabel6.TabIndex = 35;
            this.smallLabel6.Text = "Brgy";
            // 
            // cmbBarangay
            // 
            this.cmbBarangay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbBarangay.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBarangay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBarangay.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbBarangay.FormattingEnabled = true;
            this.cmbBarangay.ItemHeight = 30;
            this.cmbBarangay.Items.AddRange(new object[] {
            ""});
            this.cmbBarangay.Location = new System.Drawing.Point(26, 231);
            this.cmbBarangay.Name = "cmbBarangay";
            this.cmbBarangay.Size = new System.Drawing.Size(556, 36);
            this.cmbBarangay.TabIndex = 34;
            this.cmbBarangay.Text = "Select Brgy";
            // 
            // reg2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.smallLabel6);
            this.Controls.Add(this.cmbBarangay);
            this.Controls.Add(this.smallLabel3);
            this.Controls.Add(this.hopeTextBox2);
            this.Controls.Add(this.smallLabel1);
            this.Controls.Add(this.hopeTextBox1);
            this.Controls.Add(this.smallLabel2);
            this.Controls.Add(this.hopeComboBox1);
            this.Controls.Add(this.smallLabel5);
            this.Controls.Add(this.cmbProvinces);
            this.Controls.Add(this.FoxBigLabel1);
            this.Name = "reg2";
            this.Size = new System.Drawing.Size(602, 372);
            this.Load += new System.EventHandler(this.reg2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal ReaLTaiizor.Controls.FoxBigLabel FoxBigLabel1;
        private ReaLTaiizor.Controls.SmallLabel smallLabel5;
        private ReaLTaiizor.Controls.HopeComboBox cmbProvinces;
        private ReaLTaiizor.Controls.SmallLabel smallLabel2;
        private ReaLTaiizor.Controls.HopeComboBox hopeComboBox1;
        private ReaLTaiizor.Controls.SmallLabel smallLabel1;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBox1;
        private ReaLTaiizor.Controls.SmallLabel smallLabel3;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBox2;
        private ReaLTaiizor.Controls.SmallLabel smallLabel6;
        private ReaLTaiizor.Controls.HopeComboBox cmbBarangay;
    }
}
