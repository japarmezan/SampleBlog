using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleBlog.Domain;

namespace SampleBlog.Data
{
    public interface IAuthorProvider
    {
        List<Author> GetAllAuthors();
        Author GetAuthorById();
        Author GetAuthorByName();

        void AddAuthor(Author author);
        void UpdateAuthor(Author author);
        void DeleteAuthor(Author author);
    }
}
