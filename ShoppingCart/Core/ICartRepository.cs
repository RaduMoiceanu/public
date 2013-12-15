using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCodeSystems.ShoppingCart
{
    public interface ICartRepository : IRepository<ICart, string>
    {
    }
}
