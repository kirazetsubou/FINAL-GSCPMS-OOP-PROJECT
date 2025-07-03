using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL_GSCPMS_OOP_PROJECT.Forms.Accounts
{
    public partial class reg2 : UserControl
    {
        private Dictionary<string, List<string>> barangaysByDistrict;

        public reg2()
        {
            InitializeComponent();

        }

        private void reg2_Load(object sender, EventArgs e)
        {

            // Initialize barangay dictionary
            barangaysByDistrict = new Dictionary<string, List<string>>
            {
                { "South", Enumerable.Range(1, 160).Select(i => $"Barangay {i}").ToList() },
                { "North", Enumerable.Range(161, 28).Select(i => $"Barangay {i}").ToList() }
             };

            // Populate District ComboBox
            District.RemoveItem("");

            foreach (string district in new string[] { "South", "North" })
            {
                District.AddItem(district);
            }

            District.SelectedIndexChanged += District_SelectedIndexChanged;
        }

        private void District_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Defensive check: make sure something is actually selected
            if (District.SelectedItem == null)
                return;

            string selectedDistrict = District.SelectedItem.ToString();

            // Check if the district key exists in the dictionary
            if (barangaysByDistrict.ContainsKey(selectedDistrict))
            {
                cmbBrgy.RemoveItem("");
                foreach (string barangay in barangaysByDistrict[selectedDistrict])
                {
                    cmbBrgy.AddItem(barangay);
                }
            }
        }
    }
}
