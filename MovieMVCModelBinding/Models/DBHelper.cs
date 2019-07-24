using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MovieMVCModelBinding.Models
{
    /// <summary>
    /// Provides methods that aid in communicating with a database
    /// </summary>
    public class DBHelper
    {
        /// <summary>
        /// Returns a connection to the database
        /// </summary>
        /// <returns></returns>
        public static SqlConnection GetConnection()
        {
            return new SqlConnection("Data Source=LAPTOP-UGD52LRI;Initial Catalog=MVCMovies;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
