namespace HackerMan.Models
{
    public class Account
    {
        public int Id { get; set; } // Unique identifier for the account
        public string Username { get; set; } // Username of the account
        public string ProfilePictureUrl { get; set; } // URL to the profile picture
        public string Bio { get; set; } // Profile bio
        public string Password { get; set; } // Password to be guessed
        public List<Post> Posts { get; set; } // List of posts associated with the account
    }
}
