using AutoMapper;
using FullProductAssesment.DataModels;
using FullProductAssesment.DTO;

namespace FullProductAssesment
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<AddSalesDTO, SalesModel>().ReverseMap();
            CreateMap<AddStoreDTO, StoreModel>().ReverseMap();
            CreateMap<CreateProductDTO, ProductModel>().ReverseMap();
            CreateMap<GetProductDTO, ProductModel>().ReverseMap();
            CreateMap<GetSaleDTO, SalesModel>().ReverseMap();
            CreateMap<GetStoreDTO, StoreModel>().ReverseMap();
            
        }
    }
}
