using System.Collections.Generic;

namespace SampleBlog.Domain
{
    public class Post
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int AuthorId { get; set; }
        public string Category { get; set; }
        public List<Comment> Comments { get; set; }

        public Post()
        {
            Comments = new List<Comment>();
        }
    }
}
