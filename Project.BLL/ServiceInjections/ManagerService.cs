using Microsoft.Extensions.DependencyInjection;
using Project.BLL.Manager.Abstracts;
using Project.BLL.Manager.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.ServiceInjections
{
    public static class ManagerService
    {
        public static IServiceCollection AddManagerServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IManager<>), typeof(BaseManager<>));

            services.AddScoped<IAppUserManager, AppUserManager>();
            services.AddScoped<ICategoryManager, CategoryManager>();
            services.AddScoped<IOrderManager, OrderManager>();
            services.AddScoped<IOrderDetailManager, OrderDetailManager>();
            services.AddScoped<IProductManager, ProductManager>();
            services.AddScoped<IProfileManager, ProfileManager>();
            services.AddScoped<ISubjectManager, SubjectManager>();
            services.AddScoped<ITicketManager, TicketManager>();
            
            return services;
        }
    }
}
