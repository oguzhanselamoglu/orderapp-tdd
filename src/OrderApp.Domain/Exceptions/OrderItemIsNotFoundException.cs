namespace OrderApp.Domain.Exceptions
{
    public class OrderItemIsNotFoundException: Exception
    {
        public OrderItemIsNotFoundException(): base("Item could not found"){}
    }
}
