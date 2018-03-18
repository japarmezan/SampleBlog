using System;
using System.Collections.Generic;
using SampleBlog.Data;
using SampleBlog.Domain;

namespace SampleBlog.Service
{
    public class PostRepository : IPostsRepository
    {
        private readonly IPostProvider _postProvider;

        public PostRepository(IPostProvider postProvider)
        {
            this._postProvider = postProvider;
        }

        public List<Post> GetAllPosts()
        {
            return _postProvider.GetAllPosts();
        }

        public Post GetPostById(int id)
        {
            return _postProvider.GetPostById(id);
        }

        public List<Post> GetAllPostsByAuthor(Author author)
        {
            return _postProvider.GetPostsByAuthor(author);
        }

        public bool InsertPost(Post post)
        {
            return _postProvider.InsertPost(post);
        }

        public bool UpdatePost(Post post)
        {
            return _postProvider.UpdatePost(post);
        }

        public bool DeletePost(Post post)
        {
            return _postProvider.DeletePost(post);
        }
    }
}
