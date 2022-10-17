public class Cafetiere {

    public Cafetiere() {
    }

    void remplirTasse(Tasse tasse) {
        tasse.cafe = new Cafe();
    }

    void remplirTasseUnPeu(Tasse tasse, TypeCafe typeCafe, float qty) {
        tasse.cafe.typeCafe = typeCafe;
        tasse.cafe.quantiteLiquideMl = qty;
    }
}
