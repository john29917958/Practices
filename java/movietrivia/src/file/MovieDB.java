package file;

import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Arrays;

import movies.Actor;
import movies.Movie;

public class MovieDB {
    private ArrayList<Actor> actors;
    private ArrayList<Movie> movies;

    public MovieDB(String moviesDataFilePath, String movieRatingsFilePath) throws IOException {
        actors = new ArrayList<Actor>();
        movies = new ArrayList<Movie>();

        this.loadActors(moviesDataFilePath);
        this.loadMovies(movieRatingsFilePath);
    }

    public Actor[] getActors() {        
        return this.actors.toArray(new Actor[this.actors.size()]);
    }

    private void loadActors(String dataFilePath) throws IOException {
        BufferedReader reader = new BufferedReader(new FileReader(dataFilePath));
        String line = null;

        do {
            line = reader.readLine();
            if (line == null || line.length() == 0)
                continue;

            String[] tokens = line.split(",");
            for (int i = 0; i < tokens.length; i++) {
                tokens[i] = this.formatName(tokens[i]);
            }
            String[] movies = tokens.length > 1 ? Arrays.copyOfRange(tokens, 0, tokens.length) : new String[0];
            Actor actor = new Actor(tokens[0], movies);
            this.actors.add(actor);
        } while (line != null);

        reader.close();
    }

    private void loadMovies(String dataFilePath) throws IOException {
        BufferedReader reader = new BufferedReader(new FileReader(dataFilePath));
        String line = null;

        do {
            line = reader.readLine();
            if (line == null || line.length() == 0)
                continue;

            String[] tokens = line.split(",");
            tokens[0] = this.formatName(tokens[0]);
            Movie actor = new Movie(tokens[0], Integer.parseInt(tokens[1]), Integer.parseInt(tokens[2]));
            this.movies.add(actor);
        } while (line != null);

        reader.close();
    }

    private String formatName(String name) {
        String[] tokens = name.trim().split(" ");
        for (int i = 0; i < tokens.length; i++) {
            String token = tokens[i].trim();
            token = token.trim().toLowerCase();
            token = Character.toUpperCase(token.charAt(0)) + token.substring(1);
            tokens[i] = token;
        }
        return String.join(" ", tokens);
    }
}
