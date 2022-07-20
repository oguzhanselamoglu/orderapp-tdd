

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

        [Fact]
        public void Should_ThrowException_When_AddOrder_If_ItemIsNull()
        {
            var exception = Assert.Throws<ArgumentNullException>(() =>
            {
                _order.AddItem(null);
            });

            Assert.NotNull(exception);
            Assert.Equal("orderItem",exception.ParamName);
        }

        [Fact]
        public void Should_Succeed_When_AddOrder()
        {
            
            _order.AddItem(new OrderItem("Product 1", 1, 100M));
            _order.AddItem(new OrderItem("Product 2", 2, 200M));


            Assert.Equal(500, _order.TotalPrice);
            Assert.Equal(2,_order.Items.Count);

        }


    }
}