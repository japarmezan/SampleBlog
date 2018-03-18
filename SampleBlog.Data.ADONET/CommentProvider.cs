using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleBlog.Domain;

namespace SampleBlog.Data.ADONET
{
    public class CommentProvider : ICommentProvider
    {
        public List<Comment> GetCommentsByPost(Post post)
        {
            var comments = new List<Comment>();
            using (var conn = ADODataProvider.GetSqlConnection())
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = Scripts.GetCommentsByPostStoredProc;
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("PostId", SqlDbType.Int);
                    p1.Value = post.Id;
                    cmd.Parameters.Add(p1);

                    var reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            comments.Add(LoadComment(reader));
                        }
                    }
                }
            }

            return comments;
        }

        public Comment GetCommentById(int id)
        {
            var comment = new Comment();
            using (var conn = ADODataProvider.GetSqlConnection())
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = Scripts.GetCommentByIdStoredProc;
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("CommentId", SqlDbType.Int);
                    p1.Value = id;
                    cmd.Parameters.Add(p1);

                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        comment = LoadComment(reader);
                    }
                }
            }

            return comment;
        }

        public void AddComment(Comment comment)
        {
            throw new NotImplementedException();
        }

        public void UpdateComment(Comment comment)
        {
            throw new NotImplementedException();
        }

        public void DeletComment(Comment comment)
        {
            throw new NotImplementedException();
        }

        private Comment LoadComment(SqlDataReader reader)
        {
            var comment = new Comment()
            {
                Content = reader[nameof(Comment.Content)].ToString(),
                AuthorId = Int32.Parse(reader[nameof(Comment.AuthorId)].ToString()),
                Date = reader.GetDateTime(reader.GetOrdinal(nameof(Comment.Date))),
                Id = Int32.Parse(reader[nameof(Comment.Id)].ToString()),
            };

            return comment;
        }
    }
}
