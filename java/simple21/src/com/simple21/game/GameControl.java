package com.simple21.game;

import java.util.Scanner;

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
    }
}
