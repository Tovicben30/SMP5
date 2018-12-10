using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SMP5 .Models
{
    public class UserResponse
    {
        [Required(ErrorMessage = "Please enter your name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please create a username.")]
        public string UserName { get; set; }


        [Required(ErrorMessage = "Please enter a Password")]
        public string Password { get; set; }


        [Required(ErrorMessage = "Please enter your email address.")]
        [RegularExpression(".+\\@.+\\..+",
            ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Please choose a clan to join in.")]
        public bool? Willjoin { get; set; }
    }
}