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
    public partial class frmEnterCode : Form
    {
        private readonly string code;
        private readonly string email;
        public frmEnterCode(string code, string email)
        {
            InitializeComponent();
            AddRoundedStyleToForm.ApplyRoundedFormStyle(this);
            this.code = code;
            this.email = email;
        }

        private void changePasswordBtn_Click(object sender, EventArgs e)
        {
            if (codeInput.Text.Trim() == "" || passwordInput.Text == "" || passwordConfirmInput.Text == "")
                MyWarningMessage.Show("Please fill all inputs.");
            else if(codeInput.Text.Trim() != code)
                MyWarningMessage.Show("Code Is Not Correct!");
            else if (passwordInput.Text != passwordConfirmInput.Text)
                MyWarningMessage.Show("Passwords Are Not The Same!");
            else
            {
                bool hasThePasswordSetted = DataBaseOperations.UserDatasOperations.setPasswordToDB(passwordInput.Text, email);

                if (hasThePasswordSetted)
                {
                    MyInfoMessage.Show("Password succesfully changed.");
                    this.Close();
                }
                else
                {
                    MyWarningMessage.Show("The password must be at least 8 characters; It must contain 1 number, 1 special character and 1 uppercase letter.");
                    return;
                }
            }
        }

        private void frmEnterCode_Load(object sender, EventArgs e)
        {
            passwordInput.UseSystemPasswordChar = true;
            passwordConfirmInput.UseSystemPasswordChar = true;
            infoIabel.Text = $"Please check the e-mail box {email}.";
        }

        private void passwordVisibilityBtn_Click(object sender, EventArgs e)
        {
            frmLogin.TogglePasswordVisibility(passwordInput, passwordVisibilityBtn);
            frmLogin.TogglePasswordVisibility(passwordConfirmInput, passwordVisibilityBtn);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEnterCode_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin loginPage = new frmLogin();
            loginPage.Show();
        }
    }
}
