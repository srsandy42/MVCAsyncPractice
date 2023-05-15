using AutoMapper;
using MvcasyncProject.Dto;
using MvcasyncProject.Models;

namespace MvcasyncProject.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
        }
    }
}
