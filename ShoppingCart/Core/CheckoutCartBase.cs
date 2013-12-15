using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCodeSystems.ShoppingCart
{
    [Serializable]
    public class CheckoutCartBase : CartBase, ICheckoutCart
    {
        public string Email { get; set; }

        public string Name { get; set; }

        public string CustomerAccountId { get; set; }

        public IAddress BillingAddress { get; set; }

        public IAddress ShippingAddress { get; set; }

        public string OrderNumber { get; set; }

        public DateTime OrderDate { get; set; }
    }
}
