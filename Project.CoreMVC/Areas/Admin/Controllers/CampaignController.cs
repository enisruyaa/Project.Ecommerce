using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project.BLL.Manager.Abstracts;
using Project.ENTITIES.Models;

namespace Project.CoreMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]
    public class CampaignController : Controller
    {
        readonly ICampaignManager _campaignManager;

        public CampaignController(ICampaignManager campaignManager)
        {
            _campaignManager = campaignManager;
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Campaign model)
        {
            _campaignManager.Add(model);
            return View();
        }
    }
}
