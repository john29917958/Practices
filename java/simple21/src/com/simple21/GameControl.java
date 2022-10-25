package com.simple21;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Random;
import java.util.Scanner;

import com.simple21.card.Card;
import com.simple21.player.ComputerPlayer;
import com.simple21.player.HumanPlayer;
import com.simple21.player.Player;

public class GameControl {
    public static void main(String[] args) throws Exception {
        System.out.println("""
                Welcome to Simple 21!
                You'll play against 3 other players (computers).
                Try to get as close to 21 as possible, without going over.
                What is your name? """);

        Scanner scanner = new Scanner(System.in);
        String username = "";
        do {
            username = scanner.nextLine().trim();
            if (username.length() == 0) {
                System.out.println("Please enter your name:");
            }
        } while (username.length() == 0);
        scanner.close();

        Player human = new HumanPlayer(username);
        Player player1 = new ComputerPlayer("Player 1");
        Player player2 = new ComputerPlayer("Player 2");
        Player player3 = new ComputerPlayer("Player 3");
        Player player4 = new ComputerPlayer("Player 4");

        List<Card> cards = new ArrayList<Card>();
        cards.addAll(Arrays.asList(generateCards("Spades")));
        cards.addAll(Arrays.asList(generateCards("Hearts")));
        cards.addAll(Arrays.asList(generateCards("Clubs")));
        cards.addAll(Arrays.asList(generateCards("Diamonds")));

        Random random = new Random();
        Card card = cards.remove(random.nextInt(cards.size()));
        human.setHiddenCard(card);
        System.out.println(username + " takes a hidden card (It's a " + card.number + ")");
        card = cards.remove(random.nextInt(cards.size()));
        human.addVisibleCard(card);
        System.out.println(username + " takes " + card.number);

        /* do {

        } while (cards.size() > 0); */
    }

    private static Card[] generateCards(String name) {
        List<Card> cardList = new ArrayList<Card>();

        for (int i = 0; i <= 10; i++) {
            cardList.add(new Card(name, i));
        }

        Card[] cards = new Card[cardList.size()];
        cardList.toArray(cards);

        return cards;
    }
}
