package com.epsi.springai.models;

public class Room {
    private String name;
    private String description;
    private int capacity;
    private boolean isAvailable;

    public Room(String name, String description, int capacity, boolean isAvailable) {
        this.name = name;
        this.description = description;
        this.capacity = capacity;
        this.isAvailable = isAvailable;
    }

    public String getName() {
        return name;
    }

    public String getDescription() {
        return description;
    }

    public int getCapacity() {
        return capacity;
    }

    public boolean isAvailable() {
        return isAvailable;
    }
}
