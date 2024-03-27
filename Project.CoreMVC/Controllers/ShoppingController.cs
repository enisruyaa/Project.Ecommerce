using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project.BLL.Manager.Abstracts;
using Project.CoreMVC.Models.PageVms;
using Project.ENTITIES.Models;
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

        public ShoppingController(IProductManager productManager, ICategoryManager categoryManager, IOrderManager orderManager, IOrderDetailManager orderDetailManager, UserManager<AppUser> userManager)
        {
            _productManager = productManager;
            _categoryManager = categoryManager;
            _orderManager = orderManager;
            _orderDetailManager = orderDetailManager;
            _userManager = userManager;
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
    }
}
