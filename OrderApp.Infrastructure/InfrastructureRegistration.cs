using OrderApp.Domain.Interface;
using OrderApp.Infrastructure.Repository;
using SimpleInjector;

namespace OrderApp.Infrastructure
{
    public static class InfrastructureRegistration
    {
        /// <summary>
        /// Registration dependency between IOrderRepository and OrderRepository in main container
        /// </summary>
        /// <param name="container">Main container</param>
        public static void Register(Container container)
        {
            container.Register<IOrderRepository, OrderRepository>(Lifestyle.Transient);
        }
    }
}