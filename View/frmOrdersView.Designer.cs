namespace POS_System.View
{
    partial class frmOrdersView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrdersView));
            this.toThisDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.fromThisDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.printButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.dgvSno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvWaiter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPaymentMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvReceived = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvChange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDriver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCustomerPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCustomerAdress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvIsEditted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvedit = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvPrint = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.addBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.addBtn.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.addBtn.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Normal;
            this.addBtn.Location = new System.Drawing.Point(4, 3);
            this.addBtn.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.addBtn.Size = new System.Drawing.Size(30, 36);
            this.addBtn.Visible = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(52, 45);
            this.label2.Size = new System.Drawing.Size(117, 32);
            this.label2.Text = "Order List";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(722, 18);
            // 
            // searchInput
            // 
            this.searchInput.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.searchInput.Location = new System.Drawing.Point(726, 45);
            this.searchInput.TextChanged += new System.EventHandler(this.searchInput_TextChanged_1);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(58, 95);
            this.guna2Separator1.Size = new System.Drawing.Size(1135, 10);
            // 
            // toThisDate
            // 
            this.toThisDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toThisDate.BorderRadius = 5;
            this.toThisDate.Checked = true;
            this.toThisDate.FillColor = System.Drawing.Color.White;
            this.toThisDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toThisDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.toThisDate.Location = new System.Drawing.Point(491, 45);
            this.toThisDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.toThisDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.toThisDate.Name = "toThisDate";
            this.toThisDate.Size = new System.Drawing.Size(200, 36);
            this.toThisDate.TabIndex = 7;
            this.toThisDate.Value = new System.DateTime(2023, 12, 28, 0, 41, 43, 275);
            this.toThisDate.ValueChanged += new System.EventHandler(this.toThisDate_ValueChanged);
            // 
            // fromThisDate
            // 
            this.fromThisDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fromThisDate.BorderRadius = 5;
            this.fromThisDate.Checked = true;
            this.fromThisDate.FillColor = System.Drawing.Color.White;
            this.fromThisDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fromThisDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.fromThisDate.Location = new System.Drawing.Point(259, 45);
            this.fromThisDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.fromThisDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.fromThisDate.Name = "fromThisDate";
            this.fromThisDate.Size = new System.Drawing.Size(200, 36);
            this.fromThisDate.TabIndex = 8;
            this.fromThisDate.Value = new System.DateTime(2023, 12, 28, 0, 41, 43, 275);
            this.fromThisDate.ValueChanged += new System.EventHandler(this.fromThisDate_ValueChanged);
            // 
            // printButton
            // 
            this.printButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.printButton.AutoRoundedCorners = true;
            this.printButton.BackColor = System.Drawing.Color.Transparent;
            this.printButton.BorderRadius = 22;
            this.printButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.printButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.printButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.printButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.printButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.printButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(184)))), ((int)(((byte)(39)))));
            this.printButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.printButton.ForeColor = System.Drawing.Color.White;
            this.printButton.Location = new System.Drawing.Point(1073, 35);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(120, 46);
            this.printButton.TabIndex = 9;
            this.printButton.Text = "Print";
            this.printButton.UseTransparentBackground = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(184)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(175)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 40;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSno,
            this.dgvOrder,
            this.dgvType,
            this.dgvProductName,
            this.dgvQty,
            this.dgvPrice,
            this.dgvAmount,
            this.dgvTable,
            this.dgvWaiter,
            this.dgvStatus,
            this.dgvPaymentMethod,
            this.dgvTotal,
            this.dgvReceived,
            this.dgvChange,
            this.dgvDriver,
            this.dgvCustomerName,
            this.dgvCustomerPhone,
            this.dgvCustomerAdress,
            this.dgvIsEditted,
            this.dgvDate,
            this.dgvTime,
            this.dgvedit,
            this.dgvPrint});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(58, 111);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowTemplate.Height = 40;
            this.guna2DataGridView1.Size = new System.Drawing.Size(1135, 460);
            this.guna2DataGridView1.TabIndex = 10;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(184)))), ((int)(((byte)(39)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 40;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 40;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Text = "Baskı önizleme";
            this.printPreviewDialog.Visible = false;
            // 
            // dgvSno
            // 
            this.dgvSno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvSno.FillWeight = 70F;
            this.dgvSno.HeaderText = "Sr#";
            this.dgvSno.MinimumWidth = 70;
            this.dgvSno.Name = "dgvSno";
            this.dgvSno.ReadOnly = true;
            this.dgvSno.Width = 70;
            // 
            // dgvOrder
            // 
            this.dgvOrder.HeaderText = "Order";
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.ReadOnly = true;
            // 
            // dgvType
            // 
            this.dgvType.HeaderText = "Order Type";
            this.dgvType.Name = "dgvType";
            this.dgvType.ReadOnly = true;
            // 
            // dgvProductName
            // 
            this.dgvProductName.HeaderText = "Product Name";
            this.dgvProductName.Name = "dgvProductName";
            this.dgvProductName.ReadOnly = true;
            // 
            // dgvQty
            // 
            this.dgvQty.HeaderText = "Qty";
            this.dgvQty.Name = "dgvQty";
            this.dgvQty.ReadOnly = true;
            // 
            // dgvPrice
            // 
            this.dgvPrice.HeaderText = "Price";
            this.dgvPrice.Name = "dgvPrice";
            this.dgvPrice.ReadOnly = true;
            // 
            // dgvAmount
            // 
            this.dgvAmount.HeaderText = "Amount";
            this.dgvAmount.Name = "dgvAmount";
            this.dgvAmount.ReadOnly = true;
            // 
            // dgvTable
            // 
            this.dgvTable.HeaderText = "Table";
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.ReadOnly = true;
            // 
            // dgvWaiter
            // 
            this.dgvWaiter.HeaderText = "Waiter";
            this.dgvWaiter.Name = "dgvWaiter";
            this.dgvWaiter.ReadOnly = true;
            // 
            // dgvStatus
            // 
            this.dgvStatus.HeaderText = "Status";
            this.dgvStatus.Name = "dgvStatus";
            this.dgvStatus.ReadOnly = true;
            // 
            // dgvPaymentMethod
            // 
            this.dgvPaymentMethod.HeaderText = "Payment Method";
            this.dgvPaymentMethod.Name = "dgvPaymentMethod";
            this.dgvPaymentMethod.ReadOnly = true;
            // 
            // dgvTotal
            // 
            this.dgvTotal.HeaderText = "Total";
            this.dgvTotal.Name = "dgvTotal";
            this.dgvTotal.ReadOnly = true;
            // 
            // dgvReceived
            // 
            this.dgvReceived.HeaderText = "Received";
            this.dgvReceived.Name = "dgvReceived";
            this.dgvReceived.ReadOnly = true;
            // 
            // dgvChange
            // 
            this.dgvChange.HeaderText = "Change";
            this.dgvChange.Name = "dgvChange";
            this.dgvChange.ReadOnly = true;
            // 
            // dgvDriver
            // 
            this.dgvDriver.HeaderText = "Driver Name";
            this.dgvDriver.Name = "dgvDriver";
            this.dgvDriver.ReadOnly = true;
            // 
            // dgvCustomerName
            // 
            this.dgvCustomerName.HeaderText = "Customer Name";
            this.dgvCustomerName.Name = "dgvCustomerName";
            this.dgvCustomerName.ReadOnly = true;
            // 
            // dgvCustomerPhone
            // 
            this.dgvCustomerPhone.HeaderText = "Customer Phone";
            this.dgvCustomerPhone.Name = "dgvCustomerPhone";
            this.dgvCustomerPhone.ReadOnly = true;
            // 
            // dgvCustomerAdress
            // 
            this.dgvCustomerAdress.HeaderText = "Customer Adress";
            this.dgvCustomerAdress.Name = "dgvCustomerAdress";
            this.dgvCustomerAdress.ReadOnly = true;
            // 
            // dgvIsEditted
            // 
            this.dgvIsEditted.HeaderText = "Is Order Editted";
            this.dgvIsEditted.Name = "dgvIsEditted";
            this.dgvIsEditted.ReadOnly = true;
            // 
            // dgvDate
            // 
            this.dgvDate.HeaderText = "Date";
            this.dgvDate.Name = "dgvDate";
            this.dgvDate.ReadOnly = true;
            // 
            // dgvTime
            // 
            this.dgvTime.HeaderText = "Time";
            this.dgvTime.Name = "dgvTime";
            this.dgvTime.ReadOnly = true;
            // 
            // dgvedit
            // 
            this.dgvedit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvedit.FillWeight = 50F;
            this.dgvedit.HeaderText = "";
            this.dgvedit.Image = global::POS_System.Properties.Resources.left_arrow;
            this.dgvedit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dgvedit.MinimumWidth = 50;
            this.dgvedit.Name = "dgvedit";
            this.dgvedit.ReadOnly = true;
            this.dgvedit.Visible = false;
            this.dgvedit.Width = 50;
            // 
            // dgvPrint
            // 
            this.dgvPrint.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvPrint.FillWeight = 50F;
            this.dgvPrint.HeaderText = "";
            this.dgvPrint.Image = global::POS_System.Properties.Resources.printer;
            this.dgvPrint.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dgvPrint.MinimumWidth = 50;
            this.dgvPrint.Name = "dgvPrint";
            this.dgvPrint.ReadOnly = true;
            this.dgvPrint.Visible = false;
            this.dgvPrint.Width = 50;
            // 
            // frmOrdersView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1260, 661);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.toThisDate);
            this.Controls.Add(this.fromThisDate);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "frmOrdersView";
            this.Text = "frmUsersView";
            this.Load += new System.EventHandler(this.frmOrdersView_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.addBtn, 0);
            this.Controls.SetChildIndex(this.guna2Separator1, 0);
            this.Controls.SetChildIndex(this.searchInput, 0);
            this.Controls.SetChildIndex(this.fromThisDate, 0);
            this.Controls.SetChildIndex(this.toThisDate, 0);
            this.Controls.SetChildIndex(this.printButton, 0);
            this.Controls.SetChildIndex(this.guna2DataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DateTimePicker toThisDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker fromThisDate;
        private Guna.UI2.WinForms.Guna2Button printButton;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvWaiter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPaymentMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvReceived;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvChange;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDriver;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCustomerPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCustomerAdress;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIsEditted;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTime;
        private System.Windows.Forms.DataGridViewImageColumn dgvedit;
        private System.Windows.Forms.DataGridViewImageColumn dgvPrint;
    }
}