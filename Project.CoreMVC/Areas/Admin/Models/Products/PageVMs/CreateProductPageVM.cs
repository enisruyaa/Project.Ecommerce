using Project.ENTITIES.Models;

namespace Project.CoreMVC.Areas.Admin.Models.Products.PageVMs
{
    public class CreateProductPageVM
    {
        // Refactor Domain Entityleri Düzenleyin

        public List<Category> Categories { get; set; }

        public Product Product { get; set; }
    }
}
