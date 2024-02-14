using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS_System.Classes;

namespace POS_System.Model
{
    public partial class ucProduct : UserControl
    {
        public ucProduct()
        {
            InitializeComponent();
        }

        public event EventHandler onSelect = null;
        public int id { get; set; }
        public string PPrice { get; set; }
        public string PCategory { get; set; }
        public string PName { get { return nameLabel.Text; } set { nameLabel.Text = value; } }
        public Image PImage { get { return imageInput.Image; } set { imageInput.Image = value; } }

        private void imageInput_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }
    }
}
