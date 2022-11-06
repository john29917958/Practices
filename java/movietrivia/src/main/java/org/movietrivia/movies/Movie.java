package main.java.org.movietrivia.movies;

public class Movie {
    private String name;

    private int criticsRating;

    private int audienceRating;

    public Movie(String name, int criticsRating, int audienceRating) {
        this.name = name;
        this.criticsRating = criticsRating;
        this.audienceRating = audienceRating;
    }

    public String getName() {
        return this.name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public int getCriticalRating() {
        return this.criticsRating;
    }

    public void setCriticalRating(int value) {
        this.criticsRating = value;
    }

    public int getAudienceRating() {
        return this.audienceRating;
    }

    public void setAudienceRating(int value) {
        this.audienceRating = value;
    }
}
