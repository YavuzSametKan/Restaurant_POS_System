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
using POS_System.Model;

namespace POS_System.View
{
    public partial class frmProductView : sampleView
    {
        public frmProductView()
        {
            InitializeComponent();
        }

        private void frmProductView_Load(object sender, EventArgs e)
        {
            GetData();
        }

        public void GetData()
        {
            //guna2DataGridView1.Columns["dgvSno"].DisplayIndex = 0;
            
            string qry = $"SELECT pID,pName,pPrice,categoryID,c.catName FROM products p INNER JOIN category c ON c.catID = p.categoryID WHERE pName LIKE '%{searchInput.Text}%' " +
                $"OR c.catName LIKE '%{searchInput.Text}%' " +
                $"OR pPrice LIKE '%{searchInput.Text}%'";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvName);
            lb.Items.Add(dgvPrice);
            lb.Items.Add(dgvCatID);
            lb.Items.Add(dgvCat);

            DataBaseOperations.CRUDOperations.LoadData(qry, guna2DataGridView1, lb);
        }

        public override void addBtn_Click(object sender, EventArgs e)
        {
            AddBlurToForm.BlurBackground(new frmProductAdd());

            //frmCategoryAdd frm = new frmCategoryAdd();
            //frm.ShowDialog();

            GetData();
        }

        public override void searchInput_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvedit")
            {
                frmProductAdd frm = new frmProductAdd();
                frm.id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                frm.cID = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvCatID"].Value);
                /*frm.nameInput.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvName"].Value);
                frm.priceInput.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvPrice"].Value);
                frm.categoryComboBox.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvCat"].Value);*/
                AddBlurToForm.BlurBackground(frm);
                GetData();
            }

            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvdel")
            {
                myMessageBox.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
                myMessageBox.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
                if (myMessageBox.Show("Are you sure you want to delete?") == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                    string qry = $"DELETE FROM products WHERE pID = '{id}'";
                    Hashtable ht = new Hashtable();
                    DataBaseOperations.CRUDOperations.SQL(qry, ht);

                    myMessageBox.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                    myMessageBox.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                    myMessageBox.Show("Delete successfully.");
                    GetData();
                }
            }
        }
    }
}
