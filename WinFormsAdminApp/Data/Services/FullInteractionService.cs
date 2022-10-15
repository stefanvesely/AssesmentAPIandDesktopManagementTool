using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsAdminApp.DataModel;
using WinFormsAdminApp.DockingForms;

namespace WinFormsAdminApp.Data.Services
{
    internal class FullInteractionService
    {
        private TestDBEntities _dbContext = new TestDBEntities();
        
        public FullInteractionService (TestDBEntities testDBEntities)
        {
            _dbContext = testDBEntities;
        }

        public async Task<bool> AddProduct (Product product)
        {
            int count = await Task.Run(() => _dbContext.Products.Where(c => c.ProductName == product.ProductName).ToList().Count);
            if (count > 0)
            {
                return false;
            }
            _dbContext.Products.Add(product);
            await Task.Run(() => _dbContext.SaveChanges());
            return true;
        }

        public async Task<List<Product>> GetAllProducts ()
        {
            return await Task.Run(() => _dbContext.Products.ToList());
        }

        public async Task<bool> UpdateProduct(Product product)
        {
            Product update = _dbContext.Products.First(c => c.ProductID == product.ProductID);
            if (update != null)
            {
                update.ProductName = product.ProductName;
                update.Price = product.Price;
                update.Active = product.Active;
                await _dbContext.SaveChangesAsync();
                return true;
            }
            else
            {
                _dbContext.Products.Add(product);
            }           
            return true;
        }
        public async Task<List<Store>> GetAllStores()
        {
            return await Task.Run(() => _dbContext.Stores.ToList());
        }
        public async Task<bool> AddStore(Store store)
        {
            int count = await Task.Run(() => _dbContext.Stores.Where(c => c.StoreName == store.StoreName).ToList().Count);
            if (count > 0)
            {
                return false;
            }
            _dbContext.Stores.Add(store);
            await Task.Run(() => _dbContext.SaveChanges());
            return true;
        }
        public async Task<bool> UpdateStore(Store store)
        {
            Store update = _dbContext.Stores.First(c => c.StoreID == store.StoreID);
            if (update != null)
            {
                update.StoreName = store.StoreName;
                update.Address = store.Address;
                update.Telephone = store.Telephone;
                update.Active = store.Active;
                await _dbContext.SaveChangesAsync();
                return true;
            }
            else
            {
                _dbContext.Stores.Add(store);
            }
            return true;
        }

        public async Task<List<Sale>> GetAllSales()
        {
            return await Task.Run(() => _dbContext.Sales.ToList());
        }

        public async Task<List<Sale>> AddSale (Sale sale)
        {
            _dbContext.Sales.Add(sale);
            await _dbContext.SaveChangesAsync();
            return await Task.Run(() => _dbContext.Sales.Where(c => c.StoreId == sale.StoreId).ToList());
        }
        public async Task<int> RemoveSale(int saleId)
        {
            var Sale = await _dbContext.Sales.FindAsync(saleId);
            _dbContext.Sales.Remove(Sale);
            return await _dbContext.SaveChangesAsync();
        }       
    }
}
