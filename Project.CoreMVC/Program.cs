using Project.BLL.ServiceInjections;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDistributedMemoryCache(); // E�er Session Kompleks yap�lar i�iin Extension meyodu ekleme durumuna maruz kal�rsa bu kod projemizin sa�l�kl� �al��mas� i�in gereklidir.

builder.Services.AddSession(x =>
{
    x.IdleTimeout = TimeSpan.FromDays(1); //Projeyi ki�inin bos durma s�resi eger 5 dakikal�k bir s�re olursa Session bosa c�ks�n
    x.Cookie.HttpOnly = true; //document.cookie'den ilgili bilginin g�zlemlenmesi
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

app.UseSession(); // Sesiion kullan�labilir olsun diye yazmam�z gerekiyor.

app.UseAuthentication(); // Rol tan�mlamas� olmdan g�rev tan�mlamas� olmaz.

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Register}/{id?}");

app.Run();
