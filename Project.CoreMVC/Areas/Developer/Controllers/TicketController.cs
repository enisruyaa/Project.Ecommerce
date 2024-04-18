using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project.BLL.Manager.Abstracts;

namespace Project.CoreMVC.Areas.Developer.Controllers
{
    [Area("Developer")]
    [Authorize(Roles = "Developer")]
    public class TicketController : Controller
    {
        readonly ITicketManager _ticketMangeer;

        public TicketController(ITicketManager ticketMangeer)
        {
            _ticketMangeer = ticketMangeer;
        }

        public IActionResult Index()
        {
            return View(_ticketMangeer.GetActives());
        }
    }
}
