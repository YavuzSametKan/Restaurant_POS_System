﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS_System.Model;
using POS_System.Classes;
using System.Collections;

namespace POS_System.View
{
    public partial class frmTableView : sampleView
    {
        public frmTableView()
        {
            InitializeComponent();
        }

        private void frmTableView_Load(object sender, EventArgs e)
        {
            GetData();
        }

        public void GetData()
        {
            string qry = $"SELECT * FROM tables WHERE tName LIKE '%{searchInput.Text}%' ORDER BY tid DESC";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvName);

            DataBaseOperations.CRUDOperations.LoadData(qry, guna2DataGridView1, lb);
        }

        public override void addBtn_Click(object sender, EventArgs e)
        {
            //frmTableAdd frm = new frmTableAdd();
            //frm.ShowDialog();

            AddBlurToForm.BlurBackground(new frmTableAdd());

            GetData();
        }

        private void frmCategoryView_Load(object sender, EventArgs e)
        {
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
                frmTableAdd frm = new frmTableAdd();
                frm.id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                frm.nameInput.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvName"].Value);
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
                    string qry = $"DELETE FROM tables WHERE tid = '{id}'";
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
