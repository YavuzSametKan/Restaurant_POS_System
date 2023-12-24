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
using System.IO;
using System.Threading;
using System.Collections;

namespace POS_System.Model
{
    public partial class frmPOS : Form
    {
        public frmPOS()
        {
            InitializeComponent();
        }

        public int MainID = 0;
        public string OrderType;

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmPOS_Load(object sender, EventArgs e)
        {
            AddCategoryBtns();

            productPanel.Controls.Clear();
            LoadProducts();
        }

        private void AddCategoryBtns()
        {
            string qry = "SELECT * FROM category";
            SQLiteCommand cmd = new SQLiteCommand(qry, DataBaseOperations.DataBaseConnection.con);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            //categoryPanel.Controls.Clear();

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Guna.UI2.WinForms.Guna2Button btn = new Guna.UI2.WinForms.Guna2Button();
                    btn.FillColor = Color.FromArgb(253, 184, 39);
                    btn.Size = new Size(196, 60);
                    btn.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                    btn.Cursor = Cursors.Hand;
                    btn.BorderRadius = 10;
                    btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
                    btn.Text = row["catName"].ToString();

                    // event for click
                    btn.Click += new EventHandler(btn_Click);

                    categoryPanel.Controls.Add(btn);
                }
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button btn = (Guna.UI2.WinForms.Guna2Button)sender;
            foreach (var item in productPanel.Controls)
            {
                var product = (ucProduct)item;
                product.Visible = product.PCategory.ToLower().Contains(btn.Text.Trim().ToLower());
            }
        }

        private void allCategoryBtn_Click(object sender, EventArgs e)
        {
            productPanel.Controls.Clear();
            LoadProducts();
        }

        private void AddItems(string id, String proID, string name, string cat, string price, Image pimage)
        {
            var w = new ucProduct()
            {
                PName = name,
                PPrice = price,
                PCategory = cat,
                PImage = pimage,
                id = Convert.ToInt32(id)
            };

            productPanel.Controls.Add(w);

            w.onSelect += (ss, ee) =>
            {
                var wdg = (ucProduct)ss;
                foreach (DataGridViewRow item in guna2DataGridView1.Rows)
                {
                    // this will check it product already there then a one to quantity and update price
                    if (Convert.ToInt32(item.Cells["dgvid"].Value) == wdg.id)
                    {
                        item.Cells["dgvQty"].Value = int.Parse(item.Cells["dgvQty"].Value.ToString()) + 1;
                        item.Cells["dgvAmount"].Value = int.Parse(item.Cells["dgvQty"].Value.ToString()) *
                                                        double.Parse(item.Cells["dgvPrice"].Value.ToString());
                        GetTotal();
                        return;
                    }
                }

                // this line add new product
                guna2DataGridView1.Rows.Add(new object[] {0, 0, wdg.id, wdg.PName, 1, wdg.PPrice, wdg.PPrice });
                GetTotal();
            };
        }


