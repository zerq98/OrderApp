using OrderApp.Domain.Entity;
using OrderApp.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OrderApp.Infrastructure.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _context;

        public OrderRepository()
        {
            _context = new AppDbContext();
        }

        /// <summary>
        /// Method that saves data in database
        /// </summary>
        /// <param name="order">Instance of class Order mapped from dto in service. Contain all order data</param>
        public async Task SaveOrderToDb(Order order)
        {
            try
            {
                _context.Orders.Add(order);
                await _context.SaveChangesAsync();
            }
            catch(DbException ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Method that saves data in database
        /// </summary>
        /// <param name="order">Instance of class Order mapped from dto in service. Contain all order data</param>
        public void SaveOrderToXml(Order order)
        {
            XmlSerializer serializer;
            List<Order> orders = new List<Order>();

            var path = "./db.xml";
            try
            {
                if (!File.Exists(path))
                {
                    order.Id = 1;
                    orders.Add(order);
                    serializer = new XmlSerializer(typeof(List<Order>));
                    FileStream file = File.Create(path);
                    serializer.Serialize(file, orders);
                    file.Close();
                }
                else
                {
                    serializer = new XmlSerializer(typeof(List<Order>));
                    FileStream file = File.OpenRead(path);
                    orders = (List<Order>)serializer.Deserialize(file);
                    file.Close();
                    order.Id = orders.Count() + 1;
                    orders.Add(order);

                    file = File.OpenWrite(path);
                    serializer.Serialize(file, orders);
                    file.Close();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}