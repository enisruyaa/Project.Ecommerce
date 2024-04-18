using Project.BLL.Manager.Abstracts;
using Project.DAL.Repositories.Abstracts;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.Manager.Concretes
{
    public class TicketManager : BaseManager<Ticket> , ITicketManager
    {
        readonly ITicketRepository _tRap;

        public TicketManager(ITicketRepository tRap) : base(tRap) 
        {
            _tRap = tRap;
        }
    }
}
