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
        private int countDownSeconds = 120; // 2 minutes = 120 seconds
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
                messageLabel.Text = $"Closing Timer: {countDownSeconds / 60:D2}:{countDownSeconds % 60:D2}";
                codeInput.ReadOnly = true;
                label2.Text = "Your Password:";
                this.Size = new Size(486, 320);
                AddRoundedStyleToForm.ApplyRoundedFormStyle(this);

                string qry = "SELECT password FROM users WHERE id = " + id;
                SQLiteCommand cmd = new SQLiteCommand(qry,DataBaseOperations.DataBaseConnection.con);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                codeInput.Text = dt.Rows[0]["password"].ToString();
                timer.Start();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            countDownSeconds--;

            messageLabel.Text = $"Closing Timer: {countDownSeconds / 60:D2}:{countDownSeconds % 60:D2}";
            
            if (countDownSeconds <= 0)
            {
                timer.Stop();
                this.Close();
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void codeInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
