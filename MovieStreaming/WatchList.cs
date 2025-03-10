public class WatchList{

    private string userId;
    private List<Movie> movies;

    public WatchList(string userId){
        this.userId = userId;
        movies = new List<Movie>();
    }

    public string AddMovie(Movie movie){
        movies.Add(movie);
        return "Movie is added successfully!";
    }

    public void ViewWatchList(){

        if(movies.Count == 0){
            throw new Exception("Watchlist is empty");
        }

        foreach(Movie movie in movies){
            Console.WriteLine($"Title: {movie.GetTitle()} and Rating: {movie.GetRating()}");
        }
    }
}