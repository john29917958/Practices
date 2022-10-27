package com.simple21;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Random;
import java.util.Scanner;

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

        System.out.println();

        Player[] pcPlayers = new Player[4];
        Player human = new HumanPlayer(username);
        pcPlayers[0] = new ComputerPlayer("Player 1");
        pcPlayers[1] = new ComputerPlayer("Player 2");
        pcPlayers[2] = new ComputerPlayer("Player 3");
        pcPlayers[3] = new ComputerPlayer("Player 4");
        List<Integer> cards = new ArrayList<Integer>(Arrays.asList(generateCards()));

        Random random = new Random();
        int card = cards.remove(random.nextInt(cards.size()));
        human.setHiddenCard(card);
        System.out.println(String.format("%s takes a hidden card (It's a %d).", username, card));
        card = cards.remove(random.nextInt(cards.size()));
        human.addVisibleCard(card);
        System.out.println(String.format("%s takes %d.", username, card));

        for (Player player : pcPlayers) {
            player.setHiddenCard(cards.remove(random.nextInt(cards.size())));
            System.out.println(String.format("%s takes a hidden card.", player.getName()));
            card = cards.remove(random.nextInt(cards.size()));
            player.addVisibleCard(card);
            System.out.println(String.format("%s takes %d.", player.getName(), card));
        }

        System.out.println();

        System.out.println(String.format("%s has %d total point(s).", human.getName(),
                human.getSumOfVisibleCards() + human.getHiddenCard()));
        for (Player player : pcPlayers) {
            System.out.println(
                    String.format("%s has %d visible points(s).", player.getName(), player.getSumOfVisibleCards()));
        }

        Boolean isAllPlayersPasssed = false;
        Boolean isAnyPlayerGot21Points = false;
        do {
            String command = "";

            do {
                System.out.println();
                System.out.println("Take another card? (Y/N)");
                command = scanner.nextLine().trim().toLowerCase();
                switch (command) {
                    case "y":
                        card = cards.remove(random.nextInt(cards.size()));
                        human.addVisibleCard(card);
                        human.passed = false;
                        System.out.println(String.format("%s takes %d.", username, card));
                        break;
                    case "n":
                        human.passed = true;
                        System.out.println(String.format("%s passes", username));
                        break;
                    default:
                        System.out.println("Please input Y or N.");
                }
            } while (!command.equals("y") && !command.equals("n"));

            for (Player player : pcPlayers) {
                Boolean shouldTakeCard = random.nextBoolean();
                if (shouldTakeCard) {
                    card = cards.remove(random.nextInt(cards.size()));
                    player.addVisibleCard(card);
                    player.passed = false;
                    System.out.println(String.format("%s takes %d.", player.getName(), card));
                } else {
                    player.passed = true;
                    System.out.println(String.format("%s passes", player.getName()));
                }
            }

            System.out.println();
            System.out.println(String.format("%s has %d total point(s).", human.getName(),
                    human.getSumOfVisibleCards() + human.getHiddenCard()));
            for (Player player : pcPlayers) {
                System.out.println(
                        String.format("%s has %d visible points(s).", player.getName(), player.getSumOfVisibleCards()));
            }

            isAllPlayersPasssed = getIsAllPassed(human, pcPlayers);
            isAnyPlayerGot21Points = getIsAnyPlayerGot21Points(human, pcPlayers);
        } while (cards.size() > 0 && !isAllPlayersPasssed && !isAnyPlayerGot21Points);

        scanner.close();
    }

    private static Integer[] generateCards() {
        List<Integer> cardList = new ArrayList<Integer>();

        for (int i = 0; i < 4; i++) {
            for (int j = 1; j <= 10; j++) {
                cardList.add(j);
            }
        }

        Integer[] cards = new Integer[cardList.size()];
        cardList.toArray(cards);

        return cards;
    }

    private static Boolean getIsAllPassed(Player human, Player[] pcPlayers) {
        if (!human.passed)
            return false;

        for (Player player : pcPlayers) {
            if (!player.passed)
                return false;
        }

        return true;
    }

    private static Boolean getIsAnyPlayerGot21Points(Player human, Player[] pcPlayers) {
        if (human.getSumOfVisibleCards() + human.getHiddenCard() == 21) {
            return true;
        }

        for (Player player : pcPlayers) {
            if (player.getSumOfVisibleCards() + player.getHiddenCard() == 21) {
                return true;
            }
        }

        return false;
    }
}
