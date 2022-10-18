public class Cafetiere {

    public Cafetiere() {
    }

    void remplirTasse(Tasse tasse) {
        tasse.cafe = new Cafe();
    }

    void remplirTasse(Tasse tasse, TypeCafe typeCafe, double qty) {
        tasse.cafe = new Cafe();
        tasse.cafe.typeCafe = typeCafe;
        tasse.cafe.quantiteLiquideMl = qty;
    }
}
