using ShopAccessories.Data;
using ShopAccessories.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShopAccessories.Data
{
    public static class OrderData
    {
        public static List<Order> Orders => new List<Order>
        {
            new Order
            {
                Id = 1001,
                CustomerName = "Nguyễn Văn A",
                Phone = "0909123456",
                Address = "123 Nguyễn Trãi, Quận 1, TP.HCM",
                CreatedAt = DateTime.Now.AddDays(-10),
                Status = OrderStatus.Completed,
                Items = new List<CartItem>
                {
                    new CartItem { Product = ProductData.Products.First(p => p.Id == 1), Quantity = 1 },
                    new CartItem { Product = ProductData.Products.First(p => p.Id == 3), Quantity = 2 }
                }
            },
            new Order
            {
                Id = 1002,
                CustomerName = "Trần Thị B",
                Phone = "0912345678",
                Address = "456 Lê Lợi, Quận 3, TP.HCM",
                CreatedAt = DateTime.Now.AddDays(-8),
                Status = OrderStatus.Shipping,
                Items = new List<CartItem>
                {
                    new CartItem { Product = ProductData.Products.First(p => p.Id == 5), Quantity = 1 }
                }
            },
            new Order
            {
                Id = 1003,
                CustomerName = "Lê Văn C",
                Phone = "0934567890",
                Address = "789 Hai Bà Trưng, Quận Hoàn Kiếm, Hà Nội",
                CreatedAt = DateTime.Now.AddDays(-5),
                Status = OrderStatus.Pending,
                Items = new List<CartItem>
                {
                    new CartItem { Product = ProductData.Products.First(p => p.Id == 8), Quantity = 1 },
                    new CartItem { Product = ProductData.Products.First(p => p.Id == 12), Quantity = 2 }
                }
            },
            new Order
            {
                Id = 1004,
                CustomerName = "Phạm Thị D",
                Phone = "0945678901",
                Address = "321 Trần Phú, Quận Ngũ Hành Sơn, Đà Nẵng",
                CreatedAt = DateTime.Now.AddDays(-3),
                Status = OrderStatus.Cancelled,
                Items = new List<CartItem>
                {
                    new CartItem { Product = ProductData.Products.First(p => p.Id == 2), Quantity = 1 }
                }
            },
            new Order
            {
                Id = 1005,
                CustomerName = "Hoàng Văn E",
                Phone = "0956789012",
                Address = "654 Nguyễn Huệ, Quận 1, TP.HCM",
                CreatedAt = DateTime.Now.AddDays(-1),
                Status = OrderStatus.Pending,
                Items = new List<CartItem>
                {
                    new CartItem { Product = ProductData.Products.First(p => p.Id == 15), Quantity = 3 }
                }
            }
        };
    }
}