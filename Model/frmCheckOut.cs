using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS_System.Classes;

namespace POS_System.Model
{
    public partial class frmCheckOut : sampleAdd
    {
        public frmCheckOut()
        {
            InitializeComponent();
            AddRoundedStyleToForm.ApplyRoundedFormStyle(this);
        }

        public string paymentMethod = "";
        public double amount;
        public int MainID = 0;

        private void frmCheckOut_Load(object sender, EventArgs e)
        {
            billAmountInput.Text = amount.ToString();
        }

        private void roleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(paymentMethodCB.Text == "Credit Card")
            {
                paymentMethod = "Credit Card";
                paymentReceivedInput.Enabled = false;
                pennyInput.Enabled = false;
                billAmountInput.Text = amount.ToString();
                string[] priceParts = amount.ToString().Contains('.') ? amount.ToString().Split('.') : amount.ToString().Split(',');
                paymentReceivedInput.Text = priceParts[0];
                pennyInput.Text = priceParts.Length > 1 ? priceParts[1] : "";
                changeInput.Text = "0";
            }
            else if(paymentMethodCB.Text == "Cash")
            {
                paymentMethod = "Cash";
                paymentReceivedInput.Text = "";
                pennyInput.Text = "";
                paymentReceivedInput.Enabled = true;
                pennyInput.Enabled = true;
            }
        }

        private void paymentReceivedInput_TextChanged(object sender, EventArgs e)
        {
            double amount = 0, receipt = 0, change = 0;

            double.TryParse(billAmountInput.Text, out amount);
            double.TryParse(paymentReceivedInput.Text, out receipt);

            change = Math.Abs(amount - receipt); // convert positive or negative to always positive

            changeInput.Text = change.ToString();
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            if(paymentMethodCB.Text != "")
            {
                if (paymentReceivedInput.Text != "" && Convert.ToDouble(paymentReceivedInput.Text + "." + pennyInput.Text) >= amount)
                {
                    string qry = @"UPDATE tblMain SET paymentMethod = @paymentMethod, total = @total, received = @received, change = @change, status = 'Paid' WHERE mainID = @ID";

                    Hashtable ht = new Hashtable();
                    ht.Add("@paymentMethod", paymentMethod);
                    ht.Add("@total", Convert.ToDouble(billAmountInput.Text));
                    ht.Add("@received", paymentReceivedInput.Text + "." + pennyInput.Text);
                    ht.Add("@change", double.Parse(double.Parse(changeInput.Text).ToString("0.000")));
                    ht.Add("@ID", MainID);

                    if (DataBaseOperations.CRUDOperations.SQL(qry, ht) > 0)
                    {
                        myMessageBox.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                        myMessageBox.Show("Saved Successfully");
                        this.Close();
                        frmPOS frmPOSInstance = Application.OpenForms["frmPOS"] as frmPOS;
                        if (frmPOSInstance != null)
                            frmPOSInstance.editBtn.Visible = false;
                    }
                }
                else
                    myMessageBox.Show("Payment received must be greater than or equal to the amount!");
            }
            else
                myMessageBox.Show("Please Select a Payment Method.");
        }

        public override void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void paymentReceivedInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
