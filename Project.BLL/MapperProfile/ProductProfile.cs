using AutoMapper;
using Project.BLL.DTOClasses;
using Project.ENTITIES.Models;
using Project.VM.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.MapperProfile
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductDTO>().ReverseMap();
            CreateMap<Product, ProductVM>().ReverseMap();
        }
    }
}
