

using OrderApp.Domain.Exceptions;

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
            Assert.Equal("orderItem", exception.ParamName);
        }

        [Fact]
        public void Should_Succeed_When_AddOrder()
        {

            _order.AddItem(new OrderItem(1, "Product 1", 1, 100M));
            _order.AddItem(new OrderItem(2, "Product 2", 2, 200M));


            Assert.Equal(500, _order.TotalPrice);
            Assert.Equal(2, _order.Items.Count);

        }

        [Fact]
        public void Should_Succeed_When_RemoveItem()
        {
            _order.AddItem(new OrderItem(1, "Product 1", 1, 100M));
            _order.AddItem(new OrderItem(2, "Product 2", 2, 200M));
            _order.RemoveItem(1);
            Assert.Equal(400, _order.TotalPrice);
            //  Assert.Single(_order.Items);
        }

        [Fact]
        public void Should_ThrowExceptin_When_RemoveItem_IfItemIsNotFound()
        {
            _order.AddItem(new OrderItem(1, "Product 1", 1, 100M));
            _order.AddItem(new OrderItem(2, "Product 2", 2, 200M));

            var exception = Assert.Throws<OrderItemIsNotFoundException>(() => _order.RemoveItem(5));

            Assert.Equal("Item could not found", exception.Message);
        }

    }
}