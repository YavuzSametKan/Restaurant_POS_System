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
    public partial class frmCategoryAdd : sampleAdd
    {
        public frmCategoryAdd()
        {
            InitializeComponent();
            AddRoundedStyleToForm.ApplyRoundedFormStyle(this);
        }

        public int id = 0;
        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (nameInput.Text.Trim() != "")
            {
                string qry = "";

                if (id == 0) // insert
                    qry = "INSERT INTO category (catName) VALUES (@Name)";
                else // update
                    qry = "UPDATE category SET catName = @Name WHERE catID = @id ";

                Hashtable ht = new Hashtable();
                ht.Add("@id", id);
                ht.Add("@Name", nameInput.Text.Trim());

                if (DataBaseOperations.CRUDOperations.SQL(qry, ht) > 0)
                {
                    myMessageBox.Show("Saved successfully.");
                    id = 0;
                    nameInput.Text = "";
                    nameInput.Focus();
                }
            }
            else
                myMessageBox.Show("Please fill the all inputs.");

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
