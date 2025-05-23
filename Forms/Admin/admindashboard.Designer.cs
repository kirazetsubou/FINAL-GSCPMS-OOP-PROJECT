namespace FINAL_GSCPMS_OOP_PROJECT.Forms.Admin
{
    partial class admindashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.rPanel1 = new GSPMS.RPanel();
            this.rPanel2 = new GSPMS.RPanel();
            this.rPanel3 = new GSPMS.RPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rPanel3);
            this.panel1.Controls.Add(this.rPanel2);
            this.panel1.Controls.Add(this.rPanel1);
            this.panel1.Controls.Add(this.bigLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 581);
            this.panel1.TabIndex = 0;
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel1.Location = new System.Drawing.Point(354, 22);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(290, 46);
            this.bigLabel1.TabIndex = 1;
            this.bigLabel1.Text = "Admin Dashboard";
            // 
            // rPanel1
            // 
            this.rPanel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.rPanel1.BorderColor = System.Drawing.Color.White;
            this.rPanel1.Edge = 20;
            this.rPanel1.Location = new System.Drawing.Point(64, 95);
            this.rPanel1.Name = "rPanel1";
            this.rPanel1.Size = new System.Drawing.Size(137, 82);
            this.rPanel1.TabIndex = 2;
            // 
            // rPanel2
            // 
            this.rPanel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.rPanel2.BorderColor = System.Drawing.Color.White;
            this.rPanel2.Edge = 20;
            this.rPanel2.Location = new System.Drawing.Point(229, 95);
            this.rPanel2.Name = "rPanel2";
            this.rPanel2.Size = new System.Drawing.Size(137, 82);
            this.rPanel2.TabIndex = 3;
            // 
            // rPanel3
            // 
            this.rPanel3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.rPanel3.BorderColor = System.Drawing.Color.White;
            this.rPanel3.Edge = 20;
            this.rPanel3.Location = new System.Drawing.Point(406, 95);
            this.rPanel3.Name = "rPanel3";
            this.rPanel3.Size = new System.Drawing.Size(137, 82);
            this.rPanel3.TabIndex = 4;
            // 
            // admindashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "admindashboard";
            this.Size = new System.Drawing.Size(1000, 581);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private GSPMS.RPanel rPanel3;
        private GSPMS.RPanel rPanel2;
        private GSPMS.RPanel rPanel1;
    }
}
