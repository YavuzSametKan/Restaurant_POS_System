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

namespace POS_System.Model
{
    public partial class frmUsersConfirm : Form
    {
        private string userName;
        public bool isConfirmPassword = false;
        public frmUsersConfirm(string userName)
        {
            this.userName = userName;
            InitializeComponent();
            AddRoundedStyleToForm.ApplyRoundedFormStyle(this);
        }

        private void frmUsersConfirm_Load(object sender, EventArgs e)
        {
            passwordInput.UseSystemPasswordChar = true;
            messageLabel.Text += "'" + userName + "'";
        }

        private void passwordVisibilityBtn_Click(object sender, EventArgs e)
        {
            frmLogin.TogglePasswordVisibility(passwordInput,passwordVisibilityBtn);
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if(DataBaseOperations.UserDatasOperations.IsValidUser(userName, passwordInput.Text))
            {
                isConfirmPassword = true;
                this.Close();
            }
            else
                myMessageBox.Show("Password is not correct!");
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
