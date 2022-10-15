using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsAdminApp.DataModel;
using WinFormsAdminApp.DockingForms;

namespace WinFormsAdminApp
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            CloseMDIChildren();
            Products obj = new Products();
            obj.MdiParent = this;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }
        
        private void btnStores_Click(object sender, EventArgs e)
        {
            CloseMDIChildren();
            Stores obj = new Stores();
            obj.MdiParent = this;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            CloseMDIChildren();
            Sales obj = new Sales();
            obj.MdiParent = this;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }
        private void CloseMDIChildren()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
        }
    }
}
