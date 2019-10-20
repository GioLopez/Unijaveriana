using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using System.Threading.Tasks;

namespace webApp.Models
{
    public class User
    {

        [Required]
        public String Name { get; set; }

        [Required]
        public String Email { get; set; }


        public String Phone { get; set; }
        public String Message { get; set; }

        public User(string name, string email, string phone, string message)
        {
            Name = name;
            Email = email;
            Phone = phone;
            Message = message;
        }

        public User(){}

        public User(String name, String email) : this(name, email, null, null) { }
    }
}
