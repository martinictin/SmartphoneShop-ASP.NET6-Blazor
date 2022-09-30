using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartphoneShop.Shared
{
    public class UserChangePassword
    {
        [Required,StringLength(50,MinimumLength =5)]
        public string Password { get; set; } = string.Empty;
        [Compare("Password",ErrorMessage ="The password doesn't match")]
        public string ConfirmPassword { get; set; } = string.Empty; 
    }
}
