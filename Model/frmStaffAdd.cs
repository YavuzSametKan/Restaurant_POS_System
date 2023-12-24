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
    public partial class frmStaffAdd : sampleAdd
    {
        public frmStaffAdd()
        {
            InitializeComponent();
            AddRoundedStyleToForm.ApplyRoundedFormStyle(this);
        }

        public int id = 0;

        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (nameInput.Text.Trim() != "" && phoneInput.Text.Trim() != "" && roleComboBox.Text != "")
            {
                string qry = "";

                if (id == 0) // insert
                    qry = "INSERT INTO staff (sName, sPhone, sRole) VALUES (@Name, @Phone, @Role)";
                else // update
                    qry = "UPDATE staff SET sName = @Name, sPhone = @Phone, sRole = @Role WHERE staffID = @id ";

                Hashtable ht = new Hashtable();
                ht.Add("@id", id);
                ht.Add("@Name", nameInput.Text.Trim());
                ht.Add("@Phone", phoneInput.Text.Trim());
                ht.Add("@Role", roleComboBox.Text);

                if (DataBaseOperations.CRUDOperations.SQL(qry, ht) > 0)
                {
                    myMessageBox.Show("Saved successfully.");
                    id = 0;
                    nameInput.Text = "";
                    phoneInput.Text = "";
                    roleComboBox.SelectedIndex = -1;
                    nameInput.Focus();
                }
            }
            else
                myMessageBox.Show("Please fill the all inputs.");

        }
    }
}
