namespace POS_System.Model
{
    partial class ucProduct
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucProduct));
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.imageInput = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2ShadowPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageInput)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.guna2Separator1);
            this.guna2ShadowPanel1.Controls.Add(this.panel1);
            this.guna2ShadowPanel1.Controls.Add(this.imageInput);
            this.guna2ShadowPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(200, 200);
            this.guna2ShadowPanel1.TabIndex = 0;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(7, 138);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(185, 10);
            this.guna2Separator1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 54);
            this.panel1.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameLabel.Location = new System.Drawing.Point(7, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(185, 48);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Product Name";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageInput
            // 
            this.imageInput.Image = ((System.Drawing.Image)(resources.GetObject("imageInput.Image")));
            this.imageInput.ImageRotate = 0F;
            this.imageInput.Location = new System.Drawing.Point(7, 10);
            this.imageInput.Name = "imageInput";
            this.imageInput.Size = new System.Drawing.Size(185, 130);
            this.imageInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageInput.TabIndex = 0;
            this.imageInput.TabStop = false;
            this.imageInput.Click += new System.EventHandler(this.imageInput_Click);
            // 
            // ucProduct
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Name = "ucProduct";
            this.Size = new System.Drawing.Size(200, 200);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label nameLabel;
        private Guna.UI2.WinForms.Guna2PictureBox imageInput;
    }
}
