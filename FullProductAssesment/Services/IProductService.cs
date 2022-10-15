using FullProductAssesment.DTO;

namespace FullProductAssesment.Services
{
    public interface IProductService
    {
        public Task<int> CreateProduct(CreateProductDTO productDTO);
        public Task<int> RemoveProduct(int ProductId);
        public Task<int> RestoreProduct(int ProductId);
        public Task<GetProductDTO> UpdateProduct(int productId, GetProductDTO productDTO);
        public Task<List<GetProductDTO>> GetAllProducts();
        public Task<List<GetProductDTO>> GetActiveProducts();
        public Task<List<GetProductDTO>> GetInactiveProducts();
        public Task<GetProductDTO> GetSingleProduct(int Id);
    }
}
