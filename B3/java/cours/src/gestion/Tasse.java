package gestion;

public class Tasse {
    double quantiteCafeMax;
    Cafe cafe;

    public Tasse() {
        this.quantiteCafeMax = 100;
    }

    public Tasse(double quantiteCafeMax) {
        this.quantiteCafeMax = quantiteCafeMax;
    }

    void boire() {
        this.cafe.quantiteLiquideMl = 0.0;
    }

    void boire(double quantiteCafeBu) {
        this.cafe.quantiteLiquideMl = this.cafe.quantiteLiquideMl - quantiteCafeBu;
    }
}
