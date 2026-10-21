using ShopAccessories.Models;
using System.Collections.Generic;

namespace ShopAccessories.Data
{
    public static class ProductData
    {
        public static List<Product> Products => new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "Túi xách da véritable",
                Category = "Túi xách",
                Price = 1250000,
                OldPrice = 1500000,
                ImageUrl = "https://images.unsplash.com/photo-1584916953657-9e3c85c5a6df?auto=format&fit=crop&w=600&h=450&q=80",
                Description = "Túi xách làm từ da bò thật, thiết kế tinh tế, phù hợp cho công sở và đi chơi.",
                Material = "Da bò thật",
                Rating = 5,
                Stock = 10
            },
            new Product
            {
                Id = 2,
                Name = "Balo thể thao",
                Category = "Balo",
                Price = 450000,
                ImageUrl = "https://images.unsplash.com/photo-1553062407-98eeb64c6a9e?auto=format&fit=crop&w=600&h=450&q=80",
                Description = "Balo bằng vải canvas durably, có nhiều ngăn tiện ích, thích hợp cho du học và thể thao.",
                Material = "Vải canvas",
                Rating = 4,
                Stock = 15
            },
            new Product
            {
                Id = 3,
                Name = "Ví da ngắn",
                Category = "Ví",
                Price = 320000,
                OldPrice = 400000,
                ImageUrl = "https://images.unsplash.com/photo-1627123424574-724758594e93?auto=format&fit=crop&w=600&h=450&q=80",
                Description = "Ví da PU nhỏ gọn, nhiều ngăn để placing tiền tệ và thẻ.",
                Material = "Da PU",
                Rating = 4,
                Stock = 8
            },
            new Product
            {
                Id = 4,
                Name = "Thắt lưng da đ formal",
                Category = "Thắt lưng",
                Price = 280000,
                ImageUrl = "https://images.unsplash.com/photo-1591047139829-d91aecb5cae1?auto=format&fit=crop&w=600&h=450&q=80",
                Description = "Thắt lưng da bò thật, dây đai rộng 3.5cm, mức độ formal cao.",
                Material = "Da bò thật",
                Rating = 5,
                Stock = 5
            },
            new Product
            {
                Id = 5,
                Name = "Mũ len inverno",
                Category = "Mũ",
                Price = 180000,
                ImageUrl = "https://images.unsplash.com/photo-1517486808744-764615648874?auto=format&fit=crop&w=600&h=450&q=80",
                Description = "Mũ len đ точки, giữ ấm tốt trong mùa lạnh, size tự co giãn.",
                Material = "Len",
                Rating = 3,
                Stock = 0
            },
            new Product
            {
                Id = 6,
                Name = "Túi xách ết laptop",
                Category = "Túi xách",
                Price = 980000,
                ImageUrl = "https://images.unsplash.com/photo-1553062407-98eeb64c6a9e?auto=format&fit=crop&w=600&h=450&q=80",
                Description = "Túi xách có đựng laptop 15.6 inch, chống nước nhẹ, nhiều túi phụ.",
                Material = "Vải polyester",
                Rating = 4,
                Stock = 12
            },
            new Product
            {
                Id = 7,
                Name = "Balo latihin học",
                Category = "Balo",
                Price = 380000,
                OldPrice = 450000,
                ImageUrl = "https://images.unsplash.com/photo-1526617872765-3e1c1f20a8d4?auto=format&fit=crop&w=600&h=450&q=80",
                Description = "Balo vải canvas, thiết kế lịch sử, có nhiều ngăn để sách và laptop.",
                Material = "Vải canvas",
                Rating = 4,
                Stock = 7
            },
            new Product
            {
                Id = 8,
                Name = "Ví cầm tay da",
                Category = "Ví",
                Price = 450000,
                ImageUrl = "https://images.unsplash.com/photo-1618042057363-61ec4cd11036?auto=format&fit=crop&w=600&h=450&q=80",
                Description = "Ví cầm tay da PU, thiết kế rétro, phù hợp cho những nocturne outing.",
                Material = "Da PU",
                Rating = 5,
                Stock = 6
            },
            new Product
            {
                Id = 9,
                Name = "Thắt lưng dây đai rộng",
                Category = "Thắt lưng",
                Price = 190000,
                ImageUrl = "https://images.unsplash.com/photo-1602810318363-786946471c16?auto=format&fit=crop&w=600&h=450&q=80",
                Description = "Thắt lưng da PU, dây đai rộng 4cm, có kim loại buckle màu vàng.",
                Material = "Da PU",
                Rating = 3,
                Stock = 20
            },
            new Product
            {
                Id = 10,
                Name = "Mũ bảo hiểm tự hành",
                Category = "Mũ",
                Price = 320000,
                ImageUrl = "https://images.unsplash.com/photo-1590140753434-1280ba04c7e0?auto=format&fit=crop&w=600&h=450&q=80",
                Description = "Mũ bảo hiểm tự hành, đáp ứng tiêu chuẩn ANSI, có hệ thống thông풍 tốt.",
                Material = "ABS plastic",
                Rating = 4,
                Stock = 15
            },
            new Product
            {
                Id = 11,
                Name = "Túi xách mini вечер",
                Category = "Túi xách",
                Price = 580000,
                OldPrice = 700000,
                ImageUrl = "https://images.unsplash.com/photo-1591047139829-d91aecb5cae1?auto=format&fit=crop&w=600&h=450&q=80",
                Description = "Túi xách mini da PU, chuỗi đeo vai, phù hợp cho tiệc tùng.",
                Material = "Da PU",
                Rating = 5,
                Stock = 4
            },
            new Product
            {
                Id = 12,
                Name = "Balo детский",
                Category = "Balo",
                Price = 250000,
                ImageUrl = "https://images.unsplash.com/photo-1530121385041-7b0b0b6e1e7e?auto=format&fit=crop&w=600&h=450&q=80",
                Description = "Balo cho trẻ em, hình carton кавай, có dây đeo vai có thể điều chỉnh.",
                Material = "Vải polyester",
                Rating = 4,
                Stock = 18
            },
            new Product
            {
                Id = 13,
                Name = "Ví zip-around da",
                Category = "Ví",
                Price = 390000,
                ImageUrl = "https://images.unsplash.com/photo-1616504874523-0bab8d83d707?auto=format&fit=crop&w=600&h=450&q=80",
                Description = "Ví zip-around da bò thật, nhiều ngăn для карт и наличных, повышенная безопасность замка.",
                Material = "Da bò thật",
                Rating = 5,
                Stock = 9
            },
            new Product
            {
                Id = 14,
                Name = "Thắt lưng cao su elastico",
                Category = "Thắt lưng",
                Price = 120000,
                ImageUrl = "https://images.unsplash.com/photo-1601281627086-0f62943fbbb7?auto=format&fit=crop&w=600&h=450&q=80",
                Description = "Thắt lưng cao su elastico, thích hợp cho thể thao và hoạt động ngoài trời.",
                Material = "Cao su",
                Rating = 3,
                Stock = 25
            },
            new Product
            {
                Id = 15,
                Name = "Mũ baseball da/",
                Category = "Mũ",
                Price = 280000,
                OldPrice = 350000,
                ImageUrl = "https://images.unsplash.com/photo-1574247393610-0b00a1b3ebb4?auto=format&fit=crop&w=600&h=450&q=80",
                Description = "Mũ baseball làm từ da PU, kích thước tự Adjustable, logo ricamo.",
                Material = "Da PU",
                Rating = 4,
                Stock = 11
            },
            new Product
            {
                Id = 16,
                Name = "Túi xách công sở nữ",
                Category = "Túi xách",
                Price = 750000,
                ImageUrl = "https://images.unsplash.com/photo-1553062407-98eeb64c6a9e?auto=format&fit=crop&w=600&h=450&q=80",
                Description = "Túi xách da PU công sở, thiết kế đơn giản, nhiều ngăn để laptop và tài liệu.",
                Material = "Da PU",
                Rating = 4,
                Stock = 14
            }
        };
    }
}