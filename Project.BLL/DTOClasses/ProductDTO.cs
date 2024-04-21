using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DTOClasses
{
    public class ProductDTO : BaseDTO
    {
        public string ProductName { get; set; }

        public decimal UnitPrice { get; set; }

        public int StartMount { get; set; }

        public int EndMount { get; set; }

        public int StartYear { get; set; }

        public int EndYear { get; set; }
    }
}
