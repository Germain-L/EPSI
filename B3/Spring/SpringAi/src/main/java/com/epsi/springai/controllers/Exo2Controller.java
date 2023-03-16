package com.epsi.springai.controllers;

import com.epsi.springai.models.SimpleObject;
import org.apache.commons.lang3.StringUtils;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

@RequestMapping("/exo2")
@RestController
public class Exo2Controller {
    @GetMapping("/word")
    public String getWord(@RequestParam String word) {
        System.out.println("The word is: " + word);
        return "The word is : " + word;
    }

    @GetMapping("/reverse")
    public String reverseWord(@RequestParam String word) {
        String reversed = StringUtils.reverse(word);
        System.out.println("The reversed word is: " + reversed);
        return reversed;
    }

    @GetMapping("/greeting")
    public String greetFriends(@RequestParam boolean isFriendly) {
        if (isFriendly) {
            return "Bonjour les amis";
        } else {
            return "On ne me parle pas comme ca !";
        }
    }

    @GetMapping("/objects")
    public List<Object> getObjectList(@RequestParam int count) {

        List<SimpleObject> objects = new ArrayList<>();
        for (int i = 0; i < count; i++) {
            objects.add(new SimpleObject(i));
        }
        return Collections.singletonList(objects);
    }

    @GetMapping("/greeting2")
    public String greetWithNameAndWeather(@RequestParam String p1, @RequestParam(required = false) String p2) {
        if (p2 != null) {
            return "Bonjour " + p1 + ", quel beau temps pour " + p2;
        } else {
            return "Bonjour " + p1 + ", mais ou est diantre nomDeLaVariableP2 ?";
        }
    }
}
