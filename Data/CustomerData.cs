using ShopAccessories.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShopAccessories.Data
{
    public static class CustomerData
    {
        public static List<Customer> Customers => new List<Customer>
        {
            new Customer
            {
                Id = 1,
                Name = "Nguyễn Văn A",
                Email = "nguyenvana@example.com",
                Phone = "0909123456",
                City = "TP.HCM",
                JoinedAt = DateTime.Now.AddMonths(-6),
                OrdersCount = 2,
                TotalSpent = 2450000
            },
            new Customer
            {
                Id = 2,
                Name = "Trần Thị B",
                Email = "tran_thib@example.com",
                Phone = "0912345678",
                City = "TP.HCM",
                JoinedAt = DateTime.Now.AddMonths(-4),
                OrdersCount = 1,
                TotalSpent = 180000
            },
            new Customer
            {
                Id = 3,
                Name = "Lê Văn C",
                Email = "levanc@example.com",
                Phone = "0934567890",
                City = "Hà Nội",
                JoinedAt = DateTime.Now.AddMonths(-3),
                OrdersCount = 2,
                TotalSpent = 950000
            },
            new Customer
            {
                Id = 4,
                Name = "Phạm Thị D",
                Email = "phamthid@example.com",
                Phone = "0945678901",
                City = "Đà Nẵng",
                JoinedAt = DateTime.Now.AddMonths(-2),
                OrdersCount = 1,
                TotalSpent = 450000
            },
            new Customer
            {
                Id = 5,
                Name = "Hoàng Văn E",
                Email = "hoangvane@example.com",
                Phone = "0956789012",
                City = "Hải Phòng",
                JoinedAt = DateTime.Now.AddMonths(-1),
                OrdersCount = 1,
                TotalSpent = 840000
            },
            new Customer
            {
                Id = 6,
                Name = "Vũ Thị F",
                Email = "vuthif@example.com",
                Phone = "0967890123",
                City = "TP.HCM",
                JoinedAt = DateTime.Now.AddMonths(-5),
                OrdersCount = 3,
                TotalSpent = 1500000
            },
            new Customer
            {
                Id = 7,
                Name = "Đặng Văn G",
                Email = "dangvang@example.com",
                Phone = "0978901234",
                City = "Hà Nội",
                JoinedAt = DateTime.Now.AddMonths(-4),
                OrdersCount = 2,
                TotalSpent = 700000
            },
            new Customer
            {
                Id = 8,
                Name = "Bùi Thị H",
                Email = "buithih@example.com",
                Phone = "0989012345",
                City = "Đà Nẵng",
                JoinedAt = DateTime.Now.AddMonths(-3),
                OrdersCount = 1,
                TotalSpent = 320000
            },
            new Customer
            {
                Id = 9,
                Name = "Phan Văn I",
                Email = "phanvi@example.com",
                Phone = "0990123456",
                City = "TP.HCM",
                JoinedAt = DateTime.Now.AddMonths(-2),
                OrdersCount = 2,
                TotalSpent = 1100000
            },
            new Customer
            {
                Id = 10,
                Name = "Trần Văn K",
                Email = "trank@example.com",
                Phone = "0901234567",
                City = "Hà Nội",
                JoinedAt = DateTime.Now.AddMonths(-1),
                OrdersCount = 1,
                TotalSpent = 500000
            }
        };
    }
}