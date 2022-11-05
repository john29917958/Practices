import java.util.ArrayList;

import file.MovieDB;
import movies.Actor;

public class MovieTrivia {
    public static void main(String[] args) throws Exception {
        MovieDB movieDb = new MovieDB("moviedata.txt", "movieratings.csv");
    }

    /**
     * Inserts the actor name and the movies that the actor played in to the actor information list.
     * @param actor The name of the actor.
     * @param movies The movies that the actor played in.
     */
    public void insertActor(String actor, String[] movies, ArrayList<Actor> actorsInfo) {
        for (Actor actorInfo : actorsInfo) {
            ArrayList<String> castedMovies = actorInfo.getCastedMovies();
            if (actorInfo.getName().equals(actor)) {
                for (String movie : movies) {
                    if (!castedMovies.contains(movie)) {
                        castedMovies.add(movie);
                    }
                }
                return;
            }
        }

        Actor actorInfo = new Actor(actor, movies);
        actorsInfo.add(actorInfo);
    }
}
