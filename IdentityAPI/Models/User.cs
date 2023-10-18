using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace IdentityAPI.Models
{
    public class User : IdentityUser
    {
        [Required]
        public int FirsName { get; set; }
        [Required]
        public int LastName { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
    }
}
