using OrderApp.Domain.Entity;
using System.Threading.Tasks;

namespace OrderApp.Domain.Interface
{
    public interface IOrderRepository
    {
        Task SaveOrderToDb(Order order);

        void SaveOrderToXml(Order order);
    }
}