using System;
using Xunit;
using Core_app;

namespace WebApp2Test
{
    public class CoreTest
    {
        [Fact]
        public void Test1()
        {
            Contact contact = new Contact();
            Boolean expected = true;
            Boolean actual = contact.SetName("Giovanni");
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Test2()
        {
            ProductPrice price = new ProductPrice();
            price.ItemPrice = 2000;
            int expected = 1000;
            // Article price 2000, discount 50
            int actual = price.ApplyDiscount(2000, 50);
            Assert.Equal(expected, actual);
        }

        public void Test3()
        {

        }
    }
}
