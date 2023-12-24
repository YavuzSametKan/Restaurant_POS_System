using POS_System.Model;
using POS_System.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        // for accessing frm main
        internal static frmMain _obj;

        // Singleton design pattern
        public static frmMain Instance
        {
            get { if (_obj == null) { _obj = new frmMain(); } return _obj; }
        }

        public static string userName;

        // constructor method overloading
        public frmMain(string userName)
        {
            frmMain.userName = userName;
            InitializeComponent();
        }

        // Method to add controls in main form
        public void AddControls(Form frm)
        {
            CenterPanel.Controls.Clear();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            CenterPanel.Controls.Add(frm);
            frm.Show();
        }

        private void cloaseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            userLabel.Text = userName;
            _obj = this;
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            AddControls(new frmHome());
        }

        private void categoriesBtn_Click(object sender, EventArgs e)
        {
            AddControls(new frmCategoryView());
        }

        private void tablesBtn_Click(object sender, EventArgs e)
        {
            AddControls(new frmTableView());
        }

        private void staffBtn_Click(object sender, EventArgs e)
        {
            AddControls(new frmStaffView());
        }

        private void productsBtn_Click(object sender, EventArgs e)
        {
            AddControls(new frmProductView());
        }

        private void POSBtn_Click(object sender, EventArgs e)
        {
            frmPOS frm = new frmPOS();
            frm.Show();
        }
    }
}
