package com.epsi.springai.controllers;

import com.epsi.springai.models.Room;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import java.util.ArrayList;
import java.util.List;

@RestController
@RequestMapping("/exo1")
public class Exo1Controller {
    @GetMapping("/")
    public void sayHello() {
        System.out.println("Bonjour");
    }

    @GetMapping("/string")
    public void SayHelloWithString() {
        System.out.println("Bonjour");
    }

    @GetMapping("/room")
    public Room getRoom() {
        Room room = new Room("Conference Room", "A spacious conference room with a large table and chairs", 12, true);
        return room;
    }
    @GetMapping("/rooms")
    public List<Room> getRooms() {
        List<Room> rooms = new ArrayList<>();
        rooms.add(new Room("Conference Room 1", "A large conference room with a projector and whiteboard", 12, true));
        rooms.add(new Room("Meeting Room 1", "A small meeting room with a table and chairs", 4, false));
        rooms.add(new Room("Classroom 1", "A classroom with desks and chairs", 30, true));
        rooms.add(new Room("Boardroom", "A boardroom with a large table and chairs", 20, true));
        rooms.add(new Room("Training Room 1", "A training room with computers and desks", 16, true));
        return rooms;
    }
}
