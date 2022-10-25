package com.simple21.player;

public class Player {
    public Boolean passed;

    protected String name;

    protected int hiddenCard;

    protected int sumOfVisibleCards;

    protected Player(String name) {
        this.setName(name);
        this.passed = false;
        this.hiddenCard = 0;
        this.sumOfVisibleCards = 0;
    }

    public String getName() {
        return this.name;
    }

    public void setName(String name) {
        if (name == null) {
            throw new IllegalArgumentException("Name is empty");
        }

        name = name.trim();
        if (name.length() == 0) {
            throw new IllegalArgumentException("Name is empty");
        }

        this.name = name;
    }

    public int getHiddenCard() {
        return this.hiddenCard;
    }

    public void setHiddenCard(int card) {
        if (card < 1 || card > 10) {
            throw new IllegalArgumentException("Card is less than 1 or greater than 10");
        }

        this.hiddenCard = card;
    }

    public int getSumOfVisibleCards() {
        return this.sumOfVisibleCards;
    }

    public void addVisibleCard(int card) {
        if (card < 1 || card > 10) {
            throw new IllegalArgumentException("Card is less than 1 or greater than 10");
        }

        sumOfVisibleCards += card;
    }
}
