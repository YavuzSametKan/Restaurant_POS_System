namespace POS_System
{
    partial class sampleView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sampleView));
            this.label1 = new System.Windows.Forms.Label();
            this.addBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.searchInput = new System.Windows.Forms.TextBox();
            this.myMessageBox = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(624, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search";
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Transparent;
            this.addBtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.addBtn.Image = global::POS_System.Properties.Resources.addition;
            this.addBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.addBtn.ImageRotate = 0F;
            this.addBtn.ImageSize = new System.Drawing.Size(50, 50);
            this.addBtn.IndicateFocus = true;
            this.addBtn.Location = new System.Drawing.Point(58, 84);
            this.addBtn.Name = "addBtn";
            this.addBtn.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.addBtn.Size = new System.Drawing.Size(50, 50);
            this.addBtn.TabIndex = 2;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label2.Location = new System.Drawing.Point(52, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Header Text";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.Location = new System.Drawing.Point(58, 161);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(884, 10);
            this.guna2Separator1.TabIndex = 3;
            // 
            // searchInput
            // 
            this.searchInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchInput.Location = new System.Drawing.Point(628, 101);
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(314, 33);
            this.searchInput.TabIndex = 4;
            this.searchInput.TextChanged += new System.EventHandler(this.searchInput_TextChanged);
            // 
            // myMessageBox
            // 
            this.myMessageBox.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.myMessageBox.Caption = "Question";
            this.myMessageBox.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
            this.myMessageBox.Parent = null;
            this.myMessageBox.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.myMessageBox.Text = null;
            // 
            // sampleView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1004, 539);
            this.Controls.Add(this.searchInput);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "sampleView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sampleView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Guna.UI2.WinForms.Guna2ImageButton addBtn;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox searchInput;
        public Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        public Guna.UI2.WinForms.Guna2MessageDialog myMessageBox;
    }
}