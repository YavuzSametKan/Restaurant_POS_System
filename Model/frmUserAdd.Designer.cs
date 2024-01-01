namespace POS_System.Model
{
    partial class frmUserAdd
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
            this.userNameInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.emailInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordConfirmInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.passwordVisibilityBtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.Size = new System.Drawing.Size(140, 32);
            this.headerLabel.Text = "User Details";
            // 
            // saveBtn
            // 
            this.saveBtn.FlatAppearance.BorderSize = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::POS_System.Properties.Resources.user_w;
            // 
            // closeBtn
            // 
            this.closeBtn.FlatAppearance.BorderSize = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 557);
            this.panel1.Size = new System.Drawing.Size(503, 85);
            // 
            // userNameInput
            // 
            this.userNameInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userNameInput.DefaultText = "";
            this.userNameInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userNameInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userNameInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userNameInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userNameInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userNameInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.userNameInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userNameInput.Location = new System.Drawing.Point(54, 194);
            this.userNameInput.Name = "userNameInput";
            this.userNameInput.PasswordChar = '\0';
            this.userNameInput.PlaceholderText = "User Name";
            this.userNameInput.SelectedText = "";
            this.userNameInput.Size = new System.Drawing.Size(388, 50);
            this.userNameInput.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "E-mail";
            // 
            // emailInput
            // 
            this.emailInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailInput.DefaultText = "";
            this.emailInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.emailInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailInput.Location = new System.Drawing.Point(54, 285);
            this.emailInput.Name = "emailInput";
            this.emailInput.PasswordChar = '\0';
            this.emailInput.PlaceholderText = "E-mail";
            this.emailInput.SelectedText = "";
            this.emailInput.Size = new System.Drawing.Size(388, 50);
            this.emailInput.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // passwordInput
            // 
            this.passwordInput.BorderRadius = 10;
            this.passwordInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordInput.CustomizableEdges.BottomLeft = false;
            this.passwordInput.CustomizableEdges.TopLeft = false;
            this.passwordInput.DefaultText = "";
            this.passwordInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passwordInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordInput.Location = new System.Drawing.Point(54, 374);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '\0';
            this.passwordInput.PlaceholderText = "Password";
            this.passwordInput.SelectedText = "";
            this.passwordInput.Size = new System.Drawing.Size(388, 50);
            this.passwordInput.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 437);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password Confirm";
            // 
            // passwordConfirmInput
            // 
            this.passwordConfirmInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordConfirmInput.DefaultText = "";
            this.passwordConfirmInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordConfirmInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordConfirmInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordConfirmInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordConfirmInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordConfirmInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passwordConfirmInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordConfirmInput.Location = new System.Drawing.Point(54, 465);
            this.passwordConfirmInput.Name = "passwordConfirmInput";
            this.passwordConfirmInput.PasswordChar = '\0';
            this.passwordConfirmInput.PlaceholderText = "Password Confirm";
            this.passwordConfirmInput.SelectedText = "";
            this.passwordConfirmInput.Size = new System.Drawing.Size(388, 50);
            this.passwordConfirmInput.TabIndex = 4;
            // 
            // passwordVisibilityBtn
            // 
            this.passwordVisibilityBtn.BackColor = System.Drawing.Color.Transparent;
            this.passwordVisibilityBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.passwordVisibilityBtn.BorderColor = System.Drawing.Color.Transparent;
            this.passwordVisibilityBtn.BorderRadius = 10;
            this.passwordVisibilityBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passwordVisibilityBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.passwordVisibilityBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.passwordVisibilityBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.passwordVisibilityBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.passwordVisibilityBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(184)))), ((int)(((byte)(39)))));
            this.passwordVisibilityBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.passwordVisibilityBtn.ForeColor = System.Drawing.Color.White;
            this.passwordVisibilityBtn.Location = new System.Drawing.Point(380, 374);
            this.passwordVisibilityBtn.Name = "passwordVisibilityBtn";
            this.passwordVisibilityBtn.Size = new System.Drawing.Size(62, 50);
            this.passwordVisibilityBtn.TabIndex = 6;
            this.passwordVisibilityBtn.Text = "show";
            this.passwordVisibilityBtn.UseTransparentBackground = true;
            this.passwordVisibilityBtn.Click += new System.EventHandler(this.passwordVisibilityBtn_Click);
            // 
            // frmUserAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 642);
            this.Controls.Add(this.passwordVisibilityBtn);
            this.Controls.Add(this.passwordConfirmInput);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userNameInput);
            this.Controls.Add(this.label1);
            this.Name = "frmUserAdd";
            this.Text = "frmUsersAdd";
            this.Load += new System.EventHandler(this.frmUserAdd_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.userNameInput, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.emailInput, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.passwordInput, 0);
            this.Controls.SetChildIndex(this.passwordConfirmInput, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.passwordVisibilityBtn, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI2.WinForms.Guna2TextBox userNameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public Guna.UI2.WinForms.Guna2TextBox emailInput;
        private System.Windows.Forms.Label label3;
        public Guna.UI2.WinForms.Guna2TextBox passwordInput;
        private System.Windows.Forms.Label label4;
        public Guna.UI2.WinForms.Guna2TextBox passwordConfirmInput;
        private Guna.UI2.WinForms.Guna2Button passwordVisibilityBtn;
    }
}