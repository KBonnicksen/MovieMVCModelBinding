using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MovieMVCModelBinding.Models
{
    public class DBHelper
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection("Data Source=LAPTOP-UGD52LRI;Initial Catalog=MVCMovies;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
