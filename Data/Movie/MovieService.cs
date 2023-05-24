namespace LMDB.Data.Movie;

public class MovieService
{
    private static Random rnd = new Random();
    private static readonly string[] MovieTitles = new[]
    {
        "Fast To The Future 2", "Garfield", "Not Home Alone", "Tony And The Rubber Ducks", "Mild Hot Sauce 2", "The Space Station", "The Cool, The Bold And The Programmer", "The Navy Academy 3", "Sweet Dreams"
    };

    public Task<Movie[]> GetMovieAsync()
    {
        // Movie[] movies = { new Movie() { Title = "Hello World", Description = "In a new World..." } };
        return Task.FromResult(Enumerable.Range(1, 20).Select(index => new Movie
        {
            Title = MovieTitles[rnd.Next(0, 8)],
            Description = "Desc"

        }).ToArray());
        /* return Task.FromResult(
            movies
        );*/
    }
}