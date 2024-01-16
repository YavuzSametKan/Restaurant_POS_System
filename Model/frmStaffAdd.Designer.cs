namespace POS_System.Model
{
    partial class frmStaffAdd
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
            this.nameInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.phoneInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.roleComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.TabIndex = 5;
            this.headerLabel.Text = "Staff Details";
            // 
            // saveBtn
            // 
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::POS_System.Properties.Resources.staff_w;
            // 
            // closeBtn
            // 
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 460);
            this.panel1.Size = new System.Drawing.Size(477, 85);
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
            this.nameInput.Location = new System.Drawing.Point(39, 177);
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
            this.label1.Location = new System.Drawing.Point(34, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // phoneInput
            // 
            this.phoneInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneInput.DefaultText = "";
            this.phoneInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.phoneInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.phoneInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phoneInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.phoneInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phoneInput.Location = new System.Drawing.Point(39, 278);
            this.phoneInput.Name = "phoneInput";
            this.phoneInput.PasswordChar = '\0';
            this.phoneInput.PlaceholderText = "Phone";
            this.phoneInput.SelectedText = "";
            this.phoneInput.Size = new System.Drawing.Size(388, 50);
            this.phoneInput.TabIndex = 1;
            this.phoneInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneInput_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Role";
            // 
            // roleComboBox
            // 
            this.roleComboBox.BackColor = System.Drawing.Color.Transparent;
            this.roleComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.roleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roleComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roleComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.roleComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.roleComboBox.ItemHeight = 50;
            this.roleComboBox.Items.AddRange(new object[] {
            "Cashier",
            "Waiter",
            "Cleaning",
            "Manager",
            "Driver",
            "Other"});
            this.roleComboBox.Location = new System.Drawing.Point(39, 377);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(388, 56);
            this.roleComboBox.TabIndex = 2;
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmStaffAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 545);
            this.Controls.Add(this.roleComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.phoneInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.label1);
            this.Name = "frmStaffAdd";
            this.Text = "frmStaffAdd";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.nameInput, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.phoneInput, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.roleComboBox, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI2.WinForms.Guna2TextBox nameInput;
        private System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2TextBox phoneInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public Guna.UI2.WinForms.Guna2ComboBox roleComboBox;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
    }
}