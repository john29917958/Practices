package movies;

import java.util.ArrayList;
import java.util.Arrays;

public class Actor {
    private String name;

    private ArrayList<String> movies;

    public Actor(String name, String[] movies) {
        this.name = name;
        this.movies = new ArrayList<String>(Arrays.asList(movies));
    }
}
