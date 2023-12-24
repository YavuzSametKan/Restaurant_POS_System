namespace POS_System
{
    partial class frmLogin
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.closeBtn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.userNameInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.LoginBtn = new Guna.UI2.WinForms.Guna2Button();
            this.iForgotMyPasswordLink = new System.Windows.Forms.LinkLabel();
            this.passwordVisibilityBtn = new Guna.UI2.WinForms.Guna2Button();
            this.MyWarningMessage = new Guna.UI2.WinForms.Guna2MessageDialog();
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
            this.label1.Location = new System.Drawing.Point(0, 143);
            this.label1.MinimumSize = new System.Drawing.Size(500, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please enter your user informations.";
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
            this.closeBtn.TabIndex = 0;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::POS_System.Properties.Resources.user;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 32);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Padding = new System.Windows.Forms.Padding(40);
            this.guna2PictureBox1.Size = new System.Drawing.Size(500, 98);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 2;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // userNameInput
            // 
            this.userNameInput.Animated = true;
            this.userNameInput.BorderRadius = 10;
            this.userNameInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userNameInput.DefaultText = "";
            this.userNameInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userNameInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userNameInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userNameInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userNameInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userNameInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userNameInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userNameInput.Location = new System.Drawing.Point(70, 256);
            this.userNameInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userNameInput.Name = "userNameInput";
            this.userNameInput.PasswordChar = '\0';
            this.userNameInput.PlaceholderText = "Username";
            this.userNameInput.SelectedText = "";
            this.userNameInput.Size = new System.Drawing.Size(355, 61);
            this.userNameInput.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(71, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(71, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 7;
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
            this.passwordInput.Location = new System.Drawing.Point(70, 369);
            this.passwordInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '\0';
            this.passwordInput.PlaceholderText = "Password";
            this.passwordInput.SelectedText = "";
            this.passwordInput.Size = new System.Drawing.Size(355, 61);
            this.passwordInput.TabIndex = 1;
            // 
            // LoginBtn
            // 
            this.LoginBtn.AutoRoundedCorners = true;
            this.LoginBtn.BorderRadius = 30;
            this.LoginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LoginBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LoginBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LoginBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LoginBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(184)))), ((int)(((byte)(39)))));
            this.LoginBtn.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.Location = new System.Drawing.Point(150, 499);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(190, 62);
            this.LoginBtn.TabIndex = 4;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // iForgotMyPasswordLink
            // 
            this.iForgotMyPasswordLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iForgotMyPasswordLink.AutoSize = true;
            this.iForgotMyPasswordLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iForgotMyPasswordLink.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.iForgotMyPasswordLink.LinkColor = System.Drawing.Color.Gray;
            this.iForgotMyPasswordLink.Location = new System.Drawing.Point(256, 453);
            this.iForgotMyPasswordLink.Name = "iForgotMyPasswordLink";
            this.iForgotMyPasswordLink.Size = new System.Drawing.Size(169, 21);
            this.iForgotMyPasswordLink.TabIndex = 3;
            this.iForgotMyPasswordLink.TabStop = true;
            this.iForgotMyPasswordLink.Text = "I Forgot My Password";
            this.iForgotMyPasswordLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.iForgotMyPasswordLink_LinkClicked);
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
            this.passwordVisibilityBtn.Location = new System.Drawing.Point(363, 369);
            this.passwordVisibilityBtn.Name = "passwordVisibilityBtn";
            this.passwordVisibilityBtn.Size = new System.Drawing.Size(62, 61);
            this.passwordVisibilityBtn.TabIndex = 2;
            this.passwordVisibilityBtn.Text = "show";
            this.passwordVisibilityBtn.UseTransparentBackground = true;
            this.passwordVisibilityBtn.Click += new System.EventHandler(this.passwordVisibilityBtn_Click);
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
            // frmLogin
            // 
            this.AcceptButton = this.LoginBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.Controls.Add(this.passwordVisibilityBtn);
            this.Controls.Add(this.iForgotMyPasswordLink);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userNameInput);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2ControlBox closeBtn;
        private Guna.UI2.WinForms.Guna2TextBox userNameInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox passwordInput;
        private Guna.UI2.WinForms.Guna2Button LoginBtn;
        private System.Windows.Forms.LinkLabel iForgotMyPasswordLink;
        private Guna.UI2.WinForms.Guna2Button passwordVisibilityBtn;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2MessageDialog MyWarningMessage;
    }
}

