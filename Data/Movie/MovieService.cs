namespace LMDB.Data.Movie;

public class MovieService
{

  // Public

  // Private

  // Temporary Delete when the DB is up and running.
  private static Random rnd = new Random();
  private static string temporaryMovieTitleString = "";
  private static int temporaryMovieTitleInt = 1;
  private static readonly string[] MovieTitles = new[]
  {
        "Fast To The Future 2", "Garfield", "Not Home Alone", "Tony And The Rubber Ducks", "Mild Hot Sauce 2", "The Space Station", "The Cool, The Bold And The Programmer", "The Navy Academy 3", "Sweet Dreams"
    };

  // Gets the data to the movie card
  public Task<Movie[]> GetMovieAsync()
  {
    // Movie[] movies = { new Movie() { Title = "Hello World", Description = "In a new World..." } };
    return Task.FromResult(Enumerable.Range(1, 20).Select(index => new Movie
    {
      // We could get the latest movies by getting the highest IDs in the DB
      // Possible category name: "Just added"

      Title = temporaryMovieTitle(),                          // This should be pulled from the database
      MovieLink = temporaryMovieTitle().Replace(' ', '_'),    // This should be pulled from the database
      Description = "Desc"

    }).ToArray());
    /* return Task.FromResult(
        movies
    );*/
  }

  // Temporary method. Delete when the DB is up and running.
  private string temporaryMovieTitle()
  {
    if (temporaryMovieTitleInt == 1)
    {
      temporaryMovieTitleString = MovieTitles[rnd.Next(0, 8)];
      temporaryMovieTitleInt = 0;
    }
    else
    {
      temporaryMovieTitleInt++;
    }

    return temporaryMovieTitleString;
  }
}