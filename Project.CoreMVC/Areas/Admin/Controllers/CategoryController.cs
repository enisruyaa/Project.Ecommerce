using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project.BLL.Manager.Abstracts;
using Project.ENTITIES.Models;

namespace Project.CoreMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class CategoryController : Controller
    {
        readonly ICategoryManager _categoryManager;

        public CategoryController(ICategoryManager categoryManager)
        {
            _categoryManager = categoryManager;
        }

        //YZL3170 : Refactor Domain Entity'leri düzenleyin

        // Önemli : Tüm Refactor'lerde (Domain Enitity'leri içeren tüm Refactorlerde) Refactoring'i su yaşam döngününse göre yapın : WM (PageVM/Request/ResponseModel vs) => DTO (Katmanalar Arası haberleşme yapabileceğiniz tek model) => Domain Entity

        // CategoryDTO , Admin Models Categories ResponseModels, RequestModels CategoryRequestModel, CategoryResponseModdel

        public IActionResult Index()
        {
            return View(_categoryManager.GetAll());
        }

        public IActionResult CreateCategory() 
        {
            return View();
        }
        // Normal şartlarda DomainEntity ile çalışmamanız gerekir.. Burada CreateCategoryRequestModel gerekir.
        [HttpPost]
        public async Task<IActionResult> CreateCategory(Category model)
        {
            await _categoryManager.AddAsync(model);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteCategory(int id)
        {
            _categoryManager.Delete(await _categoryManager.FindAsync(id));
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DestroyCategory(int id)
        {
            TempData["Message"] = _categoryManager.Destroy(await _categoryManager.FindAsync(id));
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UpdateCategory(int id)
        {
            return View(await _categoryManager.FindAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> UpdateCategory(Category model)
        {
            await _categoryManager.UpdateAsync(model);
            return RedirectToAction("Index");
        }
    }
}
