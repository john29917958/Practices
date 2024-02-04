package com.study;

/**
 * Represents an animal.
 */
public abstract class Animal {
    protected String name;

    protected int size;

    /**
     * Creates an animal instance.
     * 
     * @param name The name of animal
     * @param size The size of animal
     */
    protected Animal(String name, int size) {
        this.name = name;
        this.size = size;
    }

    /**
     * Gets the name of animal.
     * 
     * @return Returns animal name.
     */
    public String getName() {
        return name;
    }

    /**
     * Sets the name of animal.
     * 
     * @param name The new name of animal.
     */
    public void setName(String name) {
        this.name = name;
    }

    /**
     * Gets the size of animal.
     * 
     * @return Returns animal size.
     */
    public int getSize() {
        return size;
    }

    /**
     * Sets the size of animal.
     * 
     * @param size The new size of animal.
     */
    public void setSize(int size) {
        this.size = size;
    }

    /**
     * Gets the string representing the animal.
     */
    public String toString() {
        return String.format("Size of %s is %d", name, size);
    }
}
