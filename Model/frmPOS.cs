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
using POS_System.Model;

namespace POS_System.Model
{
    public partial class frmPOS : Form
    {
        public frmPOS()
        {
            InitializeComponent();
        }

        public int MainID = 0;
        public int driverID = 0;
        public string OrderType = "";
        public string customerName = "";
        public string customerPhone = "";
        public string customerAdress = "";
        public int selectedDriver = -1;

        private void closeBtn_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.Rows.Count > 0)
            {
                myMessageBox.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
                if (myMessageBox.Show("Are you sure you want to exit from the POS?") == DialogResult.Yes)
                    this.Close();
            } 
            else
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
                    btn.Size = new Size(170, 60);
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
            productPanel.Controls.Clear();
            LoadProducts($"SELECT * FROM products INNER JOIN category ON catID = categoryID WHERE catName = '{btn.Text}'");
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
                id = Convert.ToInt32(proID)
            };

            Invoke((MethodInvoker)delegate
            {
                productPanel.Controls.Add(w);
            });

            w.onSelect += (ss, ee) =>
            {
                var wdg = (ucProduct)ss;
                foreach (DataGridViewRow item in guna2DataGridView1.Rows)
                {
                    // this will check it product already there then a one to quantity and update price
                    if (Convert.ToInt32(item.Cells["dgvProID"].Value) == wdg.id)
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

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvdelete")
            {
                int qty = int.Parse(guna2DataGridView1.CurrentRow.Cells["dgvQty"].Value.ToString());
                int id = int.Parse(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value.ToString());
                if (qty > 1)
                {
                    guna2DataGridView1.CurrentRow.Cells["dgvQty"].Value = --qty;
                    guna2DataGridView1.CurrentRow.Cells["dgvAmount"].Value = qty * double.Parse(guna2DataGridView1.CurrentRow.Cells["dgvPrice"].Value.ToString());
                    if (editBtn.Visible && id > 0)
                        detailTableDataOp(id, guna2DataGridView1.CurrentRow);
                }
                else
                {
                    guna2DataGridView1.Rows.RemoveAt(guna2DataGridView1.CurrentRow.Index);
                    if (editBtn.Visible && id > 0)
                    {
                        string qry = $"DELETE FROM tblDetails WHERE detailID = '{id}'";
                        Hashtable ht = new Hashtable();
                        DataBaseOperations.CRUDOperations.SQL(qry, ht);
                    }
                }
                GetTotal();
            }
        }
        
        private void editBtn_Click(object sender, EventArgs e)
        {
            if (!guna2DataGridView1.Columns["dgvdelete"].Visible)
            {
                myMessageBox.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
                if (myMessageBox.Show("Are you sure you want to change 'this table is edited' statement?") == DialogResult.Yes)
                {
                    guna2DataGridView1.Columns["dgvdelete"].Visible = true;
                    string qry = "UPDATE tblMain SET isEditted = @isEditted WHERE mainID = @ID";
                    SQLiteCommand cmd = new SQLiteCommand(qry, DataBaseOperations.DataBaseConnection.con);
                    cmd.Parameters.AddWithValue("@ID", this.id);
                    cmd.Parameters.AddWithValue("@isEditted", "Yes");
                    if (DataBaseOperations.DataBaseConnection.con.State == ConnectionState.Closed)
                        DataBaseOperations.DataBaseConnection.con.Open();

                    cmd.ExecuteNonQuery();

                    if (DataBaseOperations.DataBaseConnection.con.State == ConnectionState.Open)
                        DataBaseOperations.DataBaseConnection.con.Close();
                }
            }
            else
                guna2DataGridView1.Columns["dgvdelete"].Visible = false;
        }

        // Getting product from database
        private void LoadProducts(string qry = "SELECT * FROM products INNER JOIN category ON catID = categoryID")
        {
            frmLoading loading = null;
            Thread t = new Thread(() =>
            {
                loading = new frmLoading();
                AddBlurToForm.BlurBackground(loading);
            });
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            Thread thread = new Thread(() =>
            {
                try
                {
                    SQLiteCommand cmd = new SQLiteCommand(qry, DataBaseOperations.DataBaseConnection.con);
                    SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    foreach (DataRow item in dt.Rows)
                    {
                        Byte[] imageArray = (byte[])item["pImage"];
                        AddItems("0", item["pID"].ToString(), item["pName"].ToString(), item["catName"].ToString(), item["pPrice"].ToString(), Image.FromStream(new MemoryStream(imageArray)));
                        loading.progressBar.Value += (int)Math.Ceiling(100.0/(double)dt.Rows.Count);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    loading.Close();
                }
            });
            thread.Start();
        }

        private void searchInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                productPanel.Controls.Clear();
                LoadProducts($"SELECT * FROM products INNER JOIN category ON catID = categoryID WHERE LOWER(pName) LIKE '%{searchInput.Text.Trim().ToLower()}%'");
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
            totalLabel.Text = "";
            foreach(DataGridViewRow item in guna2DataGridView1.Rows)
                total += double.Parse(item.Cells["dgvAmount"].Value.ToString());
            totalLabel.Text = total.ToString("N2");
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            // Reset to the POS screen
            guna2DataGridView1.Columns["dgvdelete"].Visible = true;
            editBtn.Visible = false;
            tableLabel.Text = "";
            waiterLabel.Text = "";
            driverLabel.Text = "";
            tableLabel.Visible = false;
            waiterLabel.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label6.Visible = false;
            driverLabel.Visible = false;
            guna2DataGridView1.Rows.Clear();
            MainID = 0;
            totalLabel.Text = "0.00";
            OrderType = "";
            dineInBtn.Checked = false;
            takeAwayBtn.Checked = false;
            deliveryBtn.Checked = false;
        }
        private void UpdateToOrderTypeFromDataBase(string orderType)
        {
            if (orderType == "Dine In" || orderType == "Take Away" || orderType == "Delivery")
            {
                string qry = "UPDATE tblMain SET orderType = @orderType WHERE mainID = @ID";
                SQLiteCommand cmd = new SQLiteCommand(qry, DataBaseOperations.DataBaseConnection.con);
                cmd.Parameters.AddWithValue("@ID", MainID);
                cmd.Parameters.AddWithValue("@orderType", orderType);

                if (DataBaseOperations.DataBaseConnection.con.State == ConnectionState.Closed)
                    DataBaseOperations.DataBaseConnection.con.Open();

                cmd.ExecuteNonQuery();

                if (DataBaseOperations.DataBaseConnection.con.State == ConnectionState.Open)
                    DataBaseOperations.DataBaseConnection.con.Close();
            }
            else
                myMessageBox.Show("Order Type can not equal " + orderType + ".");
        }

        private void UpdateCustomDatas(int mainId, int driverID, string customerName, string customerPhone, string customerAdress)
        {
            string qry = "UPDATE tblMain SET driverID = @driverID, customerName = @customerName, customerPhone = @customerPhone, customerAdress = @customerAdress WHERE mainID = @ID";
            SQLiteCommand cmd = new SQLiteCommand(qry, DataBaseOperations.DataBaseConnection.con);
            cmd.Parameters.AddWithValue("@ID", MainID);
            cmd.Parameters.AddWithValue("@driverID", driverID);
            cmd.Parameters.AddWithValue("@customerName", customerName);
            cmd.Parameters.AddWithValue("@customerPhone", customerPhone);
            cmd.Parameters.AddWithValue("@customerAdress", customerAdress);

            if (DataBaseOperations.DataBaseConnection.con.State == ConnectionState.Closed)
                DataBaseOperations.DataBaseConnection.con.Open();

            cmd.ExecuteNonQuery();

            if (DataBaseOperations.DataBaseConnection.con.State == ConnectionState.Open)
                DataBaseOperations.DataBaseConnection.con.Close();
        }

        private void LoadCustomerDatas(object sender, EventArgs e)
        {
            frmAddCustomer frm = sender as frmAddCustomer;

            if(MainID > 0)
            {
                string qry = $"SELECT * FROM tblMain m INNER JOIN staff s ON m.driverID = s.staffID WHERE mainID = '{MainID}'";
                SQLiteCommand cmd = new SQLiteCommand(qry, DataBaseOperations.DataBaseConnection.con);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    frm.nameInput.Text = dt.Rows[0]["customerName"].ToString();
                    frm.phoneInput.Text = dt.Rows[0]["customerPhone"].ToString();
                    frm.adressInput.Text = dt.Rows[0]["customerAdress"].ToString();
                    frm.driverComboBox.Text = dt.Rows[0]["sName"].ToString();
                }
            }
            else
            {
                if (frm != null && customerName != "" && customerPhone != "" && customerAdress != "" && selectedDriver != -1 && selectedDriver < frm.driverComboBox.Items.Count)
                {
                    frm.nameInput.Text = customerName;
                    frm.phoneInput.Text = customerPhone;
                    frm.adressInput.Text = customerAdress;
                    frm.driverComboBox.SelectedIndex = selectedDriver;
                }
            }
            
        }
        private void deliveryBtn_Click(object sender, EventArgs e)
        {
            if (OrderType == "Take Away" || OrderType == "Dine In")
            {
                deliveryBtn.Checked = false;
                if (OrderType == "Take Away")
                    takeAwayBtn.Checked = true;
                else if (OrderType == "Dine In")
                    dineInBtn.Checked = true;

                myMessageBox.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
                if (myMessageBox.Show("Are you sure you want to change order type?") == DialogResult.No) return;
            }

            if (guna2DataGridView1.Rows.Count > 0)
            {
                UpdateToOrderTypeFromDataBase("Delivery");
                changeTableAndWaiterNameFromDataBase("", "");
                deliveryBtn.Checked = true;
                tableLabel.Text = "";
                waiterLabel.Text = "";
                tableLabel.Visible = false;
                waiterLabel.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                OrderType = "Delivery";
                label6.Visible = true;
                driverLabel.Visible = true;

                frmAddCustomer frm = new frmAddCustomer();
                frm.MainID = MainID;
                frm.orderType = OrderType;

                frm.Load += LoadCustomerDatas;

                AddBlurToForm.BlurBackground(frm);

                if (frm.driverID > 0)
                {
                    driverID = frm.driverID;
                    customerName = frm.nameInput.Text;
                    customerPhone = frm.phoneInput.Text;
                    customerAdress = frm.adressInput.Text;
                    selectedDriver = frm.driverComboBox.SelectedIndex;
                    
                    driverLabel.Text = frm.driverComboBox.Text + " will delivery to " + customerName + " (" + customerPhone + ")";
                }

                if (MainID > 0 && customerName != "" && customerPhone != "" && customerAdress != "" && selectedDriver != -1)
                { // Update
                    UpdateCustomDatas(MainID, driverID, customerName, customerPhone, customerAdress);
                }
            }
            else
            {
                myWarningMessageBox.Show("You didn't select any product.");
                deliveryBtn.Checked = false;
            }
        }

        private void takeAwayBtn_Click(object sender, EventArgs e)
        {
            if (OrderType == "Delivery" || OrderType == "Dine In")
            {
                deliveryBtn.Checked = false;
                if (OrderType == "Delivery")
                    deliveryBtn.Checked = true;
                else if (OrderType == "Dine In")
                    dineInBtn.Checked = true;

                myMessageBox.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
                if (myMessageBox.Show("Are you sure you want to change order type?") == DialogResult.No) return;
            }

            if (guna2DataGridView1.Rows.Count > 0)
            {
                UpdateToOrderTypeFromDataBase("Take Away");
                takeAwayBtn.Checked = true;
                tableLabel.Text = "";
                waiterLabel.Text = "";
                tableLabel.Visible = false;
                waiterLabel.Visible = false;
                driverLabel.Text = "";
                label3.Visible = false;
                label4.Visible = false;
                label6.Visible = false;
                OrderType = "Take Away";
                UpdateCustomDatas(0, -1, "", "", "");
                changeTableAndWaiterNameFromDataBase("", "");
            }
            else
            {
                myWarningMessageBox.Show("You didn't select any product.");
                takeAwayBtn.Checked = false;
            }
        }

        private void changeTableAndWaiterNameFromDataBase(string table, string waiter)
        {
            string qry = "UPDATE tblMain SET tableName = @tableName, waiterName = @waiterName WHERE mainID = @ID";
            SQLiteCommand cmd = new SQLiteCommand(qry, DataBaseOperations.DataBaseConnection.con);
            cmd.Parameters.AddWithValue("@ID", MainID);
            cmd.Parameters.AddWithValue("@tableName", table);
            cmd.Parameters.AddWithValue("@waiterName", waiter);

            if (DataBaseOperations.DataBaseConnection.con.State == ConnectionState.Closed)
                DataBaseOperations.DataBaseConnection.con.Open();

            cmd.ExecuteNonQuery();

            if (DataBaseOperations.DataBaseConnection.con.State == ConnectionState.Open)
                DataBaseOperations.DataBaseConnection.con.Close();
        }
        private void dineInBtn_Click(object sender, EventArgs e)
        {
            if(OrderType == "Delivery" || OrderType == "Take Away")
            {
                deliveryBtn.Checked = false;
                if(OrderType == "Delivery")
                    deliveryBtn.Checked = true;
                else if (OrderType == "Take Away")
                    takeAwayBtn.Checked = true;

                myMessageBox.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
                if (myMessageBox.Show("Are you sure you want to change order type?") == DialogResult.No) return;
            }

            if (guna2DataGridView1.Rows.Count > 0)
            {
                UpdateToOrderTypeFromDataBase("Dine In");
                dineInBtn.Checked = true;
                OrderType = "Dine In";
                UpdateCustomDatas(0, -1, "", "", "");
                label6.Visible = false;
                driverLabel.Visible = false;

                frmTableSelect frm = new frmTableSelect();
                AddBlurToForm.BlurBackground(frm);

                frmWaiterSelect frm2 = new frmWaiterSelect();
                AddBlurToForm.BlurBackground(frm2);

                if (frm.TableName != "" && frm2.waiterName != "")
                {
                    tableLabel.Text = frm.TableName;
                    tableLabel.Visible = true;
                    label3.Visible = true;
                    waiterLabel.Text = frm2.waiterName;
                    waiterLabel.Visible = true;
                    label4.Visible = true;
                    changeTableAndWaiterNameFromDataBase(tableLabel.Text, waiterLabel.Text);
                }
                else
                {
                    OrderType = "";
                    tableLabel.Text = "";
                    tableLabel.Visible = false;
                    label3.Visible = false;
                    waiterLabel.Text = "";
                    waiterLabel.Visible = false;
                    label4.Visible = false;
                    dineInBtn.Checked = false;
                }
            }
            else
            {
                myWarningMessageBox.Show("You didn't select any product.");
                dineInBtn.Checked = false;
            }
        }
        private void mainTalbeDataOP(string status)
        {
            string qry = "";
            if (MainID == 0) // Insert
            {
                qry = @"INSERT INTO tblMain (date, time, tableName, waiterName, status, orderType, paymentMethod, total, received, change, driverID, customerName, customerPhone, customerAdress) 
                            VALUES (@date, @time, @tableName, @waiterName, @status, @orderType, @paymentMethod, @total, @received, @change, @driverID, @customerName, @customerPhone, @customerAdress); 
                            SELECT last_insert_rowid()";
                // this line will get recent add id value -> "SELECT last_insert_rowid()"
            }
            else // Update
            {
                qry = "UPDATE tblMain SET status = @status, total = @total, received = @received, change = @change, driverID = @driverID, customerName = @customerName, customerPhone = @customerPhone, customerAdress = @customerAdress WHERE mainID = @ID";
            }

            SQLiteCommand cmd = new SQLiteCommand(qry, DataBaseOperations.DataBaseConnection.con);
            cmd.Parameters.AddWithValue("@ID", MainID);
            cmd.Parameters.AddWithValue("@date", DateTime.Now.Date.ToString("dd.MM.yyyy"));
            cmd.Parameters.AddWithValue("@time", DateTime.Now.ToShortTimeString());
            cmd.Parameters.AddWithValue("@tableName", tableLabel.Text);
            cmd.Parameters.AddWithValue("@waiterName", waiterLabel.Text);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@orderType", OrderType);
            cmd.Parameters.AddWithValue("@total", Convert.ToDouble(totalLabel.Text));
            cmd.Parameters.AddWithValue("@driverID", driverID);
            cmd.Parameters.AddWithValue("@customerName", customerName);
            cmd.Parameters.AddWithValue("@customerPhone", customerPhone);
            cmd.Parameters.AddWithValue("@customerAdress", customerAdress);
            cmd.Parameters.AddWithValue("@received", Convert.ToDouble(0)); // as we only saving data for kitchen value will update when payment received
            cmd.Parameters.AddWithValue("@change", Convert.ToDouble(0));
            cmd.Parameters.AddWithValue("@paymentMethod", "didn't paid");

            if (DataBaseOperations.DataBaseConnection.con.State == ConnectionState.Closed)
                DataBaseOperations.DataBaseConnection.con.Open();

            if (MainID == 0) MainID = Convert.ToInt32(cmd.ExecuteScalar());
            else cmd.ExecuteNonQuery();

            if (DataBaseOperations.DataBaseConnection.con.State == ConnectionState.Open)
                DataBaseOperations.DataBaseConnection.con.Close();
        }

        private void detailTableDataOp(int detailID, DataGridViewRow row)
        {
            string qry = "";
            detailID = Convert.ToInt32(row.Cells["dgvid"].Value);

            if (detailID == 0) // Insert
            {
                qry = @"INSERT INTO tblDetails (mainID, productID, productName, qty, price, amount) 
                            VALUES (@mainID, @productID, @productName, @qty, @price, @amount)";
            }
            else // Update
            {
                qry = @"UPDATE tblDetails SET productID = @productID, productName = @productName, qty = @qty, price = @price, amount = @amount WHERE detailID = @ID";
            }

            SQLiteCommand cmd2 = new SQLiteCommand(qry, DataBaseOperations.DataBaseConnection.con);
            cmd2.Parameters.AddWithValue("@ID", detailID);
            cmd2.Parameters.AddWithValue("@mainID", MainID);
            cmd2.Parameters.AddWithValue("@productID", Convert.ToInt32(row.Cells["dgvProID"].Value));
            cmd2.Parameters.AddWithValue("@productName", row.Cells["dgvName"].Value.ToString());
            cmd2.Parameters.AddWithValue("@qty", Convert.ToInt32(row.Cells["dgvQty"].Value));
            cmd2.Parameters.AddWithValue("@price", Convert.ToDouble(row.Cells["dgvPrice"].Value));
            cmd2.Parameters.AddWithValue("@amount", Convert.ToDouble(row.Cells["dgvAmount"].Value));

            if (DataBaseOperations.DataBaseConnection.con.State == ConnectionState.Closed)
                DataBaseOperations.DataBaseConnection.con.Open();

            cmd2.ExecuteNonQuery();

            if (DataBaseOperations.DataBaseConnection.con.State == ConnectionState.Open)
                DataBaseOperations.DataBaseConnection.con.Close();
        }
        private void KOTBtn_Click(object sender, EventArgs e)
        {
            if (OrderType != "")
            {
                // Save the datas in database

                int detailID = 0;

                // for main table
                mainTalbeDataOP("Pending");

                // for detail table
                foreach (DataGridViewRow row in guna2DataGridView1.Rows)
                detailTableDataOp(detailID, row);

                // Reset to the POS screen
                myMessageBox.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                myMessageBox.Show("Saved Successfully");
                MainID = 0;
                detailID = 0;
                guna2DataGridView1.Rows.Clear();
                tableLabel.Text = "";
                waiterLabel.Text = "";
                driverLabel.Text = "";
                tableLabel.Visible = false;
                waiterLabel.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label6.Visible = false;
                driverLabel.Visible = false;
                totalLabel.Text = "0.00";
                OrderType = "";
                dineInBtn.Checked = false;
                takeAwayBtn.Checked = false;
                deliveryBtn.Checked = false;
            }
            else
                myWarningMessageBox.Show("Please select an order type");
        }

        public int id = 0;
        private void billListBtn_Click(object sender, EventArgs e)
        {
            frmBillList frm = new frmBillList();
            AddBlurToForm.BlurBackground(frm);
            
            if (frm.MainID > 0) 
            {
                id = frm.MainID;
                MainID = frm.MainID;
                guna2DataGridView1.Columns["dgvdelete"].Visible = false;
                editBtn.Visible = true;
                LoadEntries();
            }
        }

        private void LoadEntries()
        {
            string qry = @"SELECT * FROM tblMain m
                          INNER JOIN tblDetails d ON m.mainID = d.mainID
                          LEFT JOIN staff s ON s.staffID = m.driverID AND m.driverID <> 0
                          WHERE m.mainID = " + id + "";

            SQLiteCommand cmd = new SQLiteCommand(qry, DataBaseOperations.DataBaseConnection.con);
            DataTable dt = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            da.Fill(dt);
            if (dt != null && dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["orderType"].ToString() == "Delivery")
                {
                    OrderType = "Delivery";
                    deliveryBtn.Checked = true;
                    label6.Visible = true;
                    label3.Visible = false;
                    label4.Visible = false;
                    driverLabel.Text = dt.Rows[0]["sName"].ToString() + " will delivery to " + dt.Rows[0]["customerName"].ToString() + " (" + dt.Rows[0]["customerPhone"].ToString() + ")";
                    driverLabel.Visible = true;
                    waiterLabel.Visible = false;
                    tableLabel.Visible = false;
                    waiterLabel.Text = "";
                    tableLabel.Text = "";
                }
                else if(dt.Rows[0]["orderType"].ToString() == "Take Away")
                {
                    OrderType = "Take Away";
                    takeAwayBtn.Checked = true;
                    waiterLabel.Visible = false;
                    tableLabel.Visible = false;
                    driverLabel.Visible = false;
                    waiterLabel.Text = "";
                    tableLabel.Text = "";
                    driverLabel.Text = "";
                    label3.Visible = false;
                    label4.Visible = false;
                    label6.Visible = false;
                }
                else if (dt.Rows[0]["orderType"].ToString() == "Dine In")
                {
                    OrderType = "Dine In";
                    dineInBtn.Checked = true;
                    waiterLabel.Text = dt.Rows[0]["waiterName"].ToString();
                    waiterLabel.Visible = true;
                    tableLabel.Text = dt.Rows[0]["tableName"].ToString();
                    tableLabel.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label6.Visible = false;
                    driverLabel.Visible = false;
                    driverLabel.Text = "";
                }
            }

            guna2DataGridView1.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {
                string detailID = item["detailID"].ToString();
                string productName = item["productName"].ToString();
                string productID = item["productID"].ToString();
                string qty = item["qty"].ToString();
                string price = item["price"].ToString();
                string amount = item["amount"].ToString();
                
                object[] obj = {0, detailID, productID, productName, qty, price, amount};
                guna2DataGridView1.Rows.Add(obj);
            }
            GetTotal();
        }

        private void checkOutBtn_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.Rows.Count == 0)
            {
                myWarningMessageBox.Show("You didn't select any product.");
                return;
            }

            if (OrderType == "")
            {
                myWarningMessageBox.Show("Please select an order type");
                return;
            }

            if(MainID == 0)
            {
                myWarningMessageBox.Show("Please click the KOT btn.");
                return;
            }

            if (DataBaseOperations.DataBaseConnection.con.State == ConnectionState.Closed)
                DataBaseOperations.DataBaseConnection.con.Open();

            string qry = "SELECT status FROM tblMain WHERE mainID = " + MainID;
            SQLiteCommand cmd = new SQLiteCommand(qry,DataBaseOperations.DataBaseConnection.con);
            string status = cmd.ExecuteScalar().ToString();
            DataBaseOperations.DataBaseConnection.con.Close();

            if (DataBaseOperations.DataBaseConnection.con.State == ConnectionState.Open)
                DataBaseOperations.DataBaseConnection.con.Close();

            if (status != "Complete")
            {
                myWarningMessageBox.Show("Wait for selected items to be completed before paying.");
                return;
            }

            frmCheckOut frm = new frmCheckOut();
            frm.MainID = id;
            frm.amount = Convert.ToDouble(totalLabel.Text);
            AddBlurToForm.BlurBackground(frm);

            // Reset to the POS screen  
            MainID = 0;
            guna2DataGridView1.Rows.Clear();
            tableLabel.Text = "";
            waiterLabel.Text = "";
            driverLabel.Text = "";
            tableLabel.Visible = false;
            waiterLabel.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label6.Visible = false;
            driverLabel.Visible = false;
            totalLabel.Text = "0.00";
            OrderType = "";
            dineInBtn.Checked = false;
            takeAwayBtn.Checked = false;
            deliveryBtn.Checked = false;
        }

        private void holdBtn_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.Rows.Count == 0)
            {
                myWarningMessageBox.Show("You didn't select any product.");
                return;
            }

            // Save the datas in database

            int detailID = 0;

                // for mainTable
                mainTalbeDataOP("Hold");

                // for detailTable
                foreach (DataGridViewRow row in guna2DataGridView1.Rows)
                    detailTableDataOp(detailID, row);

                // Reset to the POS screen
                myMessageBox.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                myMessageBox.Show("Saved Successfully");
                MainID = 0;
                detailID = 0;
                guna2DataGridView1.Rows.Clear();
                tableLabel.Text = "";
                waiterLabel.Text = "";
                driverLabel.Text = "";
                tableLabel.Visible = false;
                waiterLabel.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label6.Visible = false;
                driverLabel.Visible = false;
                totalLabel.Text = "0.00";
                OrderType = "";
                dineInBtn.Checked = false;
                takeAwayBtn.Checked = false;
                deliveryBtn.Checked = false;
        }
    }
}
