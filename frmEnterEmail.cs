using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS_System.Classes;

namespace POS_System
{
    public partial class frmEnterEmail : Form
    {
        public frmEnterEmail()
        {
            InitializeComponent();
            AddRoundedStyleToForm.ApplyRoundedFormStyle(this);
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            string isValidEmail = DataBaseOperations.UserDatasOperations.IsValidUser(emailInput.Text.Trim());
            if (emailInput.Text.Trim() == "")
                MyWarningMessage.Show("Please enter an email.");
            else if (isValidEmail == "notAnEmail")
                MyWarningMessage.Show($"\"{emailInput.Text.Trim()}\" is not an email!");
            else if (isValidEmail == "invalid")
                MyWarningMessage.Show($"\"{emailInput.Text.Trim()}\" is not an email registered in the system!");
            else
            {
                // Random code has been generate
                Random random = new Random();
                string code = random.Next(100000, 999999 + 1).ToString();

                string fromAddress = "codesenderr@gmail.com";
                string password = "vbxw oqmv uroz fegx";

                EmailSender emailSender = new EmailSender(fromAddress, password);

                string toAddress = emailInput.Text.Trim();
                string subject = "Your Password Reset Code";
                string body = $"Reset Code = {code}";
                string fromName = "Yavuz Samet Kan";

                bool isSent = emailSender.SendEmail(fromName, toAddress, subject, body);

                if (isSent)
                {
                    frmEnterCode enterPasswordResetCodePage = new frmEnterCode(code,emailInput.Text.Trim());
                    enterPasswordResetCodePage.Show();
                    this.Close();
                }
                else
                {
                    MyWarningMessage.Show("Failed to send email.");
                    this.Close();
                }
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEnterEmail_FormClosed(object sender, FormClosedEventArgs e)
        {
            bool frmEnterCodeIsON = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f is frmEnterCode)
                {
                    frmEnterCodeIsON = true; // frmEnterCode zaten açık
                }
            }
            if (!frmEnterCodeIsON)
            {
                frmLogin loginPage = new frmLogin();
                loginPage.Show();
            } 
        }
    }
}
