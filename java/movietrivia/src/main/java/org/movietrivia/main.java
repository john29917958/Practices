package main.java.org.movietrivia;

import java.io.IOException;

import main.java.org.movietrivia.file.MovieDB;

public class main {
    public static void main(String[] arags) throws IOException {
        MovieDB movieDb = new MovieDB("moviedata.txt", "movieratings.csv");
        MovieTrivia mt = new MovieTrivia();
        mt.insertActor("John Doe", new String[] { "Movie 1", "Movie 2" }, movieDb.getActors());
        mt.insertRating("Testing Movie", new int[] {1, 2}, movieDb.getMovies());
    }
}
