using Microsoft.Extensions.DependencyInjection;
using Project.DAL.Repositories.Abstracts;
using Project.DAL.Repositories.Concrets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.ServiceInjections
{
    public static class RepositoryService
    {

        #region OnemliNotlar
        /*
        
            Transient Services : Bir Request'in ulaştığı Scop'un parametrrre kümesinde aynı tipten kaç tane varsa o kadar instance alır.. Manager ve Repository'ler için anlamsızdır çünkü bunlardan bir tanesi bir Request'teki Scope için yeterlidir


            Scopedd Services : Bir Request'te Scope'un parametre kümesinde aynı tipte birden fazla parametre olsa bile 1 instance üzerinde  çalışırız. Ancak bu Singleton değildir. Çünkü Request'in işi bittiği zaman garbege collector Ram'den o instance'i kaldırır. Bir Request'in Scop'unda aynı tipte birden fazla instance repository'ler ve Manager'lar için gerekli değildir. O yüzden Scoped tercih edilir.


            Singleton Services : Bir Request'in ulaştığı Scop'un parametre kümesindde bir tip görüldüğü anda instance alınır ve program kapatılana kadar  instance'den devam edilir. Manager ve Repository'ler için çok tehlikelidir!!!!
         
        */
        #endregion

        public static IServiceCollection AddRepServices (this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));

            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IOrderDetailRepository, OrderDetailRepository>();
            services.AddScoped<IAppUserRepository, AppUserRepository>();
            services.AddScoped<IProfileRepository, ProfileRepository>();
            services.AddScoped<ISubjectRepository, SubjectRepository>();
            services.AddScoped<ITicketRepository, TicketRepository>();

            return services;
        }
    }
}
