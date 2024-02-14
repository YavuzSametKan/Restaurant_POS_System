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

namespace POS_System.View
{
    public partial class frmOrdersView : sampleView
    {
        public frmOrdersView()
        {
            InitializeComponent();
        }

        private void frmOrdersView_Load(object sender, EventArgs e)
        {
            toThisDate.Value = DateTime.Now.Date;
            fromThisDate.Value = DateTime.Now.Date;
            GetData();
        }

        private void GetData()
        {
            string qry = @"SELECT m.mainID, orderType, productName, qty, price, amount, tableName, waiterName,  status, paymentMethod, total, received, change, sName 'driver name', customerName, customerPhone, customerAdress, isEditted, date, time 
                      FROM tblMain m 
                      INNER JOIN tblDetails d ON m.mainID = d.mainID 
                      LEFT JOIN staff s ON m.driverID = s.staffID " +
                      $"WHERE (substr(date, 7, 4) || '-' || substr(date, 4, 2) || '-' || substr(date, 1, 2) BETWEEN '{fromThisDate.Value.ToString("yyyy-MM-dd")}' AND '{toThisDate.Value.ToString("yyyy-MM-dd")}') " +
                      $"AND (productName LIKE '%{searchInput.Text}%' " +
                      $"OR waiterName LIKE '%{searchInput.Text}%' " +
                      $"OR sName LIKE '%{searchInput.Text}%' " +
                      $"OR customerName LIKE '%{searchInput.Text}%' " +
                      $"OR customerPhone LIKE '%{searchInput.Text}%') " +
                      "ORDER BY m.mainID DESC";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvOrder);
            lb.Items.Add(dgvType);
            lb.Items.Add(dgvProductName);
            lb.Items.Add(dgvQty);
            lb.Items.Add(dgvPrice);
            lb.Items.Add(dgvAmount);
            lb.Items.Add(dgvTable);
            lb.Items.Add(dgvWaiter);
            lb.Items.Add(dgvStatus);
            lb.Items.Add(dgvPaymentMethod);
            lb.Items.Add(dgvTotal);
            lb.Items.Add(dgvReceived);
            lb.Items.Add(dgvChange);
            lb.Items.Add(dgvDriver);
            lb.Items.Add(dgvCustomerName);
            lb.Items.Add(dgvCustomerPhone);
            lb.Items.Add(dgvCustomerAdress);
            lb.Items.Add(dgvIsEditted);
            lb.Items.Add(dgvDate);
            lb.Items.Add(dgvTime);

            DataBaseOperations.CRUDOperations.LoadData(qry, guna2DataGridView1, lb);
        }

        private void searchInput_TextChanged_1(object sender, EventArgs e)
        {
            GetData();
        }

        private void fromThisDate_ValueChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void toThisDate_ValueChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private int PrintingHeight;
        private string printingData;
        private void printButton_Click(object sender, EventArgs e)
        {
            string printingDatasQry = @"SELECT m.mainID 'Order', orderType, paymentMethod, productName, qty, price, amount, received, change, total, date, time FROM tblMain m
                                      INNER JOIN tblDetails d ON m.mainID = d.mainID
                                      WHERE substr(date, 7, 4) || '-' || substr(date, 4, 2) || '-' || substr(date, 1, 2) BETWEEN '" + fromThisDate.Value.ToString("yyyy-MM-dd") + "' AND '" + toThisDate.Value.ToString("yyyy-MM-dd") + @"' 
                                      ORDER BY m.mainID DESC";
            string[] headers = { "Order", "Ordr Typ", "Pymnt Mthd", "Product", "Qty", "Price", "Amount", "Received", "Change", "Total", "Date", "Time" };
            printingData = PrintOperations.PrintSaledProduct(156, headers, fromThisDate.Value.ToString("dd.MM.yyyy"), toThisDate.Value.ToString("dd.MM.yyyy"), "₺", printingDatasQry, DataBaseOperations.DataBaseConnection.con);
            PrintingHeight = (int)(printingData.Split('\n').Length * 17.2);
            printPreviewDialog.Document = printDocument;
            printDocument.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Orders", 1350, PrintingHeight);
            printPreviewDialog.ShowDialog();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(printingData, new Font("Consolas", 10), Brushes.Black, new PointF(10, 10));

        }
    }
}
