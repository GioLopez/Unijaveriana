using System;
using System.ComponentModel.DataAnnotations;

namespace WebApp1.Models
{
    public class User
    {
        public int id { get; set; }

        [Required]
        public String name { get; set; }

        [Display(Name = "Email address")]
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public String email { get; set; }

        [Required]
        [StringLength(100)]
        //[MaxLength(10)]
        public String message { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Cell Phone")]
        [StringLength(13, MinimumLength = 10)]
        public String phone { get; set; }

    }
}