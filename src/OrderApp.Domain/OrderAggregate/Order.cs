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
        public decimal TotalPrice { get; set; }
        public List<OrderItem> Items { get; set; } = new();

        public void AddItem(OrderItem orderItem)
        {
            throw new NotImplementedException();
        }
    }
}
