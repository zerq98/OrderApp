using OrderApp.App.Interface;
using OrderApp.App.Service;
using SimpleInjector;

namespace OrderApp.App
{
    public static class AppRegistration
    {
        /// <summary>
        /// Registration dependency between IOrderService and OrderService in main container
        /// </summary>
        /// <param name="container">Main container</param>
        public static void Register(Container container)
        {
            container.Register<IOrderService, OrderService>(Lifestyle.Transient);
        }
    }
}