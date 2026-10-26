using System;
using System.Collections.Generic;
using System.Text;


namespace ClothingStore.Domain.Entities
{
    public class Order
    {
        public Guid Id { get; set; }

        public int UserId { get; set; }

        public DateTime OrderDate { get; set; } = DateTime.UtcNow;

        public decimal TotalPrice { get; set; }

        public List<OrderItem> Items { get; set; } 
    }
}
