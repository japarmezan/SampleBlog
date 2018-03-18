using System;
using System.Collections.Generic;
using System.Text;

namespace SampleBlog.Data.ADONET
{
    public static class Scripts
    {
        public static string GetPostById => "SELECT * FROM Posts WHERE Id = {0}";
        public static string GetAllPosts => "SELECT * FROM Posts";

        public static string GetPostByIdStoredProc => "GetPostById";
        public static string InsertPostStoredProc => "InsertPost";
        public static string GetPostByAuthorStoredProc => "GetPostsByAuthor";
        public static string GetPostByAuthorAndCategoryStoredProc => "GetPostsByAuthorAndCategory";

        public static string GetCommentsByPostStoredProc => "GetCommentsByPost";
        public static string GetCommentByIdStoredProc => "GetCommentById";
    }
}
