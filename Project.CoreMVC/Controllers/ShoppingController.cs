using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Project.BLL.Manager.Abstracts;
using Project.CoreMVC.Models.Orders;
using Project.CoreMVC.Models.PageVms;
using Project.CoreMVC.Models.SessionService;
using Project.CoreMVC.Models.ShoppingTools;
using Project.ENTITIES.Models;
using System.Text;
using X.PagedList;

namespace Project.CoreMVC.Controllers
{
    public class ShoppingController : Controller
    {
        readonly IProductManager _productManager;
        readonly ICategoryManager _categoryManager;
        readonly IOrderManager _orderManager;
        readonly IOrderDetailManager _orderDetailManager;
        readonly UserManager<AppUser> _userManager;
        readonly IHttpClientFactory _httpClientFactory;

        public ShoppingController(IProductManager productManager, ICategoryManager categoryManager, IOrderManager orderManager, IOrderDetailManager orderDetailManager, UserManager<AppUser> userManager, IHttpClientFactory httpClientFactory)
        {
            _productManager = productManager;
            _categoryManager = categoryManager;
            _orderManager = orderManager;
            _orderDetailManager = orderDetailManager;
            _userManager = userManager;
            _httpClientFactory = httpClientFactory;
        }

        // List<Product> List Koleksiyon tipi Front End'e sayfalamaya uygun bir koleksiyon değildir.

        //Shooping/Index?page=1 & categoryID = 2
        public IActionResult Index(int? page , int? categoryID)
        {
            //string a = "Cagri";
            // string b = a ?? "Deneme";

            ShoppingPageVM spVm = new()
            {
                Products = categoryID == null ? _productManager.GetActives().ToPagedList(page ?? 1, 5) : _productManager.Where(x => x.CategoryID == categoryID).ToPagedList(page ?? 1, 5),
                Categories = _categoryManager.GetActives()
            };

            if (categoryID != null) TempData["catID"] = categoryID; // Kategori ID Garbage collector ile temizleneceği için bizim de bu kategori id'yi kullanabilmemiz için TempData ile gönderiyoruz. 

            return View(spVm);
        }

        Cart GetCartFromSession(string key)
        {
            return HttpContext.Session.GetObject<Cart>(key);
        }

       void SetCartForSession(Cart c)
        {
            HttpContext.Session.SetObject("scart",c);
        }

        public async Task<IActionResult> AddToCart(int id)
        {
            Cart c = GetCartFromSession("scart") == null ? new Cart() : GetCartFromSession("scart");
            Product productToBeAdded = await _productManager.FindAsync(id);
            CartItem ci = new()
            {
                ID = productToBeAdded.ID,
                ProductName = productToBeAdded.ProductName,
                UnitPrice = productToBeAdded.UnitPrice,
                ImagePath = productToBeAdded.ImagePath,
                CategoryName = productToBeAdded.Category.CategoryName,
                CategoryID = productToBeAdded.CategoryID
            };

            c.AddToCart(ci);

            SetCartForSession(c);

            TempData["Message"] = $"{ci.ProductName} İsimli Ürün Sepete Eklenmiştir. ";

            return RedirectToAction("Index");

        }

        public IActionResult CartPage()
        {
            if (GetCartFromSession("scart") == null)
            {
                TempData["Message"] = "Sepetiniz Şu Anda Boş";
                return RedirectToAction("Index");
            }

            Cart c = GetCartFromSession("scart");
            return View(c); // Todo: PageVM refactoring'i unutmayınnız.
        }

        void ControlCart(Cart c)
        {
            if (c.GetCartItems.Count == 0) HttpContext.Session.Remove("scart");
        }

        public IActionResult DeleteFromCart(int id)
        {
            if (GetCartFromSession("scart") != null)
            {
                Cart c = GetCartFromSession("scart");
                c.RemoveFromCart(id);
                SetCartForSession(c);
                ControlCart(c);
            }
            return RedirectToAction("CartPage");  
        }

        public IActionResult DecreaseFromCart(int id)
        {
            if (GetCartFromSession("scart") != null)
            {
                Cart c = GetCartFromSession("scart");
                c.Decrease(id);
                SetCartForSession(c);
                ControlCart(c);
            }

            return RedirectToAction("CartPage");
        }

        public IActionResult ConfirmOrder()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ConfirmOrder(OrderRequestPageVM ovm)
        {
            Cart c = GetCartFromSession("scart");
            ovm.Order.PriceOfOrder = ovm.PaymentRequestModel.ShoppingPrice = c.TotalPrice;

            //http://localhost:5085/
            // API Entegrasyonu

            #region APIIntegration

            HttpClient client = _httpClientFactory.CreateClient();
            string jsonData = JsonConvert.SerializeObject(ovm.PaymentRequestModel);

            //Content : İçerik
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            HttpResponseMessage responseMessage = await client.PostAsync("http://localhost:5085/api/Transaction",content);

            if (responseMessage.IsSuccessStatusCode)
            {
                // Projeyi 0'dan yazarken denememiz gerektiği için bu iç kısmı ilk olarak yazar deneriz ardından api enrtegrasyonu yapıp bir de öyle kontrol sağlarız.
                if (User.Identity.IsAuthenticated)
                {
                    AppUser appUser = await _userManager.FindByNameAsync(User.Identity.Name);
                    ovm.Order.AppUserID = appUser.Id; // Normalde Order'in içerisinde Email ve NameDescription null geçilebilir olması gereken şeylerdir. Çünkü UserId zaten sistemdedir ve Order'in Email'ine gerek yoktur. Lakin bu duruumda üye olmayan'da alışveriş yapabilsin diye bu noktada onları Required olarak tanımlamak gerekir. (PureVM'de)
                    ovm.Order.Email = appUser.Email; // Normalde bunların böyle verilmesine gerek yok string propertyî nullable yapabilirdik. (.Net 6 'da artık referans tiplere özellikle null geçilebilir demezseniz veritabanında not nullable olarak gidiyor.) Acak Entities'in düzenini tekrar bozmamak adına böyle bir yöntem tercih ettik.  
                    ovm.Order.NameDescription = appUser.UserName;
                }

                await _orderManager.AddAsync(ovm.Order); // Önce  Order'in ID'sinin oluşması lazım.. Burada Order'i kaydederek o ID'nin Identity sayesinde oluşmasını sağlıyoruz.

                //string urunIsimleri = null;
                foreach (CartItem item in c.GetCartItems)
                {
                    OrderDetail od = new();
                    od.OrderID = ovm.Order.ID;
                    od.ProductID = item.ID;
                    od.Quantity = item.Amount;
                    od.UnitPrice = item.UnitPrice;
                    await _orderDetailManager.AddAsync(od);
                    //urunIsimleri += item.ProductName;
                }

                TempData["Message"] = "Siparişiniz Bize Başarıyla Ulaşmıştır... Teşekkür Ederiz";

                return RedirectToAction("Index");
            }

            string result = await responseMessage.Content.ReadAsStringAsync();
            TempData["Message"] = result;
            return RedirectToAction("Index");

            #endregion

        }

    }
}

/*

            Amaç => Siparişi Kaydetmek 
    1-> Kullanıcı Bilgisini Al
    2-> Sepeti Session'an Al
    3-> Bilgileri analiz et ve veritabanından kullanıcıyı al (Değilse zaten modelbinding işini halledecektir.)
*/