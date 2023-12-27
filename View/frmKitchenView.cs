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
using System.Collections;

namespace POS_System.View
{
    public partial class frmKitchenView : Form
    {
        public frmKitchenView()
        {
            InitializeComponent();
        }

        private void frmKitchenView_Load(object sender, EventArgs e)
        {
            GetOrders();
        }

        private void GetOrders()
        {
            flowLayoutPanel1.Controls.Clear();
            string qry1 = "SELECT * FROM tblMain WHERE status = 'Pending'";
            SQLiteCommand cmd1 = new SQLiteCommand(qry1, DataBaseOperations.DataBaseConnection.con);
            DataTable dt1 = new DataTable();
            SQLiteDataAdapter da1 = new SQLiteDataAdapter(cmd1);
            da1.Fill(dt1);

            FlowLayoutPanel p1;

            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                // Create order elements
                p1 = new FlowLayoutPanel();
                p1.AutoSize = true;
                p1.FlowDirection = FlowDirection.TopDown;
                p1.BorderStyle = BorderStyle.FixedSingle;
                p1.Margin = new Padding(10, 10, 10, 10);

                FlowLayoutPanel p2 = new FlowLayoutPanel();
                p2.BackColor = Color.FromArgb(253, 184, 39);
                p2.AutoSize = true;
                p2.Dock = DockStyle.Top;
                p2.FlowDirection = FlowDirection.TopDown;
                p2.Margin = new Padding(0, 0, 0, 0);

                Label lbl1 = new Label();
                lbl1.ForeColor = Color.White;
                lbl1.Margin = new Padding(10, 10, 3, 0);
                lbl1.AutoSize = true;

                Label lbl2 = new Label();
                lbl2.ForeColor = Color.White;
                lbl2.Margin = new Padding(10, 5, 3, 0);
                lbl2.AutoSize = true;

                Label lbl3 = new Label();
                lbl3.ForeColor = Color.White;
                lbl3.Margin = new Padding(10, 5, 3, 0);
                lbl3.AutoSize = true;

                Label lbl4 = new Label();
                lbl4.ForeColor = Color.White;
                lbl4.Margin = new Padding(10, 5, 3, 10);
                lbl4.AutoSize = true;

                lbl1.Text = "Table: " + dt1.Rows[i]["tableName"].ToString();
                lbl2.Text = "Waiter: " + dt1.Rows[i]["waiterName"].ToString();
                lbl3.Text = "Order Type: " + dt1.Rows[i]["orderType"].ToString();
                lbl4.Text = "Order Time: " + dt1.Rows[i]["time"].ToString();

                p2.Controls.Add(lbl1);
                p2.Controls.Add(lbl2);
                p2.Controls.Add(lbl3);
                p2.Controls.Add(lbl4);

                p1.Controls.Add(p2);

                // Add products
                int mainID = Convert.ToInt32(dt1.Rows[i]["mainID"].ToString());

                string qry2 = @"SELECT * FROM tblMain m 
                                INNER JOIN tblDetails d ON m.mainID = d.mainID 
                                INNER JOIN products p ON p.pID = d.productID
                                WHERE m.mainID = "+mainID+"";

                SQLiteCommand cmd2 = new SQLiteCommand(qry2, DataBaseOperations.DataBaseConnection.con);
                DataTable dt2 = new DataTable();
                SQLiteDataAdapter da2 = new SQLiteDataAdapter(cmd2);
                da2.Fill(dt2);

                for (int j = 0; j < dt2.Rows.Count; j++)
                {
                    Label lbl5 = new Label();
                    lbl5.ForeColor = Color.Black;
                    lbl5.Margin = new Padding(10, 5, 3, 0);
                    lbl5.AutoSize = true;

                    lbl5.Text = "" + (j + 1) + " " + dt2.Rows[j]["pName"].ToString() + " " + dt2.Rows[j]["qty"].ToString();

                    p1.Controls.Add(lbl5);
                }

                // Add button to change the order status
                Guna.UI2.WinForms.Guna2Button btn = new Guna.UI2.WinForms.Guna2Button();
                btn.AutoRoundedCorners = true;
                btn.Size = new Size(100,35);
                btn.FillColor = Color.FromArgb(253, 184, 39);
                btn.ForeColor = Color.White;
                btn.Font = new Font(btn.Font, FontStyle.Bold);
                btn.Margin = new Padding(0,10,0,10);
                btn.Anchor = AnchorStyles.None;
                btn.Location = new Point((p1.Width - btn.Width) / 2, (p1.Height - btn.Height) / 2);
                btn.Text = "Complete";
                btn.Tag = dt1.Rows[i]["MainID"].ToString(); // store the id
                btn.Cursor = Cursors.Hand;
                btn.Click += new EventHandler(b_click);
                
                p1.Controls.Add(btn);

                flowLayoutPanel1.Controls.Add(p1);
            }
        }

        private void b_click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32((sender as Guna.UI2.WinForms.Guna2Button).Tag.ToString());
            myMessageBox.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
            myMessageBox.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
            if (myMessageBox.Show("Are you sure you want to delete?") == DialogResult.Yes)
            {
                string qry = "UPDATE tblMain SET status = 'Complete' WHERE mainID = @ID";
                Hashtable ht = new Hashtable();
                ht.Add("@ID", id);

                if(DataBaseOperations.CRUDOperations.SQL(qry,ht) > 0)
                {
                    myMessageBox.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                    myMessageBox.Show("Saved Successfully");
                }
                GetOrders();
            }
        }
    }
}
