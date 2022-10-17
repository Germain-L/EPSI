public class Tasse {
    float quantiteCafeMax;
    Cafe cafe;

    public Tasse(Cafe cafe) {
        this.cafe = cafe;
        this.quantiteCafeMax = 100f;
        this.cafe.quantiteLiquideMl = this.quantiteCafeMax;
    }

    public Tasse TasseVar(Cafe cafe, float quantiteCafeMax) {
        this.cafe = cafe;
        this.quantiteCafeMax = quantiteCafeMax;
        this.cafe.quantiteLiquideMl = this.quantiteCafeMax;
        return this;
    }

    float boireGorgee(float quantiteCafeBu) {
        this.cafe.quantiteLiquideMl = this.cafe.quantiteLiquideMl - quantiteCafeBu;
        return this.cafe.quantiteLiquideMl;
    }

    void boireTasse() {
        this.cafe.quantiteLiquideMl = 0.0f;
    }
}
