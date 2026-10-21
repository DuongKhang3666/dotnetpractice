using ShopAccessories.Data;
using ShopAccessories.Models;
using System.Collections.Generic;
using System.Linq;

namespace ShopAccessories.Services
{
    public class AdminStateService
    {
        public List<Product> Products { get; set; }
        public List<Order> Orders { get; set; }
        public List<Customer> Customers { get; set; }

        public AdminStateService()
        {
            // Initialize with data from the static data classes
            Products = ProductData.Products.ToList();
            Orders = OrderData.Orders.ToList();
            Customers = CustomerData.Customers.ToList();
        }

        // Product methods
        public void AddProduct(Product product)
        {
            product.Id = Products.Any() ? Products.Max(p => p.Id) + 1 : 1;
            Products.Add(product);
        }

        public void UpdateProduct(Product product)
        {
            var index = Products.FindIndex(p => p.Id == product.Id);
            if (index != -1)
            {
                Products[index] = product;
            }
        }

        public void DeleteProduct(int id)
        {
            Products.RemoveAll(p => p.Id == id);
        }

        // Order methods
        public void UpdateOrderStatus(int orderId, OrderStatus status)
        {
            var order = Orders.FirstOrDefault(o => o.Id == orderId);
            if (order != null)
            {
                order.Status = status;
            }
        }

        // Customer methods
        // No CRUD for customers in this example, but we could add if needed.
    }
}