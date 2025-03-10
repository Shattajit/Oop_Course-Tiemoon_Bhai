
public class Program{
    public static void Main(string[] args){

        User user1 = new User("123", "abc", "abc@gmail.com");

        //user1.BrowseMovie();

        TimeSpan duration = new TimeSpan(2, 30, 0);

        Movie movie1 = new Movie("01", "xyz", "Thriller", duration, 7.5, "this is a good movie");

        user1.AddToWatchList(movie1);

        user1.BrowseMovie();

        user1.RateMovie(movie1, 8.0);

        user1.BrowseMovie();



        Console.WriteLine("Next User: ");
        


        Movie movie2 = new Movie("02", "mno", "Thriller", duration, 8.5, "this is a very good movie");

        user1.AddToWatchList(movie2);

        user1.BrowseMovie();

        user1.RateMovie(movie2, 7.5);
        user1.BrowseMovie();
    }
}