using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_3.Models
{
    public class MovieRepository
    {
        private static List<Class> allMovies = new List<Class>();
        public static IEnumerable<Class> AllMovies
        {
            get { return allMovies; }
        }
        public static void Create(Class movie)
        {
            allMovies.Add(movie);
        }
        public static void Delete(Class movie)
        {
            allMovies.Remove(movie);
        }
    }

}
