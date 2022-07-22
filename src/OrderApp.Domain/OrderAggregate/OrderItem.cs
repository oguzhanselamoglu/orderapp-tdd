namespace OrderApp.Domain.OrderAggregate
{
    public class OrderItem
    {
        public OrderItem(int id,string product, int amount, decimal price)
        {
            Product = product;
            Amount = amount;
            Price = price;
            Id = id;
        }
        public int Id { get; set; }
        public string Product { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
    }
}