using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsAdminApp.Data.Services;
using WinFormsAdminApp.DataModel;
using WinFormsAdminApp.UniveralClasses;

namespace WinFormsAdminApp.DockingForms
{
    public partial class Products : Form
    {
        private int SelectedProduct = -1;
        private List<Product> CurrentProducts = new List<Product>();
        private FullInteractionService _fis;
        private LoadingClass _loadingClass = new LoadingClass();
        public Products()
        {
            InitializeComponent();
            _fis = new FullInteractionService(new TestDBEntities());
            LoadProducts();            
        }

        public async Task LoadProducts()
        {
            _loadingClass.ShowLoading();
            CurrentProducts.Clear();
            CurrentProducts = await _fis.GetAllProducts();
            UpdateForm();
            _loadingClass.CloseLoading();
        }

        private void UpdateForm()
        {
            dgvProducts.Rows.Clear();
            foreach (Product product in CurrentProducts)
            {
                dgvProducts.Rows.Add(product.ProductID, product.ProductName, product.Price, product.Active);
            }
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbName.Enabled = true;
            tbPrice.Enabled = true;
            cbActive.Enabled = true;
            btnSave.Enabled = true;
            int iSelectedIndex = dgvProducts.CurrentCell.RowIndex;
            tbName.Text = dgvProducts.Rows[iSelectedIndex].Cells[1].Value.ToString();
            tbPrice.Text = dgvProducts.Rows[iSelectedIndex].Cells[2].Value.ToString();
            cbActive.Checked =Convert.ToBoolean(dgvProducts.Rows[iSelectedIndex].Cells[3].Value.ToString());
            btnSave.Text = "Save "+ dgvProducts.Rows[iSelectedIndex].Cells[1].Value.ToString();
            SelectedProduct = int.Parse(dgvProducts.Rows[iSelectedIndex].Cells[0].Value.ToString());
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            btnSave.Text = "Save " + tbName.Text;
            if (tbName.Text.Length == 0)
            {
                btnSave.Enabled = false;
            }
        }

        private void tbNumberValidator(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox == null) return;
            var text = textBox.Text;
            var output = new StringBuilder();
            var dotEncountered = false;
            for (int i = 0; i < text.Length; i++)
            {
                var c = text[i];
                if (char.IsDigit(c))
                {
                    output.Append(c);
                }
                else if (!dotEncountered && c == ',')
                {  
                    output.Append(c);
                    dotEncountered = true;
                }
            }
            var newText = output.ToString();
            textBox.Text = newText;
            textBox.SelectionStart = textBox.Text.Length;
            textBox.SelectionLength = 0;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            bool cb = cbActive.Checked;
            DialogResult YesNo = MessageBox.Show("Are you sure you want to change " +
                dgvProducts.Rows[dgvProducts.CurrentCell.RowIndex].Cells[1].Value.ToString() + "?", 
                "Sure?", MessageBoxButtons.YesNo);
            if (YesNo == DialogResult.Yes)
            {
                await SaveProduct(new Product()
                {
                    ProductID = int.Parse(dgvProducts.Rows[dgvProducts.CurrentCell.RowIndex].Cells[0].Value.ToString()),
                    ProductName = tbName.Text,
                    Price = decimal.Parse(tbPrice.Text),
                    Active = cbActive.Checked
                });
                await LoadProducts();
            }
        }
        async Task SaveProduct (Product updateproduct)
        {
            await _fis.UpdateProduct(updateproduct);
        }

        private async void btnNew_Click(object sender, EventArgs e)
        {
            await _fis.AddProduct(new Product()
            {
                ProductName = tbNewName.Text,
                Price = decimal.Parse(tbNewPrice.Text)              
            });
            await LoadProducts();
        }
    }
}
