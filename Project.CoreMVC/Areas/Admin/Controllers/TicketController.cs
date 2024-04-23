using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project.BLL.Manager.Abstracts;
using Project.CoreMVC.Areas.Admin.Models.Tickets;
using Project.ENTITIES.Models;

namespace Project.CoreMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]
    public class TicketController : Controller
    {
        readonly ITicketManager _ticketManager;
        readonly ISubjectManager _subjectManager;

        public TicketController(ITicketManager ticketManager, ISubjectManager subjectManager)
        {
            _ticketManager = ticketManager;
            _subjectManager = subjectManager;
        }

        public IActionResult Index()
        {
            return View(_ticketManager.GetAll());
        }

        public IActionResult CreateTicket()
        {
            CreateTicketPageVM tPVM = new ()
            {
                Subjects = _subjectManager.GetAll(),
            };
            return View(tPVM);
        }
        [HttpPost]
        public async Task<IActionResult> CreateTicket(Ticket ticket)
        {
            TempData["Message"] = await _ticketManager.AddAsync(ticket); 
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteTicket(int id)
        {
            _ticketManager.Delete(await _ticketManager.FindAsync(id));
            return RedirectToAction("Index");
        }
    }
}
