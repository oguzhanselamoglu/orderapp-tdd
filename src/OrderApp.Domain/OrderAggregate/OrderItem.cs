namespace OrderApp.Domain.OrderAggregate
{
    public class OrderItem
    {
        public OrderItem(string product, int amount, decimal price)
        {
            Product = product;
            Amount = amount;
            Price = price;
        }

        public string Product { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
    }
}