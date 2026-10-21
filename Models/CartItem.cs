using ShopAccessories.Models;

namespace ShopAccessories.Models
{
    public class CartItem
    {
        public Product Product { get; set; } = default!;
        public int Quantity { get; set; }
        public decimal Total => Product.Price * Quantity;
        public string TotalText => Total.ToString("N0") + " ₫";
    }
}
