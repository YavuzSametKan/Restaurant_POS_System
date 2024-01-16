namespace POS_System.Model
{
    partial class frmProductAdd
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
            this.categoryComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.priceInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imageInput = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.browseBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pennyInput = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageInput)).BeginInit();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.Size = new System.Drawing.Size(175, 32);
            this.headerLabel.TabIndex = 6;
            this.headerLabel.Text = "Product Details";
            // 
            // saveBtn
            // 
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::POS_System.Properties.Resources.products_w;
            // 
            // closeBtn
            // 
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 453);
            this.panel1.Size = new System.Drawing.Size(646, 85);
            this.panel1.TabIndex = 5;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.BackColor = System.Drawing.Color.Transparent;
            this.categoryComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categoryComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categoryComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.categoryComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.categoryComboBox.ItemHeight = 50;
            this.categoryComboBox.Items.AddRange(new object[] {
            "Cashier",
            "Waither",
            "Cleaning",
            "Manager",
            "Other"});
            this.categoryComboBox.Location = new System.Drawing.Point(22, 372);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(388, 56);
            this.categoryComboBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Category";
            // 
            // priceInput
            // 
            this.priceInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.priceInput.DefaultText = "";
            this.priceInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.priceInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.priceInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.priceInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.priceInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.priceInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.priceInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.priceInput.Location = new System.Drawing.Point(22, 273);
            this.priceInput.Name = "priceInput";
            this.priceInput.PasswordChar = '\0';
            this.priceInput.PlaceholderText = "Price";
            this.priceInput.SelectedText = "";
            this.priceInput.Size = new System.Drawing.Size(276, 50);
            this.priceInput.TabIndex = 1;
            this.priceInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceInput_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Price";
            // 
            // nameInput
            // 
            this.nameInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameInput.DefaultText = "";
            this.nameInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nameInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nameInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nameInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameInput.Location = new System.Drawing.Point(22, 172);
            this.nameInput.Name = "nameInput";
            this.nameInput.PasswordChar = '\0';
            this.nameInput.PlaceholderText = "Name";
            this.nameInput.SelectedText = "";
            this.nameInput.Size = new System.Drawing.Size(388, 50);
            this.nameInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // imageInput
            // 
            this.imageInput.BackColor = System.Drawing.Color.Transparent;
            this.imageInput.Image = global::POS_System.Properties.Resources.image;
            this.imageInput.ImageRotate = 0F;
            this.imageInput.Location = new System.Drawing.Point(466, 181);
            this.imageInput.Name = "imageInput";
            this.imageInput.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.imageInput.Size = new System.Drawing.Size(160, 160);
            this.imageInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageInput.TabIndex = 12;
            this.imageInput.TabStop = false;
            this.imageInput.UseTransparentBackground = true;
            // 
            // browseBtn
            // 
            this.browseBtn.AutoRoundedCorners = true;
            this.browseBtn.BorderRadius = 21;
            this.browseBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.browseBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.browseBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.browseBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.browseBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(184)))), ((int)(((byte)(39)))));
            this.browseBtn.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.browseBtn.ForeColor = System.Drawing.Color.White;
            this.browseBtn.Location = new System.Drawing.Point(466, 347);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(159, 45);
            this.browseBtn.TabIndex = 4;
            this.browseBtn.Text = "Browse";
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(301, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = ".";
            // 
            // pennyInput
            // 
            this.pennyInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pennyInput.DefaultText = "";
            this.pennyInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pennyInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.pennyInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pennyInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pennyInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pennyInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pennyInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pennyInput.Location = new System.Drawing.Point(318, 273);
            this.pennyInput.Name = "pennyInput";
            this.pennyInput.PasswordChar = '\0';
            this.pennyInput.PlaceholderText = "Penny";
            this.pennyInput.SelectedText = "";
            this.pennyInput.Size = new System.Drawing.Size(92, 50);
            this.pennyInput.TabIndex = 2;
            this.pennyInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceInput_KeyPress);
            // 
            // frmProductAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 538);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.imageInput);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pennyInput);
            this.Controls.Add(this.priceInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.label1);
            this.Name = "frmProductAdd";
            this.Text = "frmProductAdd";
            this.Load += new System.EventHandler(this.frmProductAdd_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.nameInput, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.priceInput, 0);
            this.Controls.SetChildIndex(this.pennyInput, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.categoryComboBox, 0);
            this.Controls.SetChildIndex(this.imageInput, 0);
            this.Controls.SetChildIndex(this.browseBtn, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI2.WinForms.Guna2ComboBox categoryComboBox;
        private System.Windows.Forms.Label label3;
        public Guna.UI2.WinForms.Guna2TextBox priceInput;
        private System.Windows.Forms.Label label2;
        public Guna.UI2.WinForms.Guna2TextBox nameInput;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox imageInput;
        private Guna.UI2.WinForms.Guna2Button browseBtn;
        private System.Windows.Forms.Label label5;
        public Guna.UI2.WinForms.Guna2TextBox pennyInput;
    }
}