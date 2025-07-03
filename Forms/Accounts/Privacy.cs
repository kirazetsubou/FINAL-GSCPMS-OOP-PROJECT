using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace FINAL_GSCPMS_OOP_PROJECT.Forms.Accounts
{
    public partial class Privacy : Form
    {
        [DllImport("user32.dll")]
        static extern int GetScrollPos(IntPtr hWnd, int nBar);

        private const int SB_VERT = 1;
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        private const int WM_VSCROLL = 0x0115;
        private const int SB_THUMBPOSITION = 4;
        private float sliderScalingFactor = 1f; // Use float for precision
        private bool isProgrammaticScroll = false;
        public Privacy()
        {
            InitializeComponent();
        }

        private void Privacy_Load(object sender, EventArgs e)
        {

            if (!Properties.Settings.Default.PrivacyAccepted && !SessionFlags.PrivacyFormShown)
            {
                SessionFlags.PrivacyFormShown = true;  // Block repeats
                var pf = new Privacy();
                pf.ShowDialog();
            }
            Privacypolicy.Text = @"
📜 Privacy Policy for Patient Management System
Effective Date: [Insert Date]
Last Updated: [Insert Date]

1. Introduction
This Privacy Policy explains how [Your System Name] (""we"", ""our"", or ""us"") collects, uses, and protects your personal and medical data. We are committed to maintaining the privacy and security of your information in accordance with applicable laws such as the Health Insurance Portability and Accountability Act (HIPAA), Data Privacy Act of 2012 (Philippines), and General Data Protection Regulation (GDPR) where applicable.

By using our system, you agree to the practices described in this policy.

2. Information We Collect
We may collect the following types of information from patients, doctors, and administrative users:

Personal Identifiable Information (PII):

Full name

Date of birth

Address and contact number

Email address

Government-issued IDs

Health Information:

Medical history and diagnosis

Lab test results and prescriptions

Appointment records and doctor notes

Imaging and lab attachments

Treatment history

System and Usage Information:

Device type and IP address

Login activity and access logs

Error and crash reports

3. Purpose of Collection
Your data is used to:

Register and manage patient records

Schedule appointments and track medical history

Provide treatment and diagnosis insights

Generate prescriptions, billing, and reports

Improve user experience and system reliability

Comply with medical and legal obligations

4. Use of Third-Party Services
We may use third-party services such as:

Google Cloud or Firebase for data hosting and backups

Email/SMS gateways for appointment notifications

Analytics tools to improve usability and performance

These services may process limited personal data under strict compliance agreements. We ensure all providers meet data protection standards.

Google’s Privacy Policy: https://policies.google.com/privacy

5. Data Sharing and Disclosure
We do not sell or rent your personal data. Your data may be shared:

With your consent to authorized healthcare professionals

With regulatory authorities as required by law

With third-party vendors only under data protection agreements

All access is logged, monitored, and restricted based on roles and permissions.

6. Data Storage and Security
We implement technical and administrative security measures such as:

End-to-end encryption

Role-based access control

Secure backups and disaster recovery

Two-factor authentication for administrators

Data is stored securely in [Cloud/Local Servers] and retained only as long as legally necessary.

7. Your Rights
You have the right to:

Request access to your personal and health data

Request corrections or updates to your information

Withdraw consent at any time (with exceptions under law)

Request deletion (where applicable)

Lodge complaints with data protection authorities

You may contact our Data Privacy Officer at: [your-privacy-email@domain.com]

8. Children’s Privacy
This system is intended only for use by individuals aged 18 and older or with the involvement of a legal guardian. We do not knowingly collect data from minors without guardian consent.

9. Changes to this Policy
We may update this Privacy Policy periodically. Significant changes will be notified through email or system alerts.

10. Contact Us
For questions, concerns, or to exercise your rights, contact us at:

Data Protection Officer
Email: privacy@[yourdomain].com
Phone: +63 [your number]
Address: [Your Office Address]

";
            /// Get total scrollable line count
            int maxLines = Privacypolicy.GetLineFromCharIndex(Privacypolicy.TextLength);

            // Set the slider's visual range (keep this low like 10 steps)
            Slider.MaxValue = 10;
            Slider.MinValue = 0;
            Slider.Value = 0;

            // Calculate scaling factor (scroll lines per slider step)
            sliderScalingFactor = Math.Max(1f, maxLines / Slider.MaxValue);  // This avoids divide-by-zero


            Scroll.Start(); // Start timer that updates slider from scroll
        }

        private void Slider_Scroll(object sender, ScrollEventArgs e)
        {
            if (!isProgrammaticScroll)
            {
                int scrollTarget = (int)(Slider.Value * sliderScalingFactor);

                isProgrammaticScroll = true;
                SendMessage(Privacypolicy.Handle, WM_VSCROLL,
                    (IntPtr)(SB_THUMBPOSITION + 0x10000 * scrollTarget), IntPtr.Zero);
                isProgrammaticScroll = false;
            }

            ValidateInputs();
        }

        private void Agree_CheckedChanged(object sender, EventArgs e)
        {
            ValidateInputs();
        }
        private void ValidateInputs()
        {
            btnContinue.Enabled = Agree.Checked && Slider.Value == Slider.MaxValue;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Consent saved. Proceeding...", "Thank You");
            Properties.Settings.Default.PrivacyAccepted = true;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void Scroll_Tick(object sender, EventArgs e)
        {
            if(!isProgrammaticScroll)
            {
                int scrollPos = GetScrollPos(Privacypolicy.Handle, SB_VERT);
                int scaledValue = (int)(scrollPos / sliderScalingFactor);

                if (scaledValue >= Slider.MinValue && scaledValue <= Slider.MaxValue)
                {
                    isProgrammaticScroll = true;
                    Slider.Value = scaledValue;
                    isProgrammaticScroll = false;
                }
            }
        }
        public static class SessionFlags
        {
            public static bool PrivacyFormShown = false;
        }

    }
}
