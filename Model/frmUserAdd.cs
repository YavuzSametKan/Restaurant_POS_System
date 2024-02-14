using System;
using System.Collections;
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
    public partial class frmUserAdd : sampleAdd
    {
        public frmUserAdd()
        {
            InitializeComponent();
            AddRoundedStyleToForm.ApplyRoundedFormStyle(this);
        }
        public int id = 0;

        private void frmUserAdd_Load(object sender, EventArgs e)
        {
            passwordInput.UseSystemPasswordChar = true;
            passwordConfirmInput.UseSystemPasswordChar = true;
        }

        private void passwordVisibilityBtn_Click(object sender, EventArgs e)
        {
            frmLogin.TogglePasswordVisibility(passwordInput, passwordVisibilityBtn);
            frmLogin.TogglePasswordVisibility(passwordConfirmInput, passwordVisibilityBtn);
        }

        public string currentEmail;
        public string currentUserName;
        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (userNameInput.Text.Trim() == "" || emailInput.Text.Trim() == "" || passwordInput.Text == "" || passwordConfirmInput.Text == "")
                myMessageBox.Show("Please fill all inputs.");
            else if (DataBaseOperations.UserDatasOperations.IsValidUserName(userNameInput.Text.Trim())
                    && !(id > 0 && userNameInput.Text.Trim() == currentUserName))
                    myMessageBox.Show("Any user has already used this user name.");
            else if (!DataBaseOperations.UserDatasOperations.IsValidAnEmail(emailInput.Text.Trim()))
                myMessageBox.Show("This is not an email: " + emailInput.Text.Trim());
            else if (DataBaseOperations.UserDatasOperations.IsValidUser(emailInput.Text.Trim()) == "valid"
                && !(id > 0 && emailInput.Text.Trim() == currentEmail))
                myMessageBox.Show("Any user has already used this email.");
            else if (passwordInput.Text != passwordConfirmInput.Text)
                myMessageBox.Show("Passwords Are Not The Same!");
            else if (!DataBaseOperations.UserDatasOperations.passwordSecurityCheck(passwordInput.Text))
                myMessageBox.Show("The password must be at least 8 characters; It must contain 1 number, 1 special character and 1 uppercase letter.");
            else
            {
                string qry = "";

                if (id == 0) // insert
                    qry = "INSERT INTO users (userName,email,password) VALUES (@userName, @email, @password)";
                else // update
                    qry = "UPDATE users SET userName = @userName, email = @email, password = @password WHERE id = @id ";

                Hashtable ht = new Hashtable();
                ht.Add("@id", id);
                ht.Add("@userName", userNameInput.Text.Trim());
                ht.Add("@email", emailInput.Text.Trim());
                ht.Add("@password", passwordInput.Text);

                if (DataBaseOperations.CRUDOperations.SQL(qry, ht) > 0)
                {
                    myMessageBox.Show("Saved successfully.");
                    this.Close();
                }
            }
        }
    }
}
