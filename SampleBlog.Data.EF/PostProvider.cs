using System;
using System.Collections.Generic;
using SampleBlog.Domain;

namespace SampleBlog.Data.EF
{
    public class PostProvider : IPostProvider
    {
        public List<Post> GetAllPosts()
        {
            throw new NotImplementedException();
        }

        public Post GetPostById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Post> GetPostsByAuthor(Author author)
        {
            throw new NotImplementedException();
        }

        public List<Post> GetPostsByAuthorAndCategory(Author author, string category)
        {
            throw new NotImplementedException();
        }

        public bool InsertPost(Post post)
        {
            throw new NotImplementedException();
        }

        public bool UpdatePost(Post post)
        {
            throw new NotImplementedException();
        }

        public bool DeletePost(Post post)
        {
            throw new NotImplementedException();
        }
    }
}
