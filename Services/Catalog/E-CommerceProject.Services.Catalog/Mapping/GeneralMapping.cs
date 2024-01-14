using AutoMapper;
using E_CommerceProject.Services.Catalog.Dtos.CategoryDtos;
using E_CommerceProject.Services.Catalog.Dtos.ProductDtos;
using E_CommerceProject.Services.Catalog.Models;

namespace E_CommerceProject.Services.Catalog.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Category, ResultCategoryDto>();
            CreateMap<ResultCategoryDto, Category>();

            CreateMap<Category,CreateCategoryDto>().ReverseMap();
            CreateMap<Category,UpdateCategoryDto>().ReverseMap();

            CreateMap<Product, ResultProductDto>().ReverseMap();
            CreateMap<Product,CreateProductDto>().ReverseMap();
            CreateMap<Product,UpdateProductDto>().ReverseMap();
        }
    }
}
