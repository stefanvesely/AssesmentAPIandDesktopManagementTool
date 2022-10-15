using AutoMapper;
using FullProductAssesment.DataModels;
using FullProductAssesment.DTO;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

namespace FullProductAssesment.Services
{
    public class SaleService : ISaleService
    {
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;

        public SaleService (DataContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<int> AddSale(AddSalesDTO salesDTO)
        {
            var Sale = _mapper.Map<AddSalesDTO, SalesModel>(salesDTO);
            await _dataContext.AddAsync(Sale);
            return await _dataContext.SaveChangesAsync();
        }
        public async Task<int> RemoveSale(int saleId)
        {
            var Sale = await _dataContext.Sales.FindAsync(saleId);
            _dataContext.Sales.Remove(Sale);
            return await _dataContext.SaveChangesAsync();
        }
        public async Task<List<GetSaleDTO>> GetSales(DateTime saledate, int storeId)
        {
            return _mapper.Map<List<SalesModel>, List < GetSaleDTO >> (
            await _dataContext.Sales.Where(x => x.SaleDate.ToString("yyyy-MM-dd") == saledate.ToString("yyyy-MM-dd") && x.StoreId == storeId).ToListAsync());
        }

        public async Task<List<GetSaleDTO>> GetAllSales()
        {
            return _mapper.Map<List<SalesModel>, List<GetSaleDTO>>(await _dataContext.Sales.ToListAsync());
        }
        public async Task<List<GetSaleDTO>> GetAllSalesDate(DateTime saledate)
        {
            return _mapper.Map<List<SalesModel>, List<GetSaleDTO>>(
            await _dataContext.Sales.Where(x => x.SaleDate.ToString("yyyy-MM-dd") == saledate.ToString("yyyy-MM-dd")).ToListAsync());
        }
        public async Task<List<GetSaleDTO>> GetAllSalesForAStore(int storeId)
        {
            return _mapper.Map<List<SalesModel>, List<GetSaleDTO>>(
            await _dataContext.Sales.Where(x => x.StoreId == storeId).ToListAsync());
        }
    }
}
