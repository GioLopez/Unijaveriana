using System;
using System.ComponentModel.DataAnnotations;

namespace UserManage.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public String Name { get; set; }

        [Display(Name = "Email address")]
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public String Email { get; set; }

        [Required]
        [StringLength(10)]
        //[MaxLength(10)]
        public String Message { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Cell Phone")]
        [StringLength(13, MinimumLength = 10)]
        public String Phone { get; set; }
    } 
}
