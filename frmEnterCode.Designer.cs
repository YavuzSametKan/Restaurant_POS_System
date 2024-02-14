namespace POS_System
{
    partial class frmEnterCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnterCode));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.closeBtn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.passwordVisibilityBtn = new Guna.UI2.WinForms.Guna2Button();
            this.changePasswordBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.codeInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordConfirmInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.infoIabel = new System.Windows.Forms.Label();
            this.MyWarningMessage = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.MyInfoMessage = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(184)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Controls.Add(this.guna2PictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 197);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(0, 123);
            this.label1.MaximumSize = new System.Drawing.Size(500, 0);
            this.label1.MinimumSize = new System.Drawing.Size(500, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 50);
            this.label1.TabIndex = 4;
            this.label1.Text = "Please enter your password reset code and new password informations.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.FillColor = System.Drawing.Color.Red;
            this.closeBtn.IconColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(470, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(30, 29);
            this.closeBtn.TabIndex = 3;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::POS_System.Properties.Resources.rotation_lock;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 22);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Padding = new System.Windows.Forms.Padding(40);
            this.guna2PictureBox1.Size = new System.Drawing.Size(500, 98);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 2;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
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
            this.passwordVisibilityBtn.Location = new System.Drawing.Point(362, 408);
            this.passwordVisibilityBtn.Name = "passwordVisibilityBtn";
            this.passwordVisibilityBtn.Size = new System.Drawing.Size(62, 61);
            this.passwordVisibilityBtn.TabIndex = 2;
            this.passwordVisibilityBtn.Text = "show";
            this.passwordVisibilityBtn.UseTransparentBackground = true;
            this.passwordVisibilityBtn.Click += new System.EventHandler(this.passwordVisibilityBtn_Click);
            // 
            // changePasswordBtn
            // 
            this.changePasswordBtn.AutoRoundedCorners = true;
            this.changePasswordBtn.BorderRadius = 30;
            this.changePasswordBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changePasswordBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.changePasswordBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.changePasswordBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.changePasswordBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.changePasswordBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(184)))), ((int)(((byte)(39)))));
            this.changePasswordBtn.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.changePasswordBtn.ForeColor = System.Drawing.Color.White;
            this.changePasswordBtn.Location = new System.Drawing.Point(137, 612);
            this.changePasswordBtn.Name = "changePasswordBtn";
            this.changePasswordBtn.Size = new System.Drawing.Size(226, 62);
            this.changePasswordBtn.TabIndex = 4;
            this.changePasswordBtn.Text = "Change Password";
            this.changePasswordBtn.Click += new System.EventHandler(this.changePasswordBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(70, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password";
            // 
            // passwordInput
            // 
            this.passwordInput.BorderRadius = 10;
            this.passwordInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordInput.DefaultText = "";
            this.passwordInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordInput.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.passwordInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordInput.Location = new System.Drawing.Point(69, 408);
            this.passwordInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '\0';
            this.passwordInput.PlaceholderText = "Password";
            this.passwordInput.SelectedText = "";
            this.passwordInput.Size = new System.Drawing.Size(355, 61);
            this.passwordInput.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(70, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Code";
            // 
            // codeInput
            // 
            this.codeInput.Animated = true;
            this.codeInput.BorderRadius = 10;
            this.codeInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.codeInput.DefaultText = "";
            this.codeInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.codeInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.codeInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.codeInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.codeInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.codeInput.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.codeInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.codeInput.Location = new System.Drawing.Point(69, 295);
            this.codeInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.codeInput.MaxLength = 6;
            this.codeInput.Name = "codeInput";
            this.codeInput.PasswordChar = '\0';
            this.codeInput.PlaceholderText = "Password Reset Code";
            this.codeInput.SelectedText = "";
            this.codeInput.Size = new System.Drawing.Size(355, 61);
            this.codeInput.TabIndex = 0;
            this.codeInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codeInput_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(70, 492);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password Confirm";
            // 
            // passwordConfirmInput
            // 
            this.passwordConfirmInput.BorderRadius = 10;
            this.passwordConfirmInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordConfirmInput.DefaultText = "";
            this.passwordConfirmInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordConfirmInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordConfirmInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordConfirmInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordConfirmInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordConfirmInput.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.passwordConfirmInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordConfirmInput.Location = new System.Drawing.Point(69, 521);
            this.passwordConfirmInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordConfirmInput.Name = "passwordConfirmInput";
            this.passwordConfirmInput.PasswordChar = '\0';
            this.passwordConfirmInput.PlaceholderText = "Password Confirm";
            this.passwordConfirmInput.SelectedText = "";
            this.passwordConfirmInput.Size = new System.Drawing.Size(355, 61);
            this.passwordConfirmInput.TabIndex = 3;
            // 
            // infoIabel
            // 
            this.infoIabel.AutoSize = true;
            this.infoIabel.BackColor = System.Drawing.Color.Transparent;
            this.infoIabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.infoIabel.Location = new System.Drawing.Point(0, 220);
            this.infoIabel.MaximumSize = new System.Drawing.Size(500, 0);
            this.infoIabel.MinimumSize = new System.Drawing.Size(500, 0);
            this.infoIabel.Name = "infoIabel";
            this.infoIabel.Size = new System.Drawing.Size(500, 24);
            this.infoIabel.TabIndex = 6;
            this.infoIabel.Text = "Please check the e-mail box example@email.com.";
            this.infoIabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MyWarningMessage
            // 
            this.MyWarningMessage.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.MyWarningMessage.Caption = "Warning";
            this.MyWarningMessage.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
            this.MyWarningMessage.Parent = this;
            this.MyWarningMessage.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.MyWarningMessage.Text = null;
            // 
            // MyInfoMessage
            // 
            this.MyInfoMessage.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.MyInfoMessage.Caption = "Info";
            this.MyInfoMessage.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.MyInfoMessage.Parent = this;
            this.MyInfoMessage.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.MyInfoMessage.Text = null;
            // 
            // frmEnterCode
            // 
            this.AcceptButton = this.changePasswordBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 708);
            this.Controls.Add(this.infoIabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passwordConfirmInput);
            this.Controls.Add(this.passwordVisibilityBtn);
            this.Controls.Add(this.changePasswordBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.codeInput);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmEnterCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEnterCode";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmEnterCode_FormClosed);
            this.Load += new System.EventHandler(this.frmEnterCode_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ControlBox closeBtn;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button passwordVisibilityBtn;
        private Guna.UI2.WinForms.Guna2Button changePasswordBtn;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox passwordInput;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox codeInput;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox passwordConfirmInput;
        private System.Windows.Forms.Label infoIabel;
        private Guna.UI2.WinForms.Guna2MessageDialog MyWarningMessage;
        private Guna.UI2.WinForms.Guna2MessageDialog MyInfoMessage;
    }
}