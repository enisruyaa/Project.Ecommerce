using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Campaign : BaseEntity
    {
        public int StartMount { get; set; }

        public int EndMount { get; set; }

        public int StartYear { get; set; }

        public int EndYear { get; set; }

        // Relational Properties

        public virtual ICollection<ProductCompaign> ProductCompaigns { get; set; }
    }
}
