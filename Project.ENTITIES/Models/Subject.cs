using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Subject : BaseEntity
    {
        public string SubjectName { get; set; }

        // Relatioanl Properties

        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
