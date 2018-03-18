using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleBlog.Domain;

namespace SampleBlog.Data.ADONET
{
    public class AuthorProvider : IAuthorProvider
    {
        public List<Author> GetAllAuthors()
        {
            throw new NotImplementedException();
        }

        public Author GetAuthorById()
        {
            throw new NotImplementedException();
        }

        public Author GetAuthorByName()
        {
            throw new NotImplementedException();
        }

        public void AddAuthor(Author author)
        {
            throw new NotImplementedException();
        }

        public void UpdateAuthor(Author author)
        {
            throw new NotImplementedException();
        }

        public void DeleteAuthor(Author author)
        {
            throw new NotImplementedException();
        }

        public Author LoadAuthorEager(SqlDataReader reader)
        {
            var postProvider = new PostProvider();

            var author = new Author()
            {
                FirstName = reader[nameof(Post.Text)].ToString(),
                LastName = reader[nameof(Post.Text)].ToString(),
                Email = reader[nameof(Post.Category)].ToString(),
                Id = Int32.Parse(reader[nameof(Post.Id)].ToString()),
            };

            author.Posts = postProvider.GetPostsByAuthor(author);

            return author;
        }
    }
}
