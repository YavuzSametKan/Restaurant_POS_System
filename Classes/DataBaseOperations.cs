using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Text.RegularExpressions;
using System.Collections;
using System.Windows.Forms;
using System.Drawing;

namespace POS_System.Classes
{
    public class DataBaseOperations
    {
        public class DataBaseConnection
        {
            private readonly static string dataBaseName = "POS_System.db";
            private readonly static string dbConnectSqlCommand = $"Data source=.\\{dataBaseName};Version=3";
            public static SQLiteConnection con = new SQLiteConnection(dbConnectSqlCommand);
        }

        public class CRUDOperations{
            
            public static int SQL(string qry, Hashtable ht)
            {
                var con = DataBaseConnection.con;
                int res = 0;

                try
                {
                    SQLiteCommand cmd = new SQLiteCommand(qry,con);
                    cmd.CommandType = CommandType.Text;

                    foreach (DictionaryEntry item in ht)
                    {
                        cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                    }
                    if(con.State == ConnectionState.Closed) con.Open();

                    res = cmd.ExecuteNonQuery();

                    if (con.State == ConnectionState.Open) con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    con.Close();
                }
                return res;
            }

            // for loading data from database
            public static void LoadData(string qry, DataGridView gv, ListBox lb)
            {
                var con = DataBaseConnection.con;

                gv.CellFormatting += new DataGridViewCellFormattingEventHandler(gv_CellFormatting);
                try
                {
                    SQLiteCommand cmd = new SQLiteCommand(qry, con);
                    cmd.CommandType = CommandType.Text;
                    SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    for(int i = 0; i < lb.Items.Count; i++)
                    {
                        string colName = ((DataGridViewColumn)lb.Items[i]).Name;
                        gv.Columns[colName].DataPropertyName = dt.Columns[i].ToString();
                    }

                    gv.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    con.Close();
                }
            }

            private static void gv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
            {
                Guna.UI2.WinForms.Guna2DataGridView gv = (Guna.UI2.WinForms.Guna2DataGridView)sender;
                int count = 0;

                foreach(DataGridViewRow row in gv.Rows)
                {
                    count++;
                    row.Cells[0].Value = count;
                }
            }

            // for Combo box fill
            public static void CBFill(string qry, ComboBox cb)
            {
                var con = DataBaseConnection.con;
                SQLiteCommand cmd = new SQLiteCommand(qry, con);
                cmd.CommandType = CommandType.Text;
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cb.DisplayMember = "name";
                cb.ValueMember = "id";
                cb.DataSource = dt;
                cb.SelectedIndex = -1;
            }
        }


        public class UserDatasOperations
        {
            private static bool GeneralValidationDatas(string qry,SQLiteConnection con)
            {
                bool IsValid = false;
                SQLiteCommand cmd = new SQLiteCommand(qry, con);
                DataTable dt = new DataTable();
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                da.Fill(dt);

                if (dt.Rows.Count > 0)IsValid = true;

                return IsValid;
            }

            public static bool IsValidUser(string username, string password)
            {
                var con = DataBaseConnection.con;
                string qry = $"SELECT * FROM users WHERE userName = '{username}' AND password = '{password}'";
                return GeneralValidationDatas(qry, con);
            }

            public static bool IsValidUserName(string username)
            {
                var con = DataBaseConnection.con;
                string qry = $"SELECT * FROM users WHERE userName = '{username}'";
                return GeneralValidationDatas(qry, con);
            }

            public static bool IsValidAnEmail(string email)
            {
                var trimmedEmail = email.Trim();

                if (trimmedEmail.EndsWith("."))
                {
                    return false;
                }
                try
                {
                    var addr = new System.Net.Mail.MailAddress(email);
                    return addr.Address == trimmedEmail;
                }
                catch
                {
                    return false;
                }
            }
            // @overload IsValidUser()
            
            public static string IsValidUser(string email)
            {
                // this method returnable 3 values. ("valid", "invalid", "notAnEmail")

                if (IsValidAnEmail(email))
                {
                    var con = DataBaseConnection.con;
                    string qry = $"SELECT * FROM users WHERE email = '{email}'";
                    return (GeneralValidationDatas(qry, con)) ? "valid" : "invalid";
                }
                else
                    return "notAnEmail";
            }

            public static bool passwordSecurityCheck(string password)
            {
                if (password.Length < 8) return false;

                // Does the password contain at least one number?
                if (!Regex.IsMatch(password, @"\d")) return false;

                //Does the password contain at least one special character?
                if (!Regex.IsMatch(password, @"[!@#$%^&*()]")) return false;

                //Does the password contain at least one upper character?
                if (!Regex.IsMatch(password, @"[A-Z]")) return false;

                return true;
            }

            public static bool setPasswordToDB(string password, string email)
            {
                if (passwordSecurityCheck(password))
                {
                    var con = DataBaseConnection.con;
                    con.Open();
                    string qry = $"UPDATE users SET password = '{password}' WHERE email = '{email}'";
                    SQLiteCommand cmd = new SQLiteCommand(qry, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
        }
    }
}
