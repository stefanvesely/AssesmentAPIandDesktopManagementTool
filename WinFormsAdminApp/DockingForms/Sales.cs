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

namespace WinFormsAdminApp.DockingForms
{
    public partial class Sales : Form
    {
        FullInteractionService _fic;
        List<Store> StoreList = new List<Store>();
        List<Product> ProductList = new List<Product>();
        List<Sale> SaleList = new List<Sale>();
        private int StoreId = -1;
        private string StoreName = "";
        private int ProductId = -1;
        private string ThisProductName = "";
        private decimal ProductPrice = 0;
        private int CurrentlySelectedSaleId = -1;

        public Sales()
        {
            InitializeComponent();
            _fic = new FullInteractionService(new TestDBEntities());
            FirstLoad();
        }

        private async void FirstLoad()
        {
            StoreList = await _fic.GetAllStores();
            ProductList = await _fic.GetAllProducts();
            SaleList = await _fic.GetAllSales();
            foreach (Store store in StoreList)
            {
                if (store.Active)
                {
                    dgvStores.Rows.Add(store.StoreID, store.StoreName);
                }
            }
            foreach (Product product in ProductList)
            {
                if (product.Active)
                {
                    dgvProducts.Rows.Add(product.ProductID, product.ProductName);
                }
            }
            await RefreshSales();
        }

        private async void btnSell_Click(object sender, EventArgs e)
        {
            if (ThisProductName != "" && StoreName != "" && ProductId != -1 && StoreId != -1)
            {
                string Message = "Are you sure " + StoreName + ", has sold " + nudSales.Value.ToString() + ", " + ThisProductName + "(s) at " + ProductPrice.ToString() + "?";
                DialogResult = MessageBox.Show(Message, "Sure?", MessageBoxButtons.YesNo);
                if (DialogResult == DialogResult.Yes)
                {
                    await _fic.AddSale(new Sale()
                    {
                        SaleDate = DateTime.Now,
                        StoreId = StoreId,
                        ProductId = ProductId,
                        Quantity = ((int)nudSales.Value)
                    });
                }

            }
            await RefreshSales();
        }

        private async void dgvStores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            StoreName = dgvStores.Rows[dgvStores.CurrentCell.RowIndex].Cells[1].Value.ToString();
            StoreId = int.Parse(dgvStores.Rows[dgvStores.CurrentCell.RowIndex].Cells[0].Value.ToString());
            await RefreshSales();
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ThisProductName = dgvProducts.Rows[dgvProducts.CurrentCell.RowIndex].Cells[1].Value.ToString();
            ProductId = int.Parse(dgvProducts.Rows[dgvProducts.CurrentCell.RowIndex].Cells[0].Value.ToString());
            ProductPrice = ProductList.First(c=> c.ProductID == ProductId).Price;
        }

        private void dgvSales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CurrentlySelectedSaleId = int.Parse(dgvSales.Rows[dgvSales.CurrentCell.RowIndex].Cells[0].Value.ToString());

        }

        private async void btnRemoveSale_Click(object sender, EventArgs e)
        {
            if (CurrentlySelectedSaleId != -1 && dgvSales.CurrentCell.RowIndex != -1)
            {
                await _fic.RemoveSale(CurrentlySelectedSaleId);
                CurrentlySelectedSaleId = -1;
            }
            await RefreshSales();
        }

        private async Task RefreshSales ()
        {
            SaleList.Clear();
            dgvSales.Rows.Clear();
            SaleList = await _fic.GetAllSales();
            if (StoreId != -1)
            {
                foreach (Sale sale in SaleList.Where(c=> c.StoreId == StoreId).ToList())
                {
                    dgvSales.Rows.Add(sale.SaleId, sale.SaleDate);
                }
            }
        }
    }
}
