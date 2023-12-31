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
                billAmountInput.Text = amount.ToString();
                paymentReceivedInput.Text = amount.ToString();
                changeInput.Text = "0";
            }
            else if(paymentMethodCB.Text == "Cash")
            {
                paymentMethod = "Cash";
                paymentReceivedInput.Enabled = true;
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
                if (paymentReceivedInput.Text != "" && Convert.ToDouble(paymentReceivedInput.Text) >= amount)
                {
                    string qry = @"UPDATE tblMain SET paymentMethod = @paymentMethod, total = @total, received = @received, change = @change, status = 'Paid' WHERE mainID = @ID";

                    Hashtable ht = new Hashtable();
                    ht.Add("@paymentMethod", paymentMethod);
                    ht.Add("@total", Convert.ToDouble(billAmountInput.Text));
                    ht.Add("@received", Convert.ToDouble(paymentReceivedInput.Text));
                    ht.Add("@change", Convert.ToDouble(changeInput.Text));
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
            AddBlurToForm.BlurBackground(new frmBillList());
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            AddBlurToForm.BlurBackground(new frmBillList());
        }
    }
}
