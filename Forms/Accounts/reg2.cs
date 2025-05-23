using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL_GSCPMS_OOP_PROJECT.Forms.Accounts
{
    public partial class reg2 : UserControl
    {
        public reg2()
        {
            InitializeComponent();
        }

        private void reg2_Load(object sender, EventArgs e)
        {
            cmbProvinces.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbProvinces.AutoCompleteSource = AutoCompleteSource.ListItems;

            cmbProvinces.Items.AddRange(new string[] {
            "Metro Manila"
            });
            cmbBarangay.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbBarangay.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbBarangay.Items.AddRange(new string[] {
            "Brgy 179"
            });
        }
        private void smallLabel3_Click(object sender, EventArgs e)
        {

        }

        private void hopeTextBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
