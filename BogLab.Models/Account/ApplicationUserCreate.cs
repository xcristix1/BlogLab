using System;
using System.Collections.Generic;
using System.Text;

namespace BogLab.Models.Account
{
 public   class ApplicationUserCreate : ApplicationUserLogin
    {
        [MinLength(10, ErrorMessage = "Must be 10-30 characters")]
        [MaxLength(30, ErrorMessage = "Must be 10-30 characters")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [MaxLength(30, ErrorMessage = "Can be at most 30 characters")]
        [EmailAdress(ErrorMessage = "Invalid Email format")]
        public string Email { get; set; }
    }
}
