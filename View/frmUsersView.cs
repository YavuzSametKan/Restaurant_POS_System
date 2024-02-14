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
    public partial class frmUsersView : sampleView
    {
        public frmUsersView()
        {
            InitializeComponent();
        }

        private void frmUsersView_Load(object sender, EventArgs e)
        {
            GetData();
        }

        public void GetData()
        {
            string qry = $"SELECT id, userName, email FROM users WHERE email LIKE '%{searchInput.Text}%' " +
                $"OR userName LIKE '%{searchInput.Text}%' " +
                "ORDER BY id DESC";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvUserName);
            lb.Items.Add(dgvEmail);

            DataBaseOperations.CRUDOperations.LoadData(qry, guna2DataGridView1, lb);
        }

        private void searchInput_TextChanged_1(object sender, EventArgs e)
        {
            GetData();
        }

        private bool confirmPassword(string userName)
        {
            frmUsersConfirm frmConfirm = new frmUsersConfirm(userName);
            AddBlurToForm.BlurBackground(frmConfirm);
            return frmConfirm.isConfirmPassword;
        }
        private void addBtn_Click_1(object sender, EventArgs e)
        {
            if (!confirmPassword(frmMain.userName)) return;
            // Confirm State is True

            AddBlurToForm.BlurBackground(new frmUserAdd());

            GetData();
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvedit")
            {
                if (!confirmPassword(Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvUserName"].Value))) return;
                // Confirm State is True

                frmUserAdd frm = new frmUserAdd();
                frm.currentEmail = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvEmail"].Value);
                frm.currentUserName = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvUserName"].Value);
                frm.id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                frm.userNameInput.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvUserName"].Value);
                frm.emailInput.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvEmail"].Value);
                AddBlurToForm.BlurBackground(frm);
                GetData();
            }
            else if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvdel")
            {
                if (!confirmPassword(Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvUserName"].Value))) return;
                // Confirm State is True

                int id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                string qry = $"DELETE FROM users WHERE id = '{id}'";
                Hashtable ht = new Hashtable();
                DataBaseOperations.CRUDOperations.SQL(qry, ht);
                myMessageBox.Show("Delete successfully.");
                GetData();
            }
            else if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvPassword")
            {
                myMessageBox.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
                myMessageBox.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
                if (myMessageBox.Show("Are you sure you want an email for password visibility?") == DialogResult.Yes)
                {
                    // Random code has been generate
                    Random random = new Random();
                    string code = random.Next(100000, 999999 + 1).ToString();

                    string email = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvEmail"].Value);

                    string fromAddress = "codesenderr@gmail.com";
                    string password = "vbxw oqmv uroz fegx";

                    EmailSender emailSender = new EmailSender(fromAddress, password);

                    string toAddress = email;
                    string subject = "Your Password Visibility Code";
                    string body = $"Code = {code}";
                    string fromName = "Yavuz Samet Kan";

                    bool isSent = emailSender.SendEmail(fromName, toAddress, subject, body);

                    myMessageBox.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
                    myMessageBox.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                    if (isSent)
                    {
                        frmVisibleToPassword frm = new frmVisibleToPassword(code, email);
                        frm.id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                        AddBlurToForm.BlurBackground(frm);
                    }
                    else
                    {
                        myMessageBox.Show("Failed to send email.");
                    }
                }
            }
        }
    }
}
