package com.simple21.player;

import java.util.ArrayList;
import java.util.List;

import com.simple21.card.Card;

public class Player {
    protected String name;

    protected Card hiddenCard;

    protected List<Card> visibleCards;

    protected int sumOfVisibleCards;

    protected Boolean passed;

    protected Player(String name) {
        this.setName(name);
        this.visibleCards = new ArrayList<Card>();
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
    }

    public Card getHiddenCard() {
        return this.hiddenCard;
    }

    public void setHiddenCard(Card card) {
        if (card == null) {
            throw new IllegalArgumentException("Card is null");
        }

        this.hiddenCard = card;
    }

    public void addVisibleCard(Card card) {
        visibleCards.add(card);
        sumOfVisibleCards += card.number;
    }
}
