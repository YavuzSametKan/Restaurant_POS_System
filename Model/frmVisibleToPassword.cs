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
using System.Data.SQLite;
using System.Threading;

namespace POS_System.Model
{
    public partial class frmVisibleToPassword : Form
    {
        private string code;
        private string email;
        public int id = 0;
        public frmVisibleToPassword(string code, string email)
        {
            this.email = email;
            this.code = code;
            InitializeComponent();
            AddRoundedStyleToForm.ApplyRoundedFormStyle(this);
        }

        private void frmVisibleToPassword_Load(object sender, EventArgs e)
        {
            messageLabel.Text += email;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (codeInput.Text.Trim() != code)
                myMessageBox.Show("the code is not correct!");
            else
            {
                confirmBtn.Visible = false;
                codeInput.Visible = false;
                label2.Visible = false;
                messageLabel.Visible = false;
                Label passwordlbl = new Label();
                passwordlbl.AutoSize = true;
                passwordlbl.Font = new Font("Segoe UI", 16, FontStyle.Italic);
                passwordlbl.ForeColor = Color.Gray;
                passwordlbl.TextAlign = ContentAlignment.MiddleCenter;
                passwordlbl.Location = new Point(64,136);
                passwordlbl.MaximumSize = new Size(350,0);
                passwordlbl.MaximumSize = new Size(350,0);

                string qry = "SELECT password FROM users WHERE id = " + id;
                SQLiteCommand cmd = new SQLiteCommand(qry,DataBaseOperations.DataBaseConnection.con);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                passwordlbl.Text = "password: "+dt.Rows[0]["password"].ToString();
                this.Controls.Add(passwordlbl);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
