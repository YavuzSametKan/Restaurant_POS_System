 using System;
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

namespace POS_System
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private DataTable DT(string qry)
        {
            SQLiteCommand cmd = new SQLiteCommand(qry, DataBaseOperations.DataBaseConnection.con);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            string today = DateTime.Now.Date.ToString("dd.MM.yyyy");
            lblFoodProducts.Text = DT("SELECT COUNT(*) FROM products").Rows[0][0].ToString();
            lblFoodCategory.Text = DT("SELECT COUNT(*) FROM category").Rows[0][0].ToString();
            lblDailyEarnings.Text = DT($"SELECT COALESCE(SUM(total), 0) FROM tblMain WHERE date = '{today}' AND status = 'Paid'").Rows[0][0].ToString() + "₺";
            lblSystemUsers.Text = DT("SELECT COUNT(*) FROM users").Rows[0][0].ToString();
            lblStaff.Text = DT("SELECT COUNT(*) FROM staff").Rows[0][0].ToString();
            lblDailyOrders.Text = DT($"SELECT COUNT(*) FROM tblMain WHERE date = '{today}'").Rows[0][0].ToString();
            lblTotalOrders.Text = DT("SELECT COUNT(*) FROM tblMain").Rows[0][0].ToString();
            lblAvailableTables.Text = DT($"SELECT COUNT(t.tName) FROM tables t LEFT JOIN tblMain m ON t.tName = m.tableName AND m.date = '{today}' AND m.status <> 'Paid' WHERE m.tableName IS NULL").Rows[0][0].ToString();
            lblPaidOrders.Text = DT($"SELECT COUNT(*) FROM tblMain WHERE status = 'Paid' AND date = '{today}'").Rows[0][0].ToString();
            lblUnpaidOrders.Text = DT($"SELECT COUNT(*) FROM tblMain WHERE status <> 'Paid' AND date = '{today}'").Rows[0][0].ToString();

        }
    }
}
