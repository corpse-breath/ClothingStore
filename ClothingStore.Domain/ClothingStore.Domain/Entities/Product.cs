using System;
using System.Collections.Generic;
using System.Text;


namespace ClothingStore.Domain.Entities
{
    public class Product
    {
        public Guid Id { get; set; }

        public string Name { get; set; } 

        public string Description { get; set; } 

        public decimal Price { get; set; }

        public string Size { get; set; } 

        public string Color { get; set; } 

        public string ImageUrl { get; set; } 

        public int StockQuantity { get; set; }

        public Guid CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
