package com.study;

import static java.util.Map.entry;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.EnumSet;
import java.util.HashMap;
import java.util.LinkedList;
import java.util.Map;

public class Study {
    public static void main(String[] args) {
        System.out.println("=========== Primitive types ===========");
        System.out.println("[ Integer ]");
        Integer integer = 10;
        Class classType = integer.getClass();
        System.out.println(String.format("Value of \"integer\" is: %s", integer));
        int intP = 10;
        System.out.println(String.format("Value of \"integer\" declared with primitive keyword is: %s", intP));
        System.out.println(String.format("Type of \"integer\" is: %s", classType.getName()));

        System.out.println("[ String ]");
        String str = "Hello, Kimmy";
        classType = str.getClass();
        System.out.println(String.format("Value of \"str\" is: %s", str));
        str = """
                This
                is
                a
                multi-line
                string.
                """;
        System.out.println(String.format("Value of multi-line string \"str\" is: %s", str));
        System.out.println(String.format("Type of \"str\" is: %s", classType.getName()));

        double precisedNumber = 0.1;
        System.out.println(String.format("Value of \"precisedNumber\" is: %s", precisedNumber));

        int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };
        classType = arr.getClass();
        System.out.println("Values \"arr\" is: " + Arrays.toString(arr));
        System.out.println("Type of \"arr\" is: " + classType.getName());

        System.out.println("=========== ArrayList ===========");

        ArrayList<String> arrList = new ArrayList<String>();
        classType = arrList.getClass();
        arrList.add("1");
        arrList.add("3");
        arrList.add("2");
        arrList.add(0, "0");
        System.out.println("Values of \"arrList\" is: ");
        for (String elem : arrList) {
            System.out.println(elem);
        }
        System.out.println("Access the first value of arrList: \"" + arrList.get(0) + "\"");
        arrList.remove(0);
        System.out.println("Values of \"arrList\" after removing first element:");
        for (int i = 0; i < arrList.size(); i++) {
            System.out.println(arrList.get(i));
        }
        arrList.clear();
        System.out.println(String.format("Length of \"arrayList\" after cleared is: %d", arrList.size()));
        System.out.println(String.format("Type of \"arrList\" is: %s", classType.getName()));

        System.out.println("=========== LinkedList ===========");
        LinkedList list = new LinkedList();
        list.add("123");
        list.add(321);
        System.out.println("Values of \"list\" is:");
        for (Object o : list) {
            System.out.println(o.toString());
        }

        System.out.println("=========== HashMap ===========");
        Map<String, String> map = new HashMap<String, String>(Map.ofEntries(
                entry("title1", "Java"),
                entry("title2", "is")));
        map.put("title3", "awesome!");
        classType = map.getClass();
        System.out.println("Value of map is: ");
        for (String key : map.keySet()) {
            System.out.println(key + ": " + map.get(key));
        }
        System.out.println(String.format("Type of \"map\" is: %s", classType.getName()));

        System.out.println("=========== enum ===========");
        enum Colors {
            Red {
                @Override
                public String toString() {
                    return "RED";
                }
            },
            Green {
                @Override
                public String toString() {
                    return "GREEN";
                }
            },
            Blue {
                @Override
                public String toString() {
                    return "BLUE";
                }
            }
        }
        System.out.println(String.format("All enum values of \"Colors\" is: %s", Arrays.toString(Colors.values())));
        Colors color = Colors.Green;
        classType = color.getClass();
        System.out.println("Value of \"color\" is: " + color);
        System.out.println("Does \"color\" equals Colors.Red: " + (color == Colors.Red));
        System.out.println("Does \"color\" equals Colors.Green: " + (color == Colors.Green));
        System.out.println(String.format("Type of \"color\" is: %s", classType));
        for (Colors info : EnumSet.allOf(Colors.class)) {
            String enumValue = info.name();
        }

        System.out.println(String.format("Type of \"classType\" is: %s", classType.getClass()));
        System.out.println("Is \"color\" an instance of \"Colors\": " + (color instanceof Colors));

        System.out.println("=========== final (namely constant) ===========");
        final int CONSTINT = 10;
        // Compile error of modifying constant value: CONSTINT = 20;
        System.out.println(String.format("Value of constant \"CONSTINT\" is: %d", CONSTINT));

        System.out.println("=========== while loop (from 10 down to 1) ===========");
        integer = 10;
        while (integer > 0) {
            System.out.println(String.format("While loop: %d", integer));
            integer -= 1;
        }

        System.out.println("=========== for loop (from 0 down to 9) ===========");
        integer = 10;
        for (int i = 0; i < integer; i++) {
            System.out.println(String.format("for loop: %d", i));
        }

        System.out.println("=========== Try catch (exception handling) ===========");
        try {
            throw new IllegalArgumentException("Invalid argument");
        } catch (IllegalArgumentException e) {
            System.out.println("IllegalArgumentException: " + e.getMessage());
        } catch (Exception e) {
            System.out.println("Exception: " + e.getMessage());
        }

        System.out.println("=========== Function ===========");
        integer = add(10, 20);
        System.out.println(String.format("Return value of function add(10, 20) is: %d", integer));

        System.out.println("=========== Class ===========");
        Animal human = new Human("Allen", "Iverson", 100);
        System.out.println(human);

        System.out.println("=========== Thread ===========");
        Thread thread = new Thread(new Job(3));
        thread.start();

        try {
            thread.join();
        } catch (InterruptedException e) {
            e.printStackTrace();
        }

        System.out.println("End of program.");
    }

    private static int add(int a, int b) {
        return a + b;
    }
}