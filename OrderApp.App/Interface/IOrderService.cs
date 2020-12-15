using OrderApp.App.Dto;
using System.Threading.Tasks;

namespace OrderApp.App.Interface
{
    public interface IOrderService
    {
        Task<bool> SaveToDb(OrderDto dto);

        bool SaveToXml(OrderDto dto);
    }
}