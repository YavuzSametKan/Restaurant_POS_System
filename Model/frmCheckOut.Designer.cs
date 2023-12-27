namespace POS_System.Model
{
    partial class frmCheckOut
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.billAmountInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.paymentReceivedInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.changeInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.paymentMethodCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.Size = new System.Drawing.Size(126, 32);
            this.headerLabel.Text = "Check Out";
            // 
            // saveBtn
            // 
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.Location = new System.Drawing.Point(12, 0);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::POS_System.Properties.Resources.bills_w;
            // 
            // closeBtn
            // 
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.Location = new System.Drawing.Point(167, 0);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 384);
            this.panel1.Size = new System.Drawing.Size(753, 82);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(723, -1);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(30, 29);
            this.guna2ControlBox1.TabIndex = 3;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // billAmountInput
            // 
            this.billAmountInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.billAmountInput.DefaultText = "";
            this.billAmountInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.billAmountInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.billAmountInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.billAmountInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.billAmountInput.Enabled = false;
            this.billAmountInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.billAmountInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.billAmountInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.billAmountInput.Location = new System.Drawing.Point(38, 182);
            this.billAmountInput.Name = "billAmountInput";
            this.billAmountInput.PasswordChar = '\0';
            this.billAmountInput.PlaceholderText = "Bill Amount";
            this.billAmountInput.SelectedText = "";
            this.billAmountInput.Size = new System.Drawing.Size(313, 50);
            this.billAmountInput.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Bill Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Payment Received";
            // 
            // paymentReceivedInput
            // 
            this.paymentReceivedInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.paymentReceivedInput.DefaultText = "";
            this.paymentReceivedInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.paymentReceivedInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.paymentReceivedInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.paymentReceivedInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.paymentReceivedInput.Enabled = false;
            this.paymentReceivedInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.paymentReceivedInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.paymentReceivedInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.paymentReceivedInput.Location = new System.Drawing.Point(397, 285);
            this.paymentReceivedInput.Name = "paymentReceivedInput";
            this.paymentReceivedInput.PasswordChar = '\0';
            this.paymentReceivedInput.PlaceholderText = "Payment Received";
            this.paymentReceivedInput.SelectedText = "";
            this.paymentReceivedInput.Size = new System.Drawing.Size(313, 50);
            this.paymentReceivedInput.TabIndex = 6;
            this.paymentReceivedInput.TextChanged += new System.EventHandler(this.paymentReceivedInput_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Change";
            // 
            // changeInput
            // 
            this.changeInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.changeInput.DefaultText = "";
            this.changeInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.changeInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.changeInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.changeInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.changeInput.Enabled = false;
            this.changeInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.changeInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.changeInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.changeInput.Location = new System.Drawing.Point(38, 285);
            this.changeInput.Name = "changeInput";
            this.changeInput.PasswordChar = '\0';
            this.changeInput.PlaceholderText = "Change";
            this.changeInput.SelectedText = "";
            this.changeInput.Size = new System.Drawing.Size(313, 50);
            this.changeInput.TabIndex = 6;
            // 
            // paymentMethodCB
            // 
            this.paymentMethodCB.BackColor = System.Drawing.Color.Transparent;
            this.paymentMethodCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.paymentMethodCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paymentMethodCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.paymentMethodCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.paymentMethodCB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.paymentMethodCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.paymentMethodCB.ItemHeight = 44;
            this.paymentMethodCB.Items.AddRange(new object[] {
            "Credit Card",
            "Cash"});
            this.paymentMethodCB.Location = new System.Drawing.Point(397, 182);
            this.paymentMethodCB.Name = "paymentMethodCB";
            this.paymentMethodCB.Size = new System.Drawing.Size(313, 50);
            this.paymentMethodCB.TabIndex = 8;
            this.paymentMethodCB.SelectedIndexChanged += new System.EventHandler(this.roleComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(392, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Payment Method";
            // 
            // frmCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 466);
            this.Controls.Add(this.paymentMethodCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.changeInput);
            this.Controls.Add(this.paymentReceivedInput);
            this.Controls.Add(this.billAmountInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2ControlBox1);
            this.Name = "frmCheckOut";
            this.Text = "frmCheckOut";
            this.Load += new System.EventHandler(this.frmCheckOut_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.guna2ControlBox1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.billAmountInput, 0);
            this.Controls.SetChildIndex(this.paymentReceivedInput, 0);
            this.Controls.SetChildIndex(this.changeInput, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.paymentMethodCB, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        public Guna.UI2.WinForms.Guna2TextBox billAmountInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public Guna.UI2.WinForms.Guna2TextBox paymentReceivedInput;
        private System.Windows.Forms.Label label3;
        public Guna.UI2.WinForms.Guna2TextBox changeInput;
        public Guna.UI2.WinForms.Guna2ComboBox paymentMethodCB;
        private System.Windows.Forms.Label label4;
    }
}