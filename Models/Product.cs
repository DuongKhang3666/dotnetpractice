using System;

namespace ShopAccessories.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty; // Ví/Túi xách/Balo/Thắt lưng/Mũ
        public decimal Price { get; set; }
        public decimal? OldPrice { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Material { get; set; } = string.Empty; // chất liệu
        public int Rating { get; set; } // 0-5
        public int Stock { get; set; } // số lượng tồn kho
    }
}
