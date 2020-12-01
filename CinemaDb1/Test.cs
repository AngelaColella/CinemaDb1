using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CinemaDb1
{
    public class Test
    {
        public static void GetMovies()
        {
            using (var cxt = new CinemaDbContext()) // inizializzazione del Context
            {
                //var films =
                //    from m in cxt.Movies 
                //    select m;
                //foreach (var item in films)
                //{
                //    Console.WriteLine($"ID: {item.Id} - Titolo: {item.Titolo}");
                //}

                // oppure 

                foreach (var item in cxt.Movies)
                {
                    Console.WriteLine($"ID: {item.Id} - Titolo: {item.Titolo}");
                }

            }
        }

        public static void InsertMovie(Movie m)
        {
            using (var cxt = new CinemaDbContext())
            {
                cxt.Movies.Add(m);
                cxt.SaveChanges();
            }
        }

        public static void DeleteMovie(int movieId)
        {
            using (var context = new CinemaDbContext())
            {
                var f = context.Movies.Find(movieId);
                Console.WriteLine($"\n \n Sto eliminando il film {f.Titolo}");

                context.Movies.Remove(f);
                context.SaveChanges();
            }
        }

        public static void DeleteMovieDisconnected(int movieId)
        {
            var f = new Movie();

            using (var context = new CinemaDbContext())
            {
                f = context.Movies.Find(movieId); //stiamo salvando in f il film con id MovieId
            }

            using (var context = new CinemaDbContext())
            {
                context.Entry<Movie>(f).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
