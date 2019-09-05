using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace Lybrary.Models
{
    public class LoginReader
    {
        [Display(Name = "Email")]
        [Required]
        [EmailAddress]
        public string LoginEmail { get; set; }

        [Display(Name = "Password")]
        [Required]
        [DataType(DataType.Password)]
        [MinLength(8)]
        public string LoginPassword { get; set; }
    }
}