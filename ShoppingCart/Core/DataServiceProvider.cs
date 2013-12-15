using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Castle.Core.Resource;
using Castle.Windsor;
using Castle.Windsor.Configuration.Interpreters;

namespace iCodeSystems.ShoppingCart
{
    /// <summary>
    /// Data access provider using IoC (inversion of concern) and repository pattern to access data
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public static class DataServiceProvider<TEntity> where TEntity : IIdentifyable
    {
        private static readonly IWindsorContainer container;

        /// <summary>
        /// Gets the configured data repository
        /// </summary>
        public static IRepository<TEntity, string> Repository 
        {
            get
            {
                return container.Resolve<IRepository<TEntity, string>>();
            }
        }

        static DataServiceProvider()
        {
            container = new WindsorContainer(new XmlInterpreter(new ConfigResource("castle")));
        }
    }
}
