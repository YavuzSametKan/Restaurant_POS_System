using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS_System.Classes;

namespace POS_System.Model
{
    public partial class frmProductAdd : sampleAdd
    {
        public frmProductAdd()
        {
            InitializeComponent();
            AddRoundedStyleToForm.ApplyRoundedFormStyle(this);
        }

        public int id = 0;
        public int cID = 0;
        Byte[] imageByteArray;

        private void frmProductAdd_Load(object sender, EventArgs e)
        {
            // for Combo box fill
            string qry = "SELECT catID 'id', catName 'name' FROM category ";
            DataBaseOperations.CRUDOperations.CBFill(qry, categoryComboBox);

            if(cID > 0) // For Update
                categoryComboBox.SelectedValue = cID;

            if(id > 0)
                ForUpdateLoadData();
        }
        private bool IsImage(string filePath)
        {
            try
            {
                using (var img = Image.FromFile(filePath))
                {
                    return img.RawFormat.Guid == ImageFormat.Jpeg.Guid
                        || img.RawFormat.Guid == ImageFormat.Png.Guid
                        || img.RawFormat.Guid == ImageFormat.Gif.Guid
                        || img.RawFormat.Guid == ImageFormat.Bmp.Guid;
                }
            }
            catch
            {
                return false;
            }
        }

        string filePath;
        private void browseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images(.jpg, .jpeg, .png, .webp)|*.png; *.jpg; *.jpeg; *.webp";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
                try
                {
                    if (File.Exists(filePath) && IsImage(filePath))
                        imageInput.Image = new Bitmap(filePath);
                    else
                        myMessageBox.Show("The selected file is not a valid image file.");
                }
                catch (Exception ex)
                {
                    myMessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private bool AreImagesEqual(Image img1, Image img2)
        {
            if (img1 == null || img2 == null)
                return false;

            using (MemoryStream ms1 = new MemoryStream(), ms2 = new MemoryStream())
            {
                img1.Save(ms1, img1.RawFormat);
                img2.Save(ms2, img2.RawFormat);

                return ms1.ToArray().SequenceEqual(ms2.ToArray());
            }
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (nameInput.Text.Trim() != "" && priceInput.Text.Trim() != "" && categoryComboBox.Text != "")
            {
                string qry = "";

                if (id == 0) // insert
                    qry = "INSERT INTO products (pName, pPrice, categoryID, pImage) VALUES (@Name, @Price, @CatID, @Img)";
                else // update
                    qry = "UPDATE products SET pName = @Name, pPrice = @Price, categoryID = @CatID, pImage = @Img WHERE pID = @id ";

                // For Image
                if (AreImagesEqual(imageInput.Image, Properties.Resources.image))
                    imageInput.Image = Properties.Resources.logo;
                int width = 364, height = 268;
                Image temp = new Bitmap(imageInput.Image, width, height);
                MemoryStream ms = new MemoryStream();
                temp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                imageByteArray = ms.ToArray();

                Hashtable ht = new Hashtable();
                ht.Add("@id", id);
                ht.Add("@Name", nameInput.Text.Trim());
                ht.Add("@Price", priceInput.Text + "." + pennyInput.Text);
                ht.Add("@CatID", Convert.ToInt32(categoryComboBox.SelectedValue));
                ht.Add("@Img", imageByteArray);

                if (DataBaseOperations.CRUDOperations.SQL(qry, ht) > 0)
                {
                    myMessageBox.Show("Saved successfully.");
                    id = 0;
                    cID = 0;
                    nameInput.Text = "";
                    priceInput.Text = "";
                    pennyInput.Text = "";
                    categoryComboBox.SelectedIndex = 0;
                    categoryComboBox.SelectedIndex = -1;
                    imageInput.Image = POS_System.Properties.Resources.image;
                    nameInput.Focus();
                }
            }
            else
                myMessageBox.Show("Please fill the all inputs.");
        }

        private void ForUpdateLoadData()
        {
            string qry = $"SELECT * FROM products WHERE pID = '{id}'";
            SQLiteCommand cmd = new SQLiteCommand(qry, DataBaseOperations.DataBaseConnection.con);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if(dt.Rows.Count > 0)
            {
                nameInput.Text = dt.Rows[0]["pName"].ToString();

                string[] priceParts = dt.Rows[0]["pPrice"].ToString().Contains('.') ? dt.Rows[0]["pPrice"].ToString().Split('.') : dt.Rows[0]["pPrice"].ToString().Split(',');
                priceInput.Text = priceParts[0];
                pennyInput.Text = priceParts.Length > 1 ? priceParts[1] : "";

                Byte[] imageArray = (byte[])(dt.Rows[0]["pImage"]);
                imageInput.Image = Image.FromStream(new MemoryStream(imageArray));
            }
        }

        private void priceInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
