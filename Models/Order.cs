using ShopAccessories.Models;
using System;
using System.Collections.Generic;

namespace ShopAccessories.Models
{
    public enum OrderStatus
    {
        Pending,
        Shipping,
        Completed,
        Cancelled
    }

    public class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public OrderStatus Status { get; set; }
        public List<CartItem> Items { get; set; } = new();
        public decimal Total => Items.Sum(i => i.Total);

        public string StatusText => Status switch
        {
            OrderStatus.Pending => "Chờ xử lý",
            OrderStatus.Shipping => "Đang giao",
            OrderStatus.Completed => "Hoàn thành",
            OrderStatus.Cancelled => "Đã hủy",
            _ => ""
        };

        public string StatusColor => Status switch
        {
            OrderStatus.Pending => "primary",
            OrderStatus.Shipping => "secondary",
            OrderStatus.Completed => "success",
            OrderStatus.Cancelled => "danger",
            _ => ""
        };
    }

    public static class OrderStatusExtensions
    {
        public static string GetStatusText(this OrderStatus status)
        {
            return status switch
            {
                OrderStatus.Pending => "Chờ xử lý",
                OrderStatus.Shipping => "Đang giao",
                OrderStatus.Completed => "Hoàn thành",
                OrderStatus.Cancelled => "Đã hủy",
                _ => ""
            };
        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public DateTime JoinedAt { get; set; }
        public int OrdersCount { get; set; }
        public decimal TotalSpent { get; set; }
    }
}