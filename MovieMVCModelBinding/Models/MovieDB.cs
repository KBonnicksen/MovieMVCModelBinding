using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MovieMVCModelBinding.Models
{
    /// <summary>
    /// Class holding database functionality methods 
    /// Ex. Inserts, updates, deletes
    /// </summary>
    class MovieDB
    {
        /// <summary>
        /// Adds a movie to a database.  Returns true if successfully added
        /// </summary>
        /// <param name="film">film being registered</param>
        /// <exception cref="SqlException"></exception>
        public static bool Add(Movie film)
        {
            SqlConnection con = DBHelper.GetConnection();

            SqlCommand addCmd = new SqlCommand
            {
                Connection = con,
                CommandText = "INSERT INTO Movies(Title, Director, YearReleased, Genre, IMDBRating) " +
                              "VALUES (@Title, @Director, @YearReleased, @Genre, @IMDBRating)"
            };

            addCmd.Parameters.AddWithValue("@Title", film.Title);
            addCmd.Parameters.AddWithValue("@Director", film.Director);
            addCmd.Parameters.AddWithValue("@YearReleased", film.YearReleased);
            addCmd.Parameters.AddWithValue("@Genre", film.Genre);
            addCmd.Parameters.AddWithValue("@IMDBRating", film.IMDBRating);

            try
            {
                con.Open();
                int rowsAffected = addCmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                con.Dispose();
            }
        }
    }
}
