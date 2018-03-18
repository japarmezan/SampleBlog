using System;
using System.Collections.Generic;
using System.Text;
using SampleBlog.Domain;

namespace SampleBlog.Service
{
    interface IPostsRepository
    {
        List<Post> GetAllPosts();

        Post GetPostById(int id);

        List<Post> GetAllPostsByAuthor(Author author);
        bool InsertPost(Post post);
        bool UpdatePost(Post post);
        bool DeletePost(Post post);
    }
}
