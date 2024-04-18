using Project.ENTITIES.Models;

namespace Project.CoreMVC.Areas.Admin.Models.Tickets
{
    public class CreateTicketPageVM
    {
        public Ticket Ticket { get; set; }

        public List<Subject> Subjects { get; set; }
    }
}
