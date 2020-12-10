using System;
namespace Film_Default
{
    class Program
    {
        enum Genres { Drama = 1, Actie, Horror, Onbekend }
        static void Main(string[] args)
        {
            Console.Write("Geef de titel: ");
            string movieTitle = Console.ReadLine();
            Console.Write("Geef de runtime: ");
            string movieRuntimeString = Console.ReadLine();
            Console.Write("Geef het genre (Drama = 1, Actie = 2, Horror = 3): ");
            string movieGenreString = Console.ReadLine();
            if (movieRuntimeString == "" && movieGenreString == "")
            {
                FilmRuntime(title: movieTitle);
            }
            else if (movieRuntimeString == "")
            {
                Genres movieGenre = (Genres)int.Parse(movieGenreString);
                FilmRuntime(title: movieTitle, genre: movieGenre);
            }
            else if (movieGenreString == "")
            {
                int movieRuntime = int.Parse(movieRuntimeString);
                FilmRuntime(title: movieTitle, runtime: movieRuntime);
            }
            else
            {
                int movieRuntime = int.Parse(movieRuntimeString);
                Genres movieGenre = (Genres)int.Parse(movieGenreString);
                FilmRuntime(title: movieTitle, runtime: movieRuntime, genre: movieGenre);
            }
        }
        static void FilmRuntime(string title, int runtime = 90, Genres genre = Genres.Onbekend)
        {
            Console.WriteLine($"{title} ({runtime} minuten, {genre})");
        }
    }
}