namespace POS_System.Model
{
    partial class frmTableAdd
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.Size = new System.Drawing.Size(148, 32);
            this.headerLabel.Text = "Table Details";
            // 
            // saveBtn
            // 
            this.saveBtn.FlatAppearance.BorderSize = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::POS_System.Properties.Resources.tables_w;
            // 
            // closeBtn
            // 
            this.closeBtn.FlatAppearance.BorderSize = 0;
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
            this.nameInput.Location = new System.Drawing.Point(41, 193);
            this.nameInput.Name = "nameInput";
            this.nameInput.PasswordChar = '\0';
            this.nameInput.PlaceholderText = "Name";
            this.nameInput.SelectedText = "";
            this.nameInput.Size = new System.Drawing.Size(388, 50);
            this.nameInput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // frmTableAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 385);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.label1);
            this.Name = "frmTableAdd";
            this.Text = "frmTableAdd";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI2.WinForms.Guna2TextBox nameInput;
        private System.Windows.Forms.Label label1;
    }
}