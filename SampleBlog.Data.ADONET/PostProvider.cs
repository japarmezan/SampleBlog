using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using SampleBlog.Domain;

namespace SampleBlog.Data.ADONET
{
    public class PostProvider : IPostProvider
    {
        public List<Post> GetAllPosts()
        {
            var posts = new List<Post>();
            using (var conn = ADODataProvider.GetSqlConnection())
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = Scripts.GetAllPosts;

                    var reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            posts.Add(LoadPostEager(reader));
                        }
                    }
                }
            }

            return posts;
        }

        public Post GetPostById(int id)
        {
            var p = new Post();
            using (var conn = ADODataProvider.GetSqlConnection())
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = Scripts.GetPostByIdStoredProc;
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("PostId", SqlDbType.Int);
                    p1.Value = id;
                    cmd.Parameters.Add(p1);

                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        p = LoadPostEager(reader);
                    }
                }
            }

            return p;
        }

        public List<Post> GetPostsByAuthor(Author author)
        {
            var posts = new List<Post>();
            using (var conn = ADODataProvider.GetSqlConnection())
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = Scripts.GetPostByAuthorStoredProc;
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("AuthorId", SqlDbType.Int);
                    p1.Value = author.Id;
                    cmd.Parameters.Add(p1);

                    var reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            posts.Add(LoadPostEager(reader));
                        }
                    }
                }
            }

            return posts;
        }

        public List<Post> GetPostsByAuthorAndCategory(Author author, string category)
        {
            var posts = new List<Post>();
            using (var conn = ADODataProvider.GetSqlConnection())
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = Scripts.GetPostByAuthorStoredProc;
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("AuthorId", SqlDbType.Int);
                    p1.Value = author.Id;
                    cmd.Parameters.Add(p1);

                    var p2 = new SqlParameter("CategoryName", SqlDbType.NVarChar);
                    p2.Value = category;
                    cmd.Parameters.Add(p2);

                    var reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            posts.Add(LoadPostEager(reader));
                        }
                    }
                }
            }

            return posts;
        }

        public bool InsertPost(Post post)
        {
            int result;
            using (var conn = ADODataProvider.GetSqlConnection())
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = Scripts.InsertPostStoredProc;
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("AuthorId", SqlDbType.Int);
                    p1.Value = post.AuthorId;
                    cmd.Parameters.Add(p1);
                    var p2 = new SqlParameter("Category", SqlDbType.NVarChar);
                    p2.Value = post.Category;
                    cmd.Parameters.Add(p2);
                    var p3 = new SqlParameter("Text", SqlDbType.NVarChar);
                    p3.Value = post.Text;
                    cmd.Parameters.Add(p3);

                    result = cmd.ExecuteNonQuery();
                }
            }

            return result != 0;
        }

        public bool UpdatePost(Post post)
        {
            throw new NotImplementedException();
        }

        public bool DeletePost(Post post)
        {
            throw new NotImplementedException();
        }

        public Post LoadPostEager(SqlDataReader reader)
        {
            var commentProvider = new CommentProvider();

            var post = new Post()
            {
                Text = reader[nameof(Post.Text)].ToString(),
                AuthorId = Int32.Parse(reader[nameof(Post.AuthorId)].ToString()),
                Category = reader[nameof(Post.Category)].ToString(),
                Id = Int32.Parse(reader[nameof(Post.Id)].ToString()),
            };

            post.Comments = commentProvider.GetCommentsByPost(post);

            return post;
        }
    }
}
