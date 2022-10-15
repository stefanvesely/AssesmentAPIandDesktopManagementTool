using AutoMapper;
using FullProductAssesment.DataModels;
using FullProductAssesment.DTO;
using Microsoft.EntityFrameworkCore;

namespace FullProductAssesment.Services
{
    public class ProductService : IProductService
    {
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;

        public ProductService(DataContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<int> CreateProduct (CreateProductDTO productDTO)
        {
            ProductModel product = _mapper.Map<CreateProductDTO, ProductModel>(productDTO);
            product.Active = true;
            _dataContext.Add(product);
            return await _dataContext.SaveChangesAsync();
        }
        public async Task<int> RemoveProduct(int ProductId)
        {
            try
            {
                ProductModel productdetails = await _dataContext.Products.FindAsync(ProductId);
                if (productdetails == null)
                {
                    return -1;
                }
                else
                {
                    productdetails.Active = false;
                    await _dataContext.SaveChangesAsync();
                    return productdetails.ProductID;
                }
            }
            catch
            {
                return -1;
            }
        }
        public async Task<int> RestoreProduct(int ProductId)
        {
            try
            {
                ProductModel productdetails = await _dataContext.Products.FindAsync(ProductId);
                if (productdetails == null)
                {
                    return -1;
                }
                else
                {
                    productdetails.Active = true;
                    await _dataContext.SaveChangesAsync();
                    return productdetails.ProductID;
                }
            }
            catch
            {
                return -1;
            }
        }
        public async Task<GetProductDTO> UpdateProduct(int productId, GetProductDTO productDTO)
        {
            try
            {
                if (productId == productDTO.ProductID)
                {
                    ProductModel productdetails = await _dataContext.Products.FindAsync(productId);
                    ProductModel product = _mapper.Map<GetProductDTO, ProductModel>(productDTO, productdetails);
                    var UpdatedProduct = _dataContext.Products.Update(product);
                    await _dataContext.SaveChangesAsync();
                    return _mapper.Map<ProductModel, GetProductDTO>(UpdatedProduct.Entity);
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
        public async Task<List<GetProductDTO>> GetAllProducts()
        {
            return _mapper.Map<List<ProductModel>, List<GetProductDTO>>(await _dataContext.Products.ToListAsync());
        }
        public async Task<List<GetProductDTO>> GetActiveProducts()
        {
            return _mapper.Map<List<ProductModel>, List<GetProductDTO>>(
            await _dataContext.Products.Where(x => x.Active == true).ToListAsync());
        }
        public async Task<List<GetProductDTO>> GetInactiveProducts()
        {
            return _mapper.Map<List<ProductModel>, List<GetProductDTO>>(
            await _dataContext.Products.Where(x => x.Active == false).ToListAsync());
        }

        public async Task<GetProductDTO> GetSingleProduct(int Id)
        {
            var product = await _dataContext.Products.FirstOrDefaultAsync(c => c.ProductID == Id);
            return _mapper.Map<GetProductDTO>(product);
        }
    }
}
