namespace POS_System
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.cloaseBtn = new Guna.UI2.WinForms.Guna2Button();
            this.settingsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.kitchenBtn = new Guna.UI2.WinForms.Guna2Button();
            this.POSBtn = new Guna.UI2.WinForms.Guna2Button();
            this.staffBtn = new Guna.UI2.WinForms.Guna2Button();
            this.tablesBtn = new Guna.UI2.WinForms.Guna2Button();
            this.productsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.categoriesBtn = new Guna.UI2.WinForms.Guna2Button();
            this.homeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.CenterPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.ordersBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.Controls.Add(this.cloaseBtn);
            this.guna2Panel1.Controls.Add(this.settingsBtn);
            this.guna2Panel1.Controls.Add(this.ordersBtn);
            this.guna2Panel1.Controls.Add(this.kitchenBtn);
            this.guna2Panel1.Controls.Add(this.POSBtn);
            this.guna2Panel1.Controls.Add(this.staffBtn);
            this.guna2Panel1.Controls.Add(this.tablesBtn);
            this.guna2Panel1.Controls.Add(this.productsBtn);
            this.guna2Panel1.Controls.Add(this.categoriesBtn);
            this.guna2Panel1.Controls.Add(this.homeBtn);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.CustomizableEdges.BottomLeft = false;
            this.guna2Panel1.CustomizableEdges.TopLeft = false;
            this.guna2Panel1.CustomizableEdges.TopRight = false;
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(184)))), ((int)(((byte)(39)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(248, 872);
            this.guna2Panel1.TabIndex = 0;
            // 
            // cloaseBtn
            // 
            this.cloaseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cloaseBtn.AutoRoundedCorners = true;
            this.cloaseBtn.BackColor = System.Drawing.Color.Transparent;
            this.cloaseBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.cloaseBtn.BorderRadius = 21;
            this.cloaseBtn.BorderThickness = 3;
            this.cloaseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cloaseBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cloaseBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cloaseBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cloaseBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cloaseBtn.FillColor = System.Drawing.Color.Transparent;
            this.cloaseBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cloaseBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.cloaseBtn.Location = new System.Drawing.Point(49, 790);
            this.cloaseBtn.Name = "cloaseBtn";
            this.cloaseBtn.Size = new System.Drawing.Size(143, 45);
            this.cloaseBtn.TabIndex = 2;
            this.cloaseBtn.Text = "Exit";
            this.cloaseBtn.UseTransparentBackground = true;
            this.cloaseBtn.Click += new System.EventHandler(this.cloaseBtn_Click);
            // 
            // settingsBtn
            // 
            this.settingsBtn.AutoRoundedCorners = true;
            this.settingsBtn.BackColor = System.Drawing.Color.Transparent;
            this.settingsBtn.BorderColor = System.Drawing.Color.White;
            this.settingsBtn.BorderRadius = 28;
            this.settingsBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.settingsBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.settingsBtn.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.settingsBtn.CheckedState.Image = global::POS_System.Properties.Resources.settings_b;
            this.settingsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsBtn.CustomizableEdges.BottomRight = false;
            this.settingsBtn.CustomizableEdges.TopRight = false;
            this.settingsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.settingsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.settingsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.settingsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.settingsBtn.FillColor = System.Drawing.Color.Transparent;
            this.settingsBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.settingsBtn.ForeColor = System.Drawing.Color.White;
            this.settingsBtn.Image = global::POS_System.Properties.Resources.settings_w;
            this.settingsBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.settingsBtn.ImageOffset = new System.Drawing.Point(10, 0);
            this.settingsBtn.Location = new System.Drawing.Point(38, 489);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(210, 58);
            this.settingsBtn.TabIndex = 1;
            this.settingsBtn.Text = "Users";
            this.settingsBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.settingsBtn.TextOffset = new System.Drawing.Point(20, 0);
            this.settingsBtn.UseTransparentBackground = true;
            // 
            // kitchenBtn
            // 
            this.kitchenBtn.AutoRoundedCorners = true;
            this.kitchenBtn.BackColor = System.Drawing.Color.Transparent;
            this.kitchenBtn.BorderColor = System.Drawing.Color.White;
            this.kitchenBtn.BorderRadius = 28;
            this.kitchenBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.kitchenBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.kitchenBtn.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.kitchenBtn.CheckedState.Image = global::POS_System.Properties.Resources.kitchen_b;
            this.kitchenBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kitchenBtn.CustomizableEdges.BottomRight = false;
            this.kitchenBtn.CustomizableEdges.TopRight = false;
            this.kitchenBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.kitchenBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.kitchenBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.kitchenBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.kitchenBtn.FillColor = System.Drawing.Color.Transparent;
            this.kitchenBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.kitchenBtn.ForeColor = System.Drawing.Color.White;
            this.kitchenBtn.Image = global::POS_System.Properties.Resources.kitchen_w;
            this.kitchenBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.kitchenBtn.ImageOffset = new System.Drawing.Point(10, 0);
            this.kitchenBtn.Location = new System.Drawing.Point(38, 681);
            this.kitchenBtn.Name = "kitchenBtn";
            this.kitchenBtn.Size = new System.Drawing.Size(210, 58);
            this.kitchenBtn.TabIndex = 1;
            this.kitchenBtn.Text = "Kitchen";
            this.kitchenBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.kitchenBtn.TextOffset = new System.Drawing.Point(20, 0);
            this.kitchenBtn.UseTransparentBackground = true;
            this.kitchenBtn.Click += new System.EventHandler(this.kitchenBtn_Click);
            // 
            // POSBtn
            // 
            this.POSBtn.AutoRoundedCorners = true;
            this.POSBtn.BackColor = System.Drawing.Color.Transparent;
            this.POSBtn.BorderColor = System.Drawing.Color.White;
            this.POSBtn.BorderRadius = 28;
            this.POSBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.POSBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.POSBtn.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.POSBtn.CheckedState.Image = global::POS_System.Properties.Resources.POS_b;
            this.POSBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.POSBtn.CustomizableEdges.BottomRight = false;
            this.POSBtn.CustomizableEdges.TopRight = false;
            this.POSBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.POSBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.POSBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.POSBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.POSBtn.FillColor = System.Drawing.Color.Transparent;
            this.POSBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.POSBtn.ForeColor = System.Drawing.Color.White;
            this.POSBtn.Image = global::POS_System.Properties.Resources.POS_w;
            this.POSBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.POSBtn.ImageOffset = new System.Drawing.Point(10, 0);
            this.POSBtn.Location = new System.Drawing.Point(38, 617);
            this.POSBtn.Name = "POSBtn";
            this.POSBtn.Size = new System.Drawing.Size(210, 58);
            this.POSBtn.TabIndex = 1;
            this.POSBtn.Text = "POS";
            this.POSBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.POSBtn.TextOffset = new System.Drawing.Point(20, 0);
            this.POSBtn.UseTransparentBackground = true;
            this.POSBtn.Click += new System.EventHandler(this.POSBtn_Click);
            // 
            // staffBtn
            // 
            this.staffBtn.AutoRoundedCorners = true;
            this.staffBtn.BackColor = System.Drawing.Color.Transparent;
            this.staffBtn.BorderColor = System.Drawing.Color.White;
            this.staffBtn.BorderRadius = 28;
            this.staffBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.staffBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.staffBtn.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.staffBtn.CheckedState.Image = global::POS_System.Properties.Resources.staff_b;
            this.staffBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.staffBtn.CustomizableEdges.BottomRight = false;
            this.staffBtn.CustomizableEdges.TopRight = false;
            this.staffBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.staffBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.staffBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.staffBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.staffBtn.FillColor = System.Drawing.Color.Transparent;
            this.staffBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.staffBtn.ForeColor = System.Drawing.Color.White;
            this.staffBtn.Image = global::POS_System.Properties.Resources.staff_w;
            this.staffBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.staffBtn.ImageOffset = new System.Drawing.Point(10, 0);
            this.staffBtn.Location = new System.Drawing.Point(38, 425);
            this.staffBtn.Name = "staffBtn";
            this.staffBtn.Size = new System.Drawing.Size(210, 58);
            this.staffBtn.TabIndex = 1;
            this.staffBtn.Text = "Staff";
            this.staffBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.staffBtn.TextOffset = new System.Drawing.Point(20, 0);
            this.staffBtn.UseTransparentBackground = true;
            this.staffBtn.Click += new System.EventHandler(this.staffBtn_Click);
            // 
            // tablesBtn
            // 
            this.tablesBtn.AutoRoundedCorners = true;
            this.tablesBtn.BackColor = System.Drawing.Color.Transparent;
            this.tablesBtn.BorderColor = System.Drawing.Color.White;
            this.tablesBtn.BorderRadius = 28;
            this.tablesBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.tablesBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.tablesBtn.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.tablesBtn.CheckedState.Image = global::POS_System.Properties.Resources.table_b;
            this.tablesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tablesBtn.CustomizableEdges.BottomRight = false;
            this.tablesBtn.CustomizableEdges.TopRight = false;
            this.tablesBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.tablesBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.tablesBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tablesBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.tablesBtn.FillColor = System.Drawing.Color.Transparent;
            this.tablesBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.tablesBtn.ForeColor = System.Drawing.Color.White;
            this.tablesBtn.Image = global::POS_System.Properties.Resources.tables_w;
            this.tablesBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tablesBtn.ImageOffset = new System.Drawing.Point(10, 0);
            this.tablesBtn.Location = new System.Drawing.Point(38, 361);
            this.tablesBtn.Name = "tablesBtn";
            this.tablesBtn.Size = new System.Drawing.Size(210, 58);
            this.tablesBtn.TabIndex = 1;
            this.tablesBtn.Text = "Tables";
            this.tablesBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tablesBtn.TextOffset = new System.Drawing.Point(20, 0);
            this.tablesBtn.UseTransparentBackground = true;
            this.tablesBtn.Click += new System.EventHandler(this.tablesBtn_Click);
            // 
            // productsBtn
            // 
            this.productsBtn.AutoRoundedCorners = true;
            this.productsBtn.BackColor = System.Drawing.Color.Transparent;
            this.productsBtn.BorderColor = System.Drawing.Color.White;
            this.productsBtn.BorderRadius = 28;
            this.productsBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.productsBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.productsBtn.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.productsBtn.CheckedState.Image = global::POS_System.Properties.Resources.products_b;
            this.productsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productsBtn.CustomizableEdges.BottomRight = false;
            this.productsBtn.CustomizableEdges.TopRight = false;
            this.productsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.productsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.productsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.productsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.productsBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(184)))), ((int)(((byte)(39)))));
            this.productsBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.productsBtn.ForeColor = System.Drawing.Color.White;
            this.productsBtn.Image = global::POS_System.Properties.Resources.products_w;
            this.productsBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.productsBtn.ImageOffset = new System.Drawing.Point(10, 0);
            this.productsBtn.Location = new System.Drawing.Point(38, 297);
            this.productsBtn.Name = "productsBtn";
            this.productsBtn.Size = new System.Drawing.Size(210, 58);
            this.productsBtn.TabIndex = 1;
            this.productsBtn.Text = "Products";
            this.productsBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.productsBtn.TextOffset = new System.Drawing.Point(20, 0);
            this.productsBtn.UseTransparentBackground = true;
            this.productsBtn.Click += new System.EventHandler(this.productsBtn_Click);
            // 
            // categoriesBtn
            // 
            this.categoriesBtn.AutoRoundedCorners = true;
            this.categoriesBtn.BackColor = System.Drawing.Color.Transparent;
            this.categoriesBtn.BorderColor = System.Drawing.Color.White;
            this.categoriesBtn.BorderRadius = 28;
            this.categoriesBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.categoriesBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.categoriesBtn.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.categoriesBtn.CheckedState.Image = global::POS_System.Properties.Resources.categories_b;
            this.categoriesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categoriesBtn.CustomizableEdges.BottomRight = false;
            this.categoriesBtn.CustomizableEdges.TopRight = false;
            this.categoriesBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.categoriesBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.categoriesBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.categoriesBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.categoriesBtn.FillColor = System.Drawing.Color.Transparent;
            this.categoriesBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.categoriesBtn.ForeColor = System.Drawing.Color.White;
            this.categoriesBtn.Image = global::POS_System.Properties.Resources.categories_w;
            this.categoriesBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.categoriesBtn.ImageOffset = new System.Drawing.Point(10, 0);
            this.categoriesBtn.Location = new System.Drawing.Point(38, 233);
            this.categoriesBtn.Name = "categoriesBtn";
            this.categoriesBtn.Size = new System.Drawing.Size(210, 58);
            this.categoriesBtn.TabIndex = 1;
            this.categoriesBtn.Text = "Categories";
            this.categoriesBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.categoriesBtn.TextOffset = new System.Drawing.Point(20, 0);
            this.categoriesBtn.UseTransparentBackground = true;
            this.categoriesBtn.Click += new System.EventHandler(this.categoriesBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.AutoRoundedCorners = true;
            this.homeBtn.BackColor = System.Drawing.Color.Transparent;
            this.homeBtn.BorderColor = System.Drawing.Color.White;
            this.homeBtn.BorderRadius = 28;
            this.homeBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.homeBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.homeBtn.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.homeBtn.CheckedState.Image = global::POS_System.Properties.Resources.house_black;
            this.homeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeBtn.CustomizableEdges.BottomRight = false;
            this.homeBtn.CustomizableEdges.TopRight = false;
            this.homeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.homeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.homeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.homeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.homeBtn.FillColor = System.Drawing.Color.Transparent;
            this.homeBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.homeBtn.ForeColor = System.Drawing.Color.White;
            this.homeBtn.Image = global::POS_System.Properties.Resources.house_white;
            this.homeBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.homeBtn.ImageOffset = new System.Drawing.Point(10, 0);
            this.homeBtn.Location = new System.Drawing.Point(38, 169);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(210, 58);
            this.homeBtn.TabIndex = 1;
            this.homeBtn.Text = "Home";
            this.homeBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.homeBtn.TextOffset = new System.Drawing.Point(20, 0);
            this.homeBtn.UseTransparentBackground = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::POS_System.Properties.Resources.logo;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(-2, 35);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(250, 111);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Panel2.BorderRadius = 20;
            this.guna2Panel2.BorderThickness = 2;
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Controls.Add(this.userLabel);
            this.guna2Panel2.CustomizableEdges.BottomLeft = false;
            this.guna2Panel2.CustomizableEdges.TopLeft = false;
            this.guna2Panel2.CustomizableEdges.TopRight = false;
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.FillColor = System.Drawing.Color.White;
            this.guna2Panel2.Location = new System.Drawing.Point(248, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1068, 54);
            this.guna2Panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name:";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.BackColor = System.Drawing.Color.Transparent;
            this.userLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(184)))), ((int)(((byte)(39)))));
            this.userLabel.Location = new System.Drawing.Point(101, 16);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(40, 21);
            this.userLabel.TabIndex = 1;
            this.userLabel.Text = "user";
            // 
            // CenterPanel
            // 
            this.CenterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CenterPanel.Location = new System.Drawing.Point(248, 54);
            this.CenterPanel.Name = "CenterPanel";
            this.CenterPanel.Size = new System.Drawing.Size(1068, 818);
            this.CenterPanel.TabIndex = 0;
            // 
            // ordersBtn
            // 
            this.ordersBtn.AutoRoundedCorners = true;
            this.ordersBtn.BackColor = System.Drawing.Color.Transparent;
            this.ordersBtn.BorderColor = System.Drawing.Color.White;
            this.ordersBtn.BorderRadius = 28;
            this.ordersBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.ordersBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.ordersBtn.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.ordersBtn.CheckedState.Image = global::POS_System.Properties.Resources.kitchen_b;
            this.ordersBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ordersBtn.CustomizableEdges.BottomRight = false;
            this.ordersBtn.CustomizableEdges.TopRight = false;
            this.ordersBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ordersBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ordersBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ordersBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ordersBtn.FillColor = System.Drawing.Color.Transparent;
            this.ordersBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.ordersBtn.ForeColor = System.Drawing.Color.White;
            this.ordersBtn.Image = global::POS_System.Properties.Resources.bills_w;
            this.ordersBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ordersBtn.ImageOffset = new System.Drawing.Point(10, 0);
            this.ordersBtn.Location = new System.Drawing.Point(38, 553);
            this.ordersBtn.Name = "ordersBtn";
            this.ordersBtn.Size = new System.Drawing.Size(210, 58);
            this.ordersBtn.TabIndex = 1;
            this.ordersBtn.Text = "Orders";
            this.ordersBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ordersBtn.TextOffset = new System.Drawing.Point(20, 0);
            this.ordersBtn.UseTransparentBackground = true;
            this.ordersBtn.Click += new System.EventHandler(this.ordersBtn_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1316, 872);
            this.Controls.Add(this.CenterPanel);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel CenterPanel;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button settingsBtn;
        private Guna.UI2.WinForms.Guna2Button kitchenBtn;
        private Guna.UI2.WinForms.Guna2Button POSBtn;
        private Guna.UI2.WinForms.Guna2Button staffBtn;
        private Guna.UI2.WinForms.Guna2Button tablesBtn;
        private Guna.UI2.WinForms.Guna2Button productsBtn;
        private Guna.UI2.WinForms.Guna2Button categoriesBtn;
        private Guna.UI2.WinForms.Guna2Button homeBtn;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button cloaseBtn;
        private Guna.UI2.WinForms.Guna2Button ordersBtn;
    }
}