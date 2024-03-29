﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using POS_System.Classes;
using System.Drawing.Printing;

namespace POS_System.Model
{
    public partial class frmBillList : sampleAdd
    {
        public frmBillList()
        {
            InitializeComponent();
            AddRoundedStyleToForm.ApplyRoundedFormStyle(this);
        }

        public int MainID = 0;
        private int printID = 0;
        private int PrintingHeight;
        private string printingData;

        private void frmBillList_Load(object sender, EventArgs e)
        {
            string qry = $"SELECT mainID,tableName,waiterName,orderType,status,total,date,time FROM tblMain WHERE date = '{DateTime.Now.Date.ToString("dd.MM.yyyy")}' ORDER BY mainID DESC";
            toThisDate.Value = DateTime.Now.Date;
            fromThisDate.Value = DateTime.Now.Date;
            LoadData(qry);
        }

        private void LoadData(string qry)
        {
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvTable);
            lb.Items.Add(dgvWaiter);
            lb.Items.Add(dgvType);
            lb.Items.Add(dgvStatus);
            lb.Items.Add(dgvTotal);
            lb.Items.Add(dgvDate);
            lb.Items.Add(dgvTime);

            DataBaseOperations.CRUDOperations.LoadData(qry, guna2DataGridView1, lb);

            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            { // if status value is paid edit btn is unvisible
                if (row.Cells["dgvStatus"].Value?.ToString() == "Paid")
                    row.Cells["dgvedit"].Value = new System.Drawing.Bitmap(1, 1);
                else
                    row.Cells["dgvPrint"].Value = new System.Drawing.Bitmap(1, 1);

                if (row.Cells["dgvStatus"].Value?.ToString() != "Pending" && row.Cells["dgvStatus"].Value?.ToString() != "Hold")
                    row.Cells["dgvCancel"].Value = new System.Drawing.Bitmap(1, 1);
            }
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvCancel" &&
                (guna2DataGridView1.CurrentRow.Cells["dgvStatus"].Value.ToString() == "Pending"
                || guna2DataGridView1.CurrentRow.Cells["dgvStatus"].Value.ToString() == "Hold"))
            {
                myMessageBox.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
                myMessageBox.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
                if (myMessageBox.Show("Are you sure you want to cancel this order?") == DialogResult.Yes)
                {
                    MainID = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                    string qry = $"DELETE FROM tblMain WHERE mainID = {MainID};\n" +
                                 $"DELETE FROM tblDetails WHERE mainID = {MainID};";
                    SQLiteCommand cmd = new SQLiteCommand(qry, DataBaseOperations.DataBaseConnection.con);
                    if (DataBaseOperations.DataBaseConnection.con.State == ConnectionState.Closed)
                        DataBaseOperations.DataBaseConnection.con.Open();

                    cmd.ExecuteNonQuery();

                    if (DataBaseOperations.DataBaseConnection.con.State == ConnectionState.Open)
                        DataBaseOperations.DataBaseConnection.con.Close();

                    myMessageBox.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                    myMessageBox.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                    myMessageBox.Show("Cancel successfully.");

                    LoadData("SELECT mainID,tableName,waiterName,orderType,status,total,date,time FROM tblMain " +
                            $"WHERE substr(date, 7, 4) || '-' || substr(date, 4, 2) || '-' || substr(date, 1, 2) BETWEEN '{fromThisDate.Value.ToString("yyyy-MM-dd")}' AND '{toThisDate.Value.ToString("yyyy-MM-dd")}' " +
                            "ORDER BY mainID DESC");
                }
            }

            if (guna2DataGridView1.CurrentCell != null){
                if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvedit" &&
                    guna2DataGridView1.CurrentRow.Cells["dgvStatus"].Value.ToString() != "Paid")
                {
                    MainID = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                    this.Close();
                }

                if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvPrint")
                { // Printing Receipt
                    printID = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                    string printingDatasQry = @"SELECT date, time, paymentMethod, orderType, productName, qty, price, amount, received, change, total FROM tblMain m
                                           INNER JOIN tblDetails d ON m.mainID = d.mainID
                                           WHERE m.mainID = " + printID;
                    printingData = PrintOperations.generateReceipt("Borcelle Restaurant", "₺", printingDatasQry, DataBaseOperations.DataBaseConnection.con);
                    PrintingHeight = (int)(printingData.Split('\n').Length * 17.2);
                    printPreviewDialog.Document = printDocument;
                    printDocument.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Receipt", 400, PrintingHeight);
                    printPreviewDialog.ShowDialog();
                }
            }
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(printingData, new Font("Consolas", 10), Brushes.Black, new PointF(10, 10));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fromThisDate_ValueChanged(object sender, EventArgs e)
        {
            string qry = "SELECT mainID,tableName,waiterName,orderType,status,total,date,time FROM tblMain " +
                $"WHERE substr(date, 7, 4) || '-' || substr(date, 4, 2) || '-' || substr(date, 1, 2) BETWEEN '{fromThisDate.Value.ToString("yyyy-MM-dd")}' AND '{toThisDate.Value.ToString("yyyy-MM-dd")}' " + 
                "ORDER BY mainID DESC";
            LoadData(qry);
        }

        private void toThisDate_ValueChanged(object sender, EventArgs e)
        {
            string qry = "SELECT mainID,tableName,waiterName,orderType,status,total,date,time FROM tblMain " +
                $"WHERE substr(date, 7, 4) || '-' || substr(date, 4, 2) || '-' || substr(date, 1, 2) BETWEEN '{fromThisDate.Value.ToString("yyyy-MM-dd")}' AND '{toThisDate.Value.ToString("yyyy-MM-dd")}' " +
                "ORDER BY mainID DESC";
            LoadData(qry);
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            string printingDatasQry = @"SELECT m.mainID 'Order', orderType, paymentMethod, productName, qty, price, amount, received, change, total, date, time FROM tblMain m
                                      INNER JOIN tblDetails d ON m.mainID = d.mainID
                                      WHERE status = 'Paid' " +
                                      $"AND substr(date, 7, 4) || '-' || substr(date, 4, 2) || '-' || substr(date, 1, 2) BETWEEN '{fromThisDate.Value.ToString("yyyy-MM-dd")}' AND '{toThisDate.Value.ToString("yyyy-MM-dd")}' " +
                                      "ORDER BY m.mainID DESC";
            string[] headers = { "Order", "Ordr Typ", "Pymnt Mthd", "Product", "Qty", "Price", "Amount", "Received", "Change", "Total", "Date", "Time" };
            printingData = PrintOperations.PrintSaledProduct(156, headers, fromThisDate.Value.ToString("dd.MM.yyyy"), toThisDate.Value.ToString("dd.MM.yyyy"), "₺", printingDatasQry, DataBaseOperations.DataBaseConnection.con);
            PrintingHeight = (int)(printingData.Split('\n').Length * 17.2);
            printPreviewDialog.Document = printDocument;
            printDocument.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Orders", 1350, PrintingHeight);
            printPreviewDialog.ShowDialog();
        }
    }
}
