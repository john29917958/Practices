import file.MovieDB;

public class MovieTrivia {
    public static void main(String[] args) throws Exception {
        MovieDB movieDb = new MovieDB("moviedata.txt", "movieratings.csv");
    }
}
