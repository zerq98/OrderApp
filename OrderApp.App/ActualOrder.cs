using OrderApp.App.Dto;
using System.Collections.Generic;

namespace OrderApp.App
{
    internal static class ActualOrder
    {
        /// <summary>
        /// List of products, displayed in data grid view in UI. This list store all products added to list.
        /// When save to database or xml file is selected, this list is used to map and add products to order instance
        /// </summary>
        public static List<ProductDto> Products { get; set; } = new List<ProductDto>();
    }
}