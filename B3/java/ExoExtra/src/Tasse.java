public class Tasse {
    double quantiteCafeMax;
    Cafe cafe;

    public Tasse() {
        this.quantiteCafeMax = 100;
    }

    void boire() {
        this.cafe.quantiteLiquideMl = 0.0;
    }

    void boire(double quantiteCafeBu) {
        this.cafe.quantiteLiquideMl = this.cafe.quantiteLiquideMl - quantiteCafeBu;
    }
}
