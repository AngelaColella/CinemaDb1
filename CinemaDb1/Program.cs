using System;

namespace CinemaDb1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Film presenti nel database:");
            Test.GetMovies();

            Console.WriteLine("\n \n Inserimento di un film:");
            var movie = new Movie()
            {
                Titolo = "La dottoressa e le grandi manovre",
                Durata = 90,
                Genere = "Azione"
            };

            Test.InsertMovie(movie);

            Test.GetMovies();

            Console.WriteLine("Scrivi l'ID del film da eliminare: ");
            int movieId = Convert.ToInt32(Console.ReadLine());
            Test.DeleteMovie(movieId);
        }
    }
}
