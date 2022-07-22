using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApp.Domain.OrderAggregate
{
    public class Order
    {
        public decimal TotalPrice => Items.Sum(r=>r.Amount * r.Price);

        private List<OrderItem> _items { get; set; } = new();
        public IReadOnlyList<OrderItem> Items => _items.AsReadOnly();

        public void AddItem(OrderItem orderItem)
        {
            ArgumentNullException.ThrowIfNull(orderItem, nameof(orderItem));

            _items.Add(orderItem);
            
        }

        public void RemoveItem(int id)
        {
            _items.RemoveAll(r => r.Id == id);
            
        }
    }
}
