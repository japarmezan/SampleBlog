using System;
using System.Collections.Generic;
using SampleBlog.Domain;

namespace SampleBlog.Data
{
    public interface IPostProvider
    {
        List<Post> GetAllPosts();

        Post GetPostById(int id);

        List<Post> GetPostsByAuthor(Author author);

        List<Post> GetPostsByAuthorAndCategory(Author author, string category);

        bool InsertPost(Post post);
        bool UpdatePost(Post post);
        bool DeletePost(Post post);
    }
}
