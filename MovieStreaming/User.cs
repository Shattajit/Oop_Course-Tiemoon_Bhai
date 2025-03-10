
public class User{

    private string userId;
    private string name;
    private string email;
    private WatchList watchlist;
    private double ratings;

    public User(string userId, string name, string email){
        this.userId = userId;
        this.name = name;
        this.email = email;
        watchlist = new WatchList(userId);
    }

    public void BrowseMovie(){

        watchlist.ViewWatchList();
    }

    public void AddToWatchList(Movie movie){
        watchlist.AddMovie(movie);
    }

    public void RateMovie(Movie movie, double rating){
        movie.SetRating(rating);
    }
}