using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Project.DAL.ContextClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.ServiceInjections
{
    //DbContextPool'umuz böylece Start'up DAl'dan bir sınıfı kullanmaktan ziyade sadece BLL'deki bu yaratılmış olan class'ın kurallarıyla bir Service entegrasyonu yapacaktır
    public static class DbContextService
    {
        public static IServiceCollection AddDbContextServices(this IServiceCollection services)
        {
            // Neden Service Provider

            // Çünkü biz bu noktada aslında bir Core.MVC platformundaki startup dosyasında değiliz. Dolayısıyla oradaki hazır serbice elimizde yok. Biz o yapıları ayağa kaldırmak adına bir giriş noktasına ihtiyac duyarız ve bu giriş noktasını bbana ServiceProvider nesnesi sağlar

            ServiceProvider provider = services.BuildServiceProvider();

            // Sakın IConfiguration kullanırken Castle kütüphanesini kullanmayın.. Kullanacağınız kütüphane Microsoft.Extensions.Configuration olmak zorundadır.

            // Neden IConfiguration

            // IConfiguration sayesinde projemizin conf.(ayarlamalarının) bulunduğu dosyaya ulaşabiliyorsunuz...

            IConfiguration configuration = provider.GetService<IConfiguration>();

            services.AddDbContextPool<MyContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("MyConnection")).UseLazyLoadingProxies());

            return services;
        }
    }
}
