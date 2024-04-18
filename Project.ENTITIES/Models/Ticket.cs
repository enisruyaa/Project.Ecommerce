using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Ticket : BaseEntity
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public int? AppUserID { get; set; }

        public int? SubjectID { get; set; }

        // Relational Properties

        public virtual AppUser AppUser { get; set; }

        public virtual Subject Subject { get; set; }
    }
}
