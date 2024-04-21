using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class ProductCompaign : BaseEntity
    {
        public int CompaignID { get; set; }

        public int ProductID { get; set; }

        // Relational Properties

        public virtual Compaign Compaign { get; set; }

        public virtual Product Product { get; set; }
    }
}
