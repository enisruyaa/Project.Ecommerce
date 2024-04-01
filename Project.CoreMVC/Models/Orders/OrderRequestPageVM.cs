using Project.CoreMVC.Models.OutherRequestModel;
using Project.ENTITIES.Models;

namespace Project.CoreMVC.Models.Orders
{
    public class OrderRequestPageVM
    {
        //Refactor

        public Order Order { get; set; }

        public PaymentRequestModel PaymentRequestModel { get; set; }
    }
}
