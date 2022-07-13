﻿using System.ComponentModel.DataAnnotations;

namespace AuthorizationAPI.Model
{
    public class User
    {
        [Key]
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; } = "customer";
    }
}
