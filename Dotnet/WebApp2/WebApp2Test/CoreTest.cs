using System;
using Xunit;
using Core_app;
using WebApp2.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Net;

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

        [Fact]
        public async System.Threading.Tasks.Task HttpGetApiAsync()
        {
            // Act
            var the_contoller = new ApiController();

            var result = the_contoller.Get();

            // Assert
            //Assert.IsType<OkObjectResult>(okResult);
            Assert.IsType<OkObjectResult>(result);
        }
    }
}
