namespace HackerMan.Models
{
    public class Post
    {
        public int Id { get; set; } // Unique identifier for the post
        public string Content { get; set; } // Post content (text, etc.)
        public string MediaUrl { get; set; } // URL to the media (image or video)
        public DateTime PostedAt { get; set; } // When the post was made
    }

}
