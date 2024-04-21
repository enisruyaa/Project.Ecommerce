using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.VM.Products
{
    public class ProductVM
    {
        [Required(ErrorMessage = "Ürün İsmi Zorunludur")]
        public string ProductName { get; set; }


        [Required(ErrorMessage = "Ürün Fiyatı Zorunludur")]
        public decimal UnitPrice { get; set; }

        public int? CompaignID { get; set; }

        public int? CategoryID { get; set; }
    }
}
