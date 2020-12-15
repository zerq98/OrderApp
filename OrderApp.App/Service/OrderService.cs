using AutoMapper;
using OrderApp.App.Dto;
using OrderApp.App.Interface;
using OrderApp.Domain.Entity;
using OrderApp.Domain.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace OrderApp.App.Service
{
    /// <summary>
    /// Service responsible for logic associated with orders
    /// </summary>
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly Mapper _mapper;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<OrderDto, Order>().ReverseMap();
                cfg.CreateMap<ProductDto, Product>().ReverseMap();
            });
            _mapper = new Mapper(config);
        }

        /// <summary>
        /// Method map dto to entity and invokes method from OrderRepository
        /// responsible for adding order to database
        /// </summary>
        /// <param name="dto">Data transfer object with all necessary data</param>
        /// <returns>true if order was successfully added, otherwise false</returns>
        public async Task<bool> SaveToDb(OrderDto dto)
        {
            var order = _mapper.Map<Order>(dto);
            order.Products = new List<Product>();
            order.DateOfOrder = DateTime.Now;
            foreach (var product in ActualOrder.Products)
            {
                order.Products.Add(_mapper.Map<Product>(product));
            }

            try
            {
                await _orderRepository.SaveOrderToDb(order);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Method map dto to entity and invokes method from OrderRepository
        /// responsible for saving orders to xml file
        /// </summary>
        /// <param name="dto">Data transfer object with all necessary data</param>
        /// <returns>true if order was successfully added, otherwise false</returns>
        public bool SaveToXml(OrderDto dto)
        {
            var order = _mapper.Map<Order>(dto);
            order.Products = new List<Product>();
            order.DateOfOrder = DateTime.Now;
            foreach (var product in ActualOrder.Products)
            {
                order.Products.Add(_mapper.Map<Product>(product));
            }

            try
            {
                _orderRepository.SaveOrderToXml(order);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}