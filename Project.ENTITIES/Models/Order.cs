using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Order : BaseEntity
    {
        public string ShippingAddress { get; set; } // Kullanıcının siparişi talep ettiği (Siparişin Gönderileceği) adres

        public string Email { get; set; } // Üye olmadan bir kullanıcının email'i özel olarak burada tutulur (Null Geçildiyse anlayın ki kullanıcı üye olarak alışveriş yapmıştır)

        public string NameDescription { get; set; } // Üye olmadan bir kullanıcının isim açıklması burada tutulur (null geçildiyse anlayın ki kullanıcı üye olarak alış veriş yapmıştır)

        public int? AppUserID { get; set; } // null geçilebiliyorsa anlayın ki kullanıcı üye değildir.

        public decimal PriceOfOrder { get; set; } // Siparişin Toplam Tutarı (Sepetin onaylanan fiyatı)

        public int? ShipperID { get; set; }

        // Relational Properties

        public virtual AppUser AppUser { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        public virtual Shipper Shipper { get; set; }
    }
}
