

namespace OrderApp.Domain.OrderAggregate
{
    public class Order
    {
        public decimal TotalPrice => Items.Where(r=>!r.Deleted).Sum(r=>r.Amount * r.Price);

        private List<OrderItem> _items { get; set; } = new();
        public IReadOnlyList<OrderItem> Items => _items.AsReadOnly();

        private List<PaymentItem> _payments { get; set; } = new();
        public IReadOnlyList<PaymentItem> Payments => _payments.AsReadOnly();

        public decimal TotalPayment => Payments.Where(r => !r.Deleted).Sum(r => r.Amount);
        public void AddItem(OrderItem orderItem)
        {
            ArgumentNullException.ThrowIfNull(orderItem, nameof(orderItem));

            _items.Add(orderItem);
            
        }

        public void RemoveItem(int id)
        {
            //_items.RemoveAll(r => r.Id == id);

            var item = _items.FirstOrDefault(r => r.Id == id);
            if (item == null) throw new OrderItemIsNotFoundException();

            item.Deleted = true;
            
        }

        public void AddPayment(PaymentItem paymentItem)
        {
            ArgumentNullException.ThrowIfNull(paymentItem,nameof(paymentItem));

            _payments.Add(paymentItem);
        }
    }
}
