using ShopAccessories.Models;
using System;
using System.Collections.Generic;

namespace ShopAccessories.Services
{
    public class CartService
    {
        private List<CartItem> _cartItems = new List<CartItem>();

        public event Action? OnChange;

        public void AddToCart(Product product, int quantity = 1)
        {
            var existingItem = _cartItems.FirstOrDefault(i => i.Product.Id == product.Id);
            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
            }
            else
            {
                _cartItems.Add(new CartItem { Product = product, Quantity = quantity });
            }

            NotifyChange();
        }

        public void UpdateQuantity(int productId, int quantity)
        {
            var item = _cartItems.FirstOrDefault(i => i.Product.Id == productId);
            if (item != null)
            {
                if (quantity <= 0)
                {
                    Remove(productId);
                }
                else
                {
                    item.Quantity = quantity;
                }
            }

            NotifyChange();
        }

        public void Remove(int productId)
        {
            _cartItems.RemoveAll(i => i.Product.Id == productId);
            NotifyChange();
        }

        public void Clear()
        {
            _cartItems.Clear();
            NotifyChange();
        }

        public int TotalQuantity => _cartItems.Sum(i => i.Quantity);

        public decimal SubTotal => _cartItems.Sum(i => i.Total);

        public decimal Shipping => SubTotal >= 1000000 ? 0 : 30000; // Free shipping from 1,000,000 VND

        public decimal GrandTotal => SubTotal + Shipping;

        public IEnumerable<CartItem> GetCartItems() => _cartItems;

        private void NotifyChange() => OnChange?.Invoke();
    }
}