using AutoMapper;
using FullProductAssesment.DataModels;
using FullProductAssesment.DTO;
using Microsoft.EntityFrameworkCore;

namespace FullProductAssesment.Services
{
    public class StoreService : IStoreService
    {
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;

        public StoreService (DataContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<int> CreateStore (AddStoreDTO storeDTO)
        {
            var store = _mapper.Map<AddStoreDTO, StoreModel>(storeDTO);
            store.Active = true;
            await _dataContext.AddAsync(store);
            return await _dataContext.SaveChangesAsync();
        }

        public async Task<int> RemoveStore (int StoreId)
        {
            try
            {
                StoreModel storedetails = await _dataContext.Stores.FindAsync(StoreId);
                if (storedetails == null)
                {
                    return -1;
                }
                else
                {
                    storedetails.Active = false;
                    await _dataContext.SaveChangesAsync();
                    return storedetails.StoreID;
                }
            }
            catch
            {
                return -1;
            }
        }
        public async Task<int> RestoreStore(int StoreId)
        {
            try
            {
                StoreModel storedetails = await _dataContext.Stores.FindAsync(StoreId);
                if (storedetails == null)
                {
                    return -1;
                }
                else
                {
                    storedetails.Active = true;
                    await _dataContext.SaveChangesAsync();
                    return storedetails.StoreID;
                }
            }
            catch
            {
                return -1;
            }
        }
        public async Task<GetStoreDTO> UpdateStore(int storeId, GetStoreDTO storeDTO)
        {
            try
            {
                if (storeId == storeDTO.StoreID)
                {
                    StoreModel storeDetails = await _dataContext.Stores.FindAsync(storeId);
                    StoreModel store = _mapper.Map<GetStoreDTO, StoreModel>(storeDTO, storeDetails);
                    var UpdatedStore = _dataContext.Stores.Update(store);
                    await _dataContext.SaveChangesAsync();
                    return _mapper.Map<StoreModel, GetStoreDTO>(UpdatedStore.Entity);
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public async Task<List<GetStoreDTO>> GetAllStores()
        {
            return _mapper.Map<List<StoreModel>, List<GetStoreDTO>>(
            await _dataContext.Stores.ToListAsync());
        }
        public async Task<List<GetStoreDTO>> GetActiveStores()
        {
            return _mapper.Map<List<StoreModel>, List<GetStoreDTO>>(
            await _dataContext.Stores.Where(x => x.Active == true).ToListAsync());
        }
        public async Task<List<GetStoreDTO>> GetInactiveStores()
        {
            return _mapper.Map<List<StoreModel>, List<GetStoreDTO>>(
            await _dataContext.Stores.Where(x => x.Active == false).ToListAsync());
        }
        public async Task<GetStoreDTO> GetSingleStore(int Id)
        {
           var store = await _dataContext.Stores.FirstOrDefaultAsync(c => c.StoreID == Id);
           return _mapper.Map<GetStoreDTO>(store);
        }
    }
}

