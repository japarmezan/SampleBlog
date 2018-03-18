using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleBlog.Domain;

namespace SampleBlog.Data
{
    public interface ICommentProvider
    {
        List<Comment> GetCommentsByPost(Post post);
        Comment GetCommentById(int id);

        void AddComment(Comment comment);
        void UpdateComment(Comment comment);
        void DeletComment(Comment comment);
    }
}
