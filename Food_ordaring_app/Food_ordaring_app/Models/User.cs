using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace food_ordering_app.Models
{
    public class AppUser:IdentityUser
    {
        [Required]
        public string FullName { get; set; }

        public virtual List<Order> Orders { get; set; }
    }
}
