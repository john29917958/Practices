package main.java.org.movietrivia.movies;

import java.util.ArrayList;
import java.util.Arrays;

public class Actor {
    private String name;

    private ArrayList<String> castedMovies;

    public Actor(String name, String[] movies) {
        this.name = name;
        this.castedMovies = new ArrayList<String>(Arrays.asList(movies));
    }

    public String getName() {
        return this.name;
    }

    public ArrayList<String> getCastedMovies() {
        return this.castedMovies;
    }
}
