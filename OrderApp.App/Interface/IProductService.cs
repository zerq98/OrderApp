using OrderApp.App.Dto;

namespace OrderApp.App.Interface
{
    public interface IProductService
    {
        void AddProductToList(ProductDto product);

        void EditProduct(ProductDto product);

        void RemoveProduct(int productId);

        ProductDto GetProduct(int productId);

        void ClearList();
    }
}