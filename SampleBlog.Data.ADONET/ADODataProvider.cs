using System;
using System.Data.SqlClient;
using System.Configuration;

namespace SampleBlog.Data
{
    public class ADODataProvider
    {
        public static string ConnectionString
        {
            get
            {
                var connString = ConfigurationManager.ConnectionStrings["SampleBlogConnection"].ToString();
                SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder(connString);

                sb.ApplicationName = ApplicationName ?? sb.ApplicationName;
                sb.ConnectTimeout = (ConnectionTimeout > 0) ? ConnectionTimeout : sb.ConnectTimeout;
                return sb.ToString();
            }
        }

        public static string ApplicationName;
        public static int ConnectionTimeout;

        /// <summary>
        /// Returns opened connection do SQL DB
        /// </summary>
        /// <returns></returns>
        public static SqlConnection GetSqlConnection()
        {
            var conn = new SqlConnection(ConnectionString);
            conn.Open();

            return conn;
        }
    }
}
