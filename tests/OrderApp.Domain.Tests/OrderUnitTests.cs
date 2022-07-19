

namespace OrderApp.Domain.Tests
{
    public class OrderUnitTests
    {
        private readonly Order _order;
        public OrderUnitTests()
        {
            _order = new Order();
        }
      
        [Fact]
        public void Should_BeEmtyOrder_WhenCreate()
        {
            Assert.Equal(0, _order.TotalPrice);
            Assert.Empty(_order.Items);

        }
    }
}