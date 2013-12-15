using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCodeSystems.ShoppingCart
{
    public enum AddressType { Billing, Shipping }

    public interface IAddress
    {
        string AttentionTo { get; set; }
        string CompanyName { get; set; }
        string Address1 { get; set; }
        string Address2 { get; set; }
        string City { get; set; }
        string Province { get; set; }
        string PostalCode { get; set; }
        string Country { get; set; }
        string Phone { get; set; }
        AddressType Type { get; set; }
    }
}
