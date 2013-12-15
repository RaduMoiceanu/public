using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCodeSystems.ShoppingCart
{
    public interface ICheckoutCart : ICart
    {
        string Email { get; set; }
        string Name { get; set; }
        string CustomerAccountId { get; set; }

        IAddress BillingAddress { get; set; }
        IAddress ShippingAddress { get; set; }

        string OrderNumber { get; set; }
        DateTime OrderDate { get; set; }
    }
}
