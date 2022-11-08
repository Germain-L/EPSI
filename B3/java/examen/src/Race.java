public enum Race {
    Humain(18),
    Calamaris(3),
    Klackons(6),
    Klingon(12),
    Psilon(24),
    Boron(48),
    leignel_germain(96);

    final int ageAdulte;

    Race(int ageAdulte) {
        this.ageAdulte = ageAdulte;
    }
}
