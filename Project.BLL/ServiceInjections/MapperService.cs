using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Project.BLL.MapperProfile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.ServiceInjections
{
    public static class MapperService
    {
        public static void AddMapperService(this IServiceCollection services)
        {
            MapperConfiguration mapConfiguration = new MapperConfiguration( opt =>
            {
                opt.AddProfile(new CategoryProfile());
                opt.AddProfile(new ProductProfile());
            });

            IMapper mapper = mapConfiguration.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
