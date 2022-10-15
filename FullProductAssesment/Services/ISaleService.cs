using FullProductAssesment.DTO;

namespace FullProductAssesment.Services
{
    public interface ISaleService
    {
        public Task<int> AddSale(AddSalesDTO salesDTO);
        public Task<int> RemoveSale(int saleId);

        public Task<List<GetSaleDTO>> GetSales(DateTime SaleDate, int storeId);
        public Task<List<GetSaleDTO>> GetAllSales();
        public Task<List<GetSaleDTO>> GetAllSalesDate(DateTime saledate);
        public Task<List<GetSaleDTO>> GetAllSalesForAStore(int storeId);
    }
}
