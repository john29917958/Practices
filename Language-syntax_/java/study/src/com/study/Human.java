package com.study;

/**
 * Represents a human.
 */
public class Human extends Animal {
    private String lastName;

    /**
     * Creates a human instance.
     * 
     * @param firstName The first name of human.
     * @param lastName  The last name of human.
     * @param size      The size of human.
     */
    protected Human(String firstName, String lastName, int size) {
        super(firstName, size);
        this.lastName = lastName;
    }

    /**
     * Gets the information of the human.
     * 
     * @return Returns the name and size of human.
     */
    public String composeDescription() {
        return String.format("Size of %s, %s is %d", name, lastName, size);
    }

    /**
     * Gets the string that represetns the current animal.
     * 
     * @see com.study.Animal#toString()
     */
    @Override
    public String toString() {
        return composeDescription();
    }
}