        // Getting product from database
        private void LoadProducts()
        {
            string qry = "Select * FROM products INNER JOIN category ON catID = categoryID ";
            SQLiteCommand cmd = new SQLiteCommand(qry, DataBaseOperations.DataBaseConnection.con);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                Byte[] imageArray = (byte[])item["pImage"];

                AddItems("0",item["pID"].ToString(), item["pName"].ToString(), item["catName"].ToString(), item["pPrice"].ToString(), Image.FromStream(new MemoryStream(imageArray)));
            }
        }

        /*private void searchBtn_Click(object sender, EventArgs e)
        {
            frmLoading loading = new frmLoading();
            loading.Show();

            Thread backgroundThread = new Thread(() =>
            {
                foreach (var item in productPanel.Controls)
                {
                    var product = (ucProduct)item;
                    product.Visible = product.PName.ToLower().Contains(searchInput.Text.Trim().ToLower());
                }

                loading.Invoke((MethodInvoker)delegate { loading.Close(); });
            });

            backgroundThread.IsBackground = true;
            backgroundThread.Start();
        }*/

        private void searchInput_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in productPanel.Controls)
            {
                var product = (ucProduct)item;
                product.Visible = product.PName.ToLower().Contains(searchInput.Text.Trim().ToLower());
            }
        }

        private void guna2DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // for srial no
            int count = 0;

            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }

        private void GetTotal()
        {
            double total = 0;
            string currency = "₺";
            totalLabel.Text = "";
            foreach(DataGridViewRow item in guna2DataGridView1.Rows)
                total += double.Parse(item.Cells["dgvAmount"].Value.ToString());
            totalLabel.Text = total.ToString("N2") + currency;
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            tableLabel.Text = "";
            waiterLabel.Text = "";
            tableLabel.Visible = false;
            waiterLabel.Visible = false;
            guna2DataGridView1.Rows.Clear();
            MainID = 0;
            totalLabel.Text = "0.00";
        }

        private void deliveryBtn_Click(object sender, EventArgs e)
        {
            tableLabel.Text = "";
            waiterLabel.Text = "";
            tableLabel.Visible = false;
            waiterLabel.Visible = false;
            OrderType = "Delivery";
        }

        private void takeAwayBtn_Click(object sender, EventArgs e)
        {
            tableLabel.Text = "";
            waiterLabel.Text = "";
            tableLabel.Visible = false;
            waiterLabel.Visible = false;
            OrderType = "Take Away";
        }

        private void dineInBtn_Click(object sender, EventArgs e)
        {
            frmTableSelect frm = new frmTableSelect();
            AddBlurToForm.BlurBackground(frm);
            if (frm.TableName != "")
            {
                tableLabel.Text = "Table: " + frm.TableName;
                tableLabel.Visible = true;
            }
            else
            {
                tableLabel.Text = "";
                tableLabel.Visible = false;
            }

            frmWaiterSelect frm2 = new frmWaiterSelect();
            AddBlurToForm.BlurBackground(frm2);
            if (frm2.waiterName != "")
            {
                waiterLabel.Text = "Waiter: " + frm2.waiterName;
                waiterLabel.Visible = true;
            }
            else
            {
                waiterLabel.Text = "";
                waiterLabel.Visible = false;
            }
        }

        private void KOTBtn_Click(object sender, EventArgs e)
        {
            // Save the datas in database

            string qry1 = ""; // Main Table
            string qry2 = ""; // Detail Table

            int detailID = 0;

            if (MainID == 0) // Insert
            {
                qry1 = @"INSERT INTO tblMain (aDate, time, tableName, waiterName, status, orderType, total, received, change) 
                        VALUES (@aDate, @time, @tableName, @waiterName, @status, @orderType, @total, @received, @change);
                        SELECT SCOPE_ODENTITY()";
                        // this line will get recent add id value -> "SELECT SCOPE_ODENTITY()"
            }
            else // Update
            {
                qry1 = "UPDATE tblMain SET status = @status, total = @total, received = @received, change = @change WHERE mainID = @ID";
            }

            SQLiteCommand cmd = new SQLiteCommand(qry1, DataBaseOperations.DataBaseConnection.con);
            cmd.Parameters.AddWithValue("@ID",MainID);
            cmd.Parameters.AddWithValue("@aDate",DateTime.Now.Date);
            cmd.Parameters.AddWithValue("@time",DateTime.Now.ToLongTimeString());
            cmd.Parameters.AddWithValue("@tableName",tableLabel.Text);
            cmd.Parameters.AddWithValue("@waiterName",waiterLabel.Text);
            cmd.Parameters.AddWithValue("@status","Pending");
            cmd.Parameters.AddWithValue("@orderType",OrderType);
            cmd.Parameters.AddWithValue("@total",Convert.ToDouble(totalLabel.Text)); // as we only saving data for kitchen value will update when payment received
            cmd.Parameters.AddWithValue("@received", Convert.ToDouble(0));
            cmd.Parameters.AddWithValue("@change", Convert.ToDouble(0));

            if (DataBaseOperations.DataBaseConnection.con.State == ConnectionState.Closed)
                DataBaseOperations.DataBaseConnection.con.Open();

            if(MainID == 0) MainID = Convert.ToInt32(cmd.ExecuteScalar());
            else cmd.ExecuteNonQuery();

            if (DataBaseOperations.DataBaseConnection.con.State == ConnectionState.Open)
                DataBaseOperations.DataBaseConnection.con.Close();

            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                detailID = Convert.ToInt32(row.Cells["dgvid"].Value);

                /*
                    "detailID"	INTEGER,
	                "mainID"	INTEGER,
	                "productID"	INTEGER,
	                "qty"	INTEGER,
	                "price"	REAL,
	                "amount"	REAL,
                */

                if (detailID == 0) // Insert
                {
                    qry2 = @"INSERT INTO tblDetails (detailID, mainID, productID, qty, price, amount) 
                            VALUES (@detailID, @mainID, @productID, @qty, @price, @amount)"; 
                }
                else // Update
                {
                    qry2 = @"UPDATE tblDetails SET productID = @productID, qty = @qty, price = @price, amount = @amount WHERE detailID = @ID";
                }


                SQLiteCommand cmd2 = new SQLiteCommand(qry2, DataBaseOperations.DataBaseConnection.con);
                cmd2.Parameters.AddWithValue("@ID", detailID);
                cmd2.Parameters.AddWithValue("@mainID", MainID);
                cmd2.Parameters.AddWithValue("@productID", row.Cells["dgvProID"]);
                cmd2.Parameters.AddWithValue("@qty", row.Cells["dgvQty"]);
                cmd2.Parameters.AddWithValue("@price", row.Cells["dgvPrice"]);
                cmd2.Parameters.AddWithValue("@amount", row.Cells["dgvAmount"]);

                if (DataBaseOperations.DataBaseConnection.con.State == ConnectionState.Closed)
                    DataBaseOperations.DataBaseConnection.con.Open();

                cmd2.ExecuteNonQuery();

                if (DataBaseOperations.DataBaseConnection.con.State == ConnectionState.Open)
                    DataBaseOperations.DataBaseConnection.con.Close();
            }

        }
    }
}
