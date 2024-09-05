using HackerMan.Models;

namespace HackerMan.Data
{
    public static class SeedData
    {
        public static List<Account> GetTestAccounts()
        {
            return new List<Account>
        {
            new Account
            {
                Id = 1,
                Username = "testuser",
                ProfilePictureUrl = "/images/profile_testuser.jpg",
                Bio = "Just a test user. Testing things out.",
                Password = "IsTheInMemoryTesterWorking?",
                Posts = new List<Post>
                {
                    new Post
                    {
                        Id = 1,
                        Content = "This is a test post. Everything is working as expected!",
                        MediaUrl = "/images/post_testuser.jpg",
                        PostedAt = DateTime.Now
                    }
                }
            }
        };
        }
    }
}
