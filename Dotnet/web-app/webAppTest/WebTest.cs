using System;
using Xunit;
using webApp.Models;
using webApp.Controllers;
using Moq;
using System.Net.Http;
using Moq.Protected;
using System.Threading;
using System.Threading.Tasks;
using System.Net;

namespace webAppTest
{
    public class WebTest
    {

        [Fact]
        public void testEmptyUser()
        {
            var user = new User();

            Assert.True(
                user.Name == null ? true : false
                );
        }

        [Fact]
        public void testUser() {
            var user = new User("Giovanni", "gioipez92@gmail.com");

            Assert.True(
                user.Name == "Giovanni" && user.Email == "gioipez92@gmail.com" ? true: false
                ) ;
        }
        
    }
}
