package org.cafetiere;

import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

public class TasseTest {
    @Test
    public void testTasseSansParam() {
        Tasse tasse = new Tasse();
        assertEquals(100 ,tasse.quantiteCafeMax) ;
    }

    @Test
    public void testTasseBuVide() {
        Tasse tasse = new Tasse();
        tasse.boire();
        assertEquals(0, tasse.cafe.quantiteLiquideMl);
    }

    @Test
    public void testAjoutCafeQuantite() {
        Tasse tasse = new Tasse();
        tasse.addCafe(new Cafe(TypeCafe.MOKA, 50));
        assertEquals(50, tasse.cafe.quantiteLiquideMl);
        assertEquals(TypeCafe.MOKA, tasse.cafe.typeCafe);
    }

    @Test
    public void testAjoutTropCafe() {
        Tasse tasse = new Tasse();
        Cafetiere cafetiere = new Cafetiere();
        cafetiere.remplirTasse(tasse, TypeCafe.MOKA, 300);
        System.out.println(tasse.cafe.quantiteLiquideMl);
    }
}
