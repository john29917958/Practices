Singleton
===
Scenario: Only one instance of an object should exist in the entire system.

Pattern: A class with private constructor, a private static instance member, and a public static method for getting the “single” private member.

Example: Database connection, game server connection.

![UML](UML.jpg)