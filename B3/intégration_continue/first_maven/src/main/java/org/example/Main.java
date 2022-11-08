package org.example;

import java.util.Date;

import org.apache.commons.lang3.StringUtils;
import org.apache.commons.lang3.math.Fraction;
import org.apache.commons.lang3.time.DateFormatUtils;

public class Main {
    public static void main(String[] args) {
        System.out.print(StringUtils.abbreviate("En vrai Maven c'est trop bien", 28) );
        System.out.println(StringUtils.upperCase(" bien"));
        System.out.println(StringUtils.reverse("élupinam ertê tnevuep iuq sgnirtS sel euq sap a y'n li sèrpA"));
        System.out.println("Il était le " + DateFormatUtils.format(new Date(), "hh:mm:ss / Y-MM-dd")  + " Quand j'ai appris comment utilisé Maven et apacheUtils");
        System.out.println("Je vous pari que la " + Fraction.ONE_HALF + " d'entre vous ne lirons pas aussi loin");
        System.out.println("Beau travail !");
    }
}