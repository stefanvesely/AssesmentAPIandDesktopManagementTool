using FullProductAssesment.DTO;

namespace FullProductAssesment.Services
{
    public interface IStoreService
    {
        public Task<int> CreateStore(AddStoreDTO storeDTO);
        public Task<int> RemoveStore(int StoreId);
        public Task<int> RestoreStore(int StoreId);
        public Task<GetStoreDTO> UpdateStore(int storeId, GetStoreDTO storeDTO);
        public Task<List<GetStoreDTO>> GetAllStores();
        public Task<List<GetStoreDTO>> GetActiveStores();
        public Task<List<GetStoreDTO>> GetInactiveStores();
        public Task<GetStoreDTO> GetSingleStore(int Id);
    }
}
