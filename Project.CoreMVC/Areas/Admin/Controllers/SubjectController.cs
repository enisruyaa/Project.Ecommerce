using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project.BLL.Manager.Abstracts;
using Project.BLL.Manager.Concretes;
using Project.ENTITIES.Models;

namespace Project.CoreMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]
    public class SubjectController : Controller
    {
        readonly ISubjectManager _subManager;

        public SubjectController(ISubjectManager subManager)
        {
            _subManager = subManager;
        }

        public IActionResult Index()
        {
            return View(_subManager.GetAll());
        }

        public IActionResult CreateSubject()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateSubject(Subject model)
        {
            await _subManager.AddAsync(model);
            TempData["Message"] = "İstediğiniz Konu Başarılı Bir Şekilde Oluşturulmuştur";
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteSubject(int id)
        {
            _subManager.Destroy(await _subManager.FindAsync(id));
            TempData["Message"] = "İstediğiniz Konu Başarılı Bir Şekilde Silinmiştir";
            return RedirectToAction("Index");
        }
    }
}
