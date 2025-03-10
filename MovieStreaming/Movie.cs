
public class Movie{

    private string movieId;
    private string title;
    private string genre;
    private TimeSpan duration;
    private double rating;
    private string desc;

    public Movie(string movieId, string title, string genre, TimeSpan duration, double rating, string desc){
        this.movieId = movieId;
        this.title = title;
        this.genre = genre;
        this.duration = duration;
        this.rating = rating;
        this.desc = desc;
    }


    // all getters
    public string GetId(){
        return movieId;
    }

    public string GetTitle(){
        return title;
    }
    public string GetGenre(){
        return genre;
    }
    public TimeSpan GetDuration(){
        return duration;
    }
    public double GetRating(){
        return rating;
    }
    public string GetDesc(){
        return desc;
    }
    

    // all setters
    public void SetId(string movieId){
        this.movieId = movieId;
    }

    public void SetTitle(string title){
        this.title = title;
    }
    public void SetGenre(string genre){
        this.genre = genre;
    }
    public void SetDuration(TimeSpan duration){
        this.duration = duration;
    }
    public void SetRating(double rating){
        this.rating = rating;
    }
    public void SetDesc(string desc){
        this.desc = desc;
    }

    public void GetDetails(){
        Console.WriteLine($"Title: {title}, Genre: {genre}, Desc: {desc} and Rating: {rating}");
    }

    public double GetAvgRating(){
        return rating;
    }
}