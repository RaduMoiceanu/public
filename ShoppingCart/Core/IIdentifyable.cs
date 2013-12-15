using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCodeSystems.ShoppingCart
{
    public interface IIdentifyable
    {
        /// <summary>
        /// Identifier used to uniquely identify each instance
        /// </summary>
        string Id { get; set; }
    }
}
