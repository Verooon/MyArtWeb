﻿using System.ComponentModel.DataAnnotations;

namespace MyArtWeb.Models
{
    public class User
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Name { get; set; }
        
        [Key, MinLength(5)]
        public string Email { get; set; } 
        [Required, MinLength(8)]
        public string Password { get; set; } //at least one capital letter, one letter, one number 
        public string City { get; set; }

    }
}