using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace demo01.Models
{
    public class MemberResponse
    {
        [Required(ErrorMessage = "Input your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Input your email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Invalid email format")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Input your Tel")]
        public string Tel { get; set; }

        [Required(ErrorMessage = "Select attendance")]
        public bool? Attend { get; set; }
    }
}