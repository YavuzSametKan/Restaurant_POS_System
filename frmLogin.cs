using POS_System.Classes;
using System;
using System.Windows.Forms;

namespace POS_System
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            AddRoundedStyleToForm.ApplyRoundedFormStyle(this);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            passwordInput.UseSystemPasswordChar = true;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if(DataBaseOperations.UserDatasOperations.IsValidUser(userNameInput.Text.Trim(), passwordInput.Text))
            {
                this.Hide();
                frmMain mainPage = new frmMain(userNameInput.Text.Trim());
                mainPage.Show();
            }   
            else
            {
                MyWarningMessage.Show("User name or password is incorrect.");
                return;
            }
        }
        public static void TogglePasswordVisibility(Guna.UI2.WinForms.Guna2TextBox textBox, Guna.UI2.WinForms.Guna2Button button)
        {
            if (textBox.UseSystemPasswordChar)
            {
                button.Text = "hide";
                textBox.UseSystemPasswordChar = false;
            }
            else
            {
                button.Text = "show";
                textBox.UseSystemPasswordChar = true;
            }
        }

        private void passwordVisibilityBtn_Click(object sender, EventArgs e)
        {
            TogglePasswordVisibility(passwordInput,passwordVisibilityBtn);
        }

        private void iForgotMyPasswordLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmEnterEmail enterEmailPage = new frmEnterEmail();
            enterEmailPage.Show();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
