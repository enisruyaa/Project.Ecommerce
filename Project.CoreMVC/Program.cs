using Project.BLL.ServiceInjections;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDistributedMemoryCache(); // Eðer Session Kompleks yapýlar içiin Extension meyodu ekleme durumuna maruz kalýrsa bu kod projemizin saðlýklý çalýþmasý için gereklidir.

builder.Services.AddSession(x =>
{
    x.IdleTimeout = TimeSpan.FromDays(1); //Projeyi kiþinin bos durma süresi eger 5 dakikalýk bir süre olursa Session bosa cýksýn
    x.Cookie.HttpOnly = true; //document.cookie'den ilgili bilginin gözlemlenmesi
    x.Cookie.IsEssential = true;
});

builder.Services.AddIdentityServices();

builder.Services.AddDbContextServices(); // DbContextService'imizi BLL'den alarak middleware!'e entegre etttik.

builder.Services.AddRepServices();

builder.Services.AddManagerServices();


WebApplication app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseSession(); // Sesiion kullanýlabilir olsun diye yazmamýz gerekiyor.

app.UseAuthentication(); // Rol tanýmlamasý olmdan görev tanýmlamasý olmaz.

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Register}/{id?}");

app.Run();
