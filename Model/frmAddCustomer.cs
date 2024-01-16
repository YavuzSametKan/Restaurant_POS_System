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
    public partial class frmAddCustomer : Form
    {
        public frmAddCustomer()
        {
            InitializeComponent();
            AddRoundedStyleToForm.ApplyRoundedFormStyle(this);
        }

        public string orderType = "";
        public int driverID = 0;
        public int MainID = 0;

        private void frmAddCustomer_Load(object sender, EventArgs e)
        {
            //string qry = "SELECT staffID 'id', sName 'name' FROM staff WHERE sRole = 'Driver'";
            string qry = "SELECT staffID 'id', sName 'name' FROM staff WHERE sRole = 'Driver'";
            DataBaseOperations.CRUDOperations.CBFill(qry, driverComboBox);

            //if (MainID > 0)
            //    driverComboBox.SelectedValue = driverID;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            nameInput.Text = "";
            phoneInput.Text = "";
            adressInput.Text = "";
            driverComboBox.SelectedIndex = -1;
            driverID = 0;
            this.Close();
        }

        private void driverComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            driverID = Convert.ToInt32(driverComboBox.SelectedValue);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (!(phoneInput.Text.All(char.IsDigit) && (phoneInput.Text.Length >= 7 && phoneInput.Text.Length <= 15)))
            {
                myWarningMessageBox.Show("This is not an Phone number: " + phoneInput.Text);
                return;
            }

            if (nameInput.Text != "" && phoneInput.Text != "" && driverComboBox.Text != "" && adressInput.Text != "")
                this.Close();
            else
                myWarningMessageBox.Show("Please fill the all inputs.");
        }

        private void phoneInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
