using OrderApp.App.Dto;
using OrderApp.App.Interface;
using OrderApp.App.Observer;
using System.Collections.Generic;

namespace OrderApp.App.Service
{
    public class ProductService : IProductService
    {
        private readonly IObserver _observer;

        public ProductService(IObserver observer)
        {
            _observer = observer;
        }

        /// <summary>
        /// Method responsible for add new product to list and update UI
        /// </summary>
        /// <param name="product">Data transfer object with all data</param>
        public void AddProductToList(ProductDto product)
        {
            product.Id = ActualOrder.Products.Count + 1;
            ActualOrder.Products.Add(product);
            _observer.Update();
        }

        /// <summary>
        /// Method responsible for clear product list and update UI
        /// </summary>
        public void ClearList()
        {
            ActualOrder.Products = new List<ProductDto>();
            _observer.Update();
        }

        /// <summary>
        /// Method responsible for edit product in list and update UI
        /// </summary>
        /// <param name="product">Data transfer object with all data</param>
        public void EditProduct(ProductDto product)
        {
            ActualOrder.Products[product.Id - 1].Name = product.Name;
            _observer.Update();
        }

        /// <summary>
        /// Method responsible for get product from list and update UI
        /// </summary>
        /// <param name="product">Data transfer object with all data</param>
        public ProductDto GetProduct(int productId)
        {
            return ActualOrder.Products[productId];
        }

        /// <summary>
        /// Method responsible for remove product from list and update UI
        /// </summary>
        /// <param name="product">Data transfer object with all data</param>
        public void RemoveProduct(int productId)
        {
            ActualOrder.Products.RemoveAt(productId);
            _observer.Update();
        }
    }
}