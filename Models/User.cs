﻿namespace JWT_Authentication_Authorization.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; } // Add this property
        public Role Role { get; set; } // Optional navigation property
    }
}
