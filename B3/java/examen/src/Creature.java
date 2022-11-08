public class Creature {
    String nom;
    Race race;
    int age;

    Creature() {
        this.nom = "Leignel Germain";
        this.race = Race.Humain;
        this.age = 42;
    }

    Creature(String nom, Race race, int age) {
        this.nom = nom;
        this.race = race;
        this.age = age;
    }

    boolean isAdult() {
        return this.age >= race.ageAdulte;
    }

    void afficherInformations() {
        String adulteOuEnfant = this.isAdult() ? "adulte" : "enfant";
        // print Mon nom est $nom. Je suis un $race. Je suis un $adulteOuEnfant
        System.out.println("Mon nom est " + this.nom + ". Je suis un " + this.race + "Je suis un " + adulteOuEnfant);
    }
}
