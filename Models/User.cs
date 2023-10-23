namespace JWT_Authentication_Authorization.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
<<<<<<< HEAD

        public int RoleId { get; set; } // Add the RoleId property
<<<<<<< HEAD
=======
=======
        public int RoleId { get; set; } // Add this property
        public Role Role { get; set; } // Optional navigation property
>>>>>>> origin/master
>>>>>>> 24246e7886a2aac0dc7f5e33254d0485dcd42544
    }
}
