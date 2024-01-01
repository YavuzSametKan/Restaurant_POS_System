namespace POS_System.Model
{
    partial class frmUsersConfirm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsersConfirm));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeBtn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.passwordVisibilityBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.messageLabel = new System.Windows.Forms.Label();
            this.confirmBtn = new Guna.UI2.WinForms.Guna2Button();
            this.myMessageBox = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 100);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Confirm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(184)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 100);
            this.panel1.TabIndex = 0;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.FillColor = System.Drawing.Color.Red;
            this.closeBtn.IconColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(442, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(30, 29);
            this.closeBtn.TabIndex = 3;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::POS_System.Properties.Resources.user_w;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
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
            this.passwordVisibilityBtn.Location = new System.Drawing.Point(364, 212);
            this.passwordVisibilityBtn.Name = "passwordVisibilityBtn";
            this.passwordVisibilityBtn.Size = new System.Drawing.Size(62, 59);
            this.passwordVisibilityBtn.TabIndex = 9;
            this.passwordVisibilityBtn.Text = "show";
            this.passwordVisibilityBtn.UseTransparentBackground = true;
            this.passwordVisibilityBtn.Click += new System.EventHandler(this.passwordVisibilityBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(41, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 10;
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
            this.passwordInput.Location = new System.Drawing.Point(46, 212);
            this.passwordInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '\0';
            this.passwordInput.PlaceholderText = "Password";
            this.passwordInput.SelectedText = "";
            this.passwordInput.Size = new System.Drawing.Size(380, 59);
            this.passwordInput.TabIndex = 8;
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.ForeColor = System.Drawing.Color.Gray;
            this.messageLabel.Location = new System.Drawing.Point(80, 118);
            this.messageLabel.MaximumSize = new System.Drawing.Size(311, 0);
            this.messageLabel.MinimumSize = new System.Drawing.Size(311, 0);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(311, 50);
            this.messageLabel.TabIndex = 11;
            this.messageLabel.Text = "Please enter the password for username ";
            this.messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // confirmBtn
            // 
            this.confirmBtn.BorderRadius = 15;
            this.confirmBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirmBtn.CustomizableEdges.BottomLeft = false;
            this.confirmBtn.CustomizableEdges.BottomRight = false;
            this.confirmBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.confirmBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.confirmBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.confirmBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.confirmBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.confirmBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(184)))), ((int)(((byte)(39)))));
            this.confirmBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.confirmBtn.ForeColor = System.Drawing.Color.White;
            this.confirmBtn.Location = new System.Drawing.Point(0, 313);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(472, 74);
            this.confirmBtn.TabIndex = 12;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // myMessageBox
            // 
            this.myMessageBox.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.myMessageBox.Caption = "Warning";
            this.myMessageBox.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
            this.myMessageBox.Parent = this;
            this.myMessageBox.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.myMessageBox.Text = null;
            // 
            // frmUsersConfirm
            // 
            this.AcceptButton = this.confirmBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(472, 387);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.passwordVisibilityBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmUsersConfirm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUsersConfirm";
            this.Load += new System.EventHandler(this.frmUsersConfirm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button passwordVisibilityBtn;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox passwordInput;
        private System.Windows.Forms.Label messageLabel;
        private Guna.UI2.WinForms.Guna2Button confirmBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2ControlBox closeBtn;
        private Guna.UI2.WinForms.Guna2MessageDialog myMessageBox;
    }
}