using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCodeSystems.ShoppingCart
{
    public class ConfigurationMissingException : ConfigurationErrorsException
    {
        public ConfigurationMissingException(string formatString, params object[] args)
            : base(String.Format(formatString, args))
        { }
    }
}
