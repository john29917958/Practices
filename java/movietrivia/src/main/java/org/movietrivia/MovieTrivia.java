package main.java.org.movietrivia;

import java.util.ArrayList;

import main.java.org.movietrivia.movies.Actor;
import main.java.org.movietrivia.movies.Movie;

public class MovieTrivia {
    public MovieTrivia() {

    }

    /**
     * Inserts the actor name and the movies that the actor played in to the actor
     * information list.
     * 
     * @param actor  The name of the actor.
     * @param movies The movies that the actor played in.
     */
    public void insertActor(String actor, String[] movies, ArrayList<Actor> actorsInfo) {
        actor = actor.trim().toLowerCase();
        for (Actor actorInfo : actorsInfo) {
            ArrayList<String> castedMovies = actorInfo.getCastedMovies();
            if (actorInfo.getName().toLowerCase().equals(actor)) {
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

    /**
     * Inserts the name and the ratings of a movie to the movie information list.
     * 
     * @param movie      The movie name.
     * @param ratings    The ratings of the movie. The first element represents the
     *                   critical rating. The second element represents the audience
     *                   rating.
     * @param moviesInfo The movie information list.
     */
    public void insertRating(String movie, int[] ratings, ArrayList<Movie> moviesInfo) {
        if (ratings == null || ratings.length < 2)
            return;
        if (ratings[0] < 0 || ratings[1] > 100 || ratings[0] < 0 || ratings[1] > 100)
            return;

        movie = movie.trim().toLowerCase();

        for (Movie m : moviesInfo) {
            if (m.getName() == movie) {
                m.setCriticalRating(ratings[0]);
                m.setAudienceRating(ratings[1]);
                return;
            }
        }

        Movie m = new Movie(movie, ratings[0], ratings[1]);
        moviesInfo.add(m);
    }

    public ArrayList<String> selectWhereActorIs(String actor, ArrayList<Actor> actorsInfo) {
        actor = actor.toLowerCase();
        for (Actor actorInfo : actorsInfo) {
            if (actorInfo.getName().equals(actor)) {
                return actorInfo.getCastedMovies();
            }
        }

        return new ArrayList<String>();
    }

    public ArrayList<String> selectWhereRatingIs(char comparison, int targetRating, boolean isCritic,
            ArrayList<Movie> moviesInfo) {
        ArrayList<String> movies = new ArrayList<String>();

        for (Movie movie : moviesInfo) {
            int movieRating = isCritic ? movie.getCriticalRating() : movie.getAudienceRating();
            switch (comparison) {
                case '=':
                    if (targetRating == movieRating)
                        movies.add(movie.getName());
                    break;
                case '>':
                    if (targetRating > movieRating)
                        movies.add(movie.getName());
                    break;
                case '<':
                    if (targetRating < movieRating)
                        movies.add(movie.getName());
                    break;
                default:
                    break;
            }
        }

        return movies;
    }
}
