// See https://aka.ms/new-console-template for more information
using MovieAsgn5;

List<Movie> movies = new List<Movie>()
{
    new Movie(){title="section 375",genre="thriller",rating=7.5},
    new Movie(){title="12th Fail",genre="Drama",rating=8.2},
    new Movie(){title="Click",genre="Horror",rating=7.9},
    new Movie(){title="3 idiots",genre="comedy",rating=9.5},
    new Movie(){title="Harry Potter",genre="Fantacy",rating=8.9},
};

Console.WriteLine("Title\t\t\tGenre\t\tRatings");
foreach (Movie movie in movies)
{
    Console.Write(movie.title + "\t\t");
    Console.Write(movie.genre + "\t\t");
    Console.Write(movie.rating + "\t\t");
    Console.WriteLine();
}
Console.WriteLine();

static void DisplayMovieDetails(List<Movie> movies, string title)
{
    foreach (Movie movie in movies)
    {
        if (movie.title == title)
        {
            Console.WriteLine($"Title: {movie.title}");
            Console.WriteLine($"Genre: {movie.genre}");
            Console.WriteLine($"Rating: {movie.rating}");
            return;
        }
    }
    Console.WriteLine($"Movie with title '{title}' not found.");
}
Console.WriteLine("enter movie title to search ");
string name = Console.ReadLine();
DisplayMovieDetails(movies, name);
Console.ReadKey();