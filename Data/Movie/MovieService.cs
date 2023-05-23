namespace LMDB.Data.Movie;

public class MovieService
{

    public Task<Movie[]> GetMovieAsync()
    {
        Movie[] movies = { new Movie() { Title = "Hello World", Description = "In a new World..." } };
        return Task.FromResult(
            movies
        );
    }
}