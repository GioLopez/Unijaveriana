using System;
using Xunit;
using BussinesLogic;

namespace AppTest
{
    public class ApplicationTest
    {
        [Fact]
        public void Test1()
        {
            Price price = new Price();
            price.ItemPrice = 2000;
            int expected = 1000;
            // Article price 2000, discount 50
            int actual = price.ApplyDiscount(2000, 50);
            Assert.Equal(expected, actual);
        }
    }
}
