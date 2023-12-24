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

namespace POS_System.Model
{
    public partial class frmTableSelect : Form
    {
        public frmTableSelect()
        {
            InitializeComponent();
        }

        public string TableName;

        private void frmTableSelect_Load(object sender, EventArgs e)
        {
            string qry = "SELECT * FROM tables";
            SQLiteCommand cmd = new SQLiteCommand(qry, DataBaseOperations.DataBaseConnection.con);
            DataTable dt = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                Guna.UI2.WinForms.Guna2Button btn = new Guna.UI2.WinForms.Guna2Button();
                btn.Text = row["tName"].ToString();
                btn.Width = 150;
                btn.Height = 50;
                btn.FillColor = Color.FromArgb(253, 184, 39);
                btn.HoverState.FillColor = Color.FromArgb(245, 173, 22);
                btn.Cursor = Cursors.Hand;
                flowLayoutPanel1.Controls.Add(btn);

                // event for click
                btn.Click += new EventHandler(btn_Click);
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            TableName = (sender as Guna.UI2.WinForms.Guna2Button).Text.ToString();
            this.Close();
        }
    }
}
