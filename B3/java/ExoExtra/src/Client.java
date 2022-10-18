public class Client {
    Tasse tasse;
    Cafe commandeCafe;
    String nom;
    double valeurFacture;

    public Client(String nom, Cafe commande, boolean giveTasse) {
        this.nom = nom;
        this.commandeCafe = commande;
        if (giveTasse) {
            this.tasse = new Tasse();
        }
    }

    public Client(String nom, Cafe commande, Tasse tasse) {
        this.nom = nom;
        this.commandeCafe = commande;
        this.tasse = tasse;
    }

    public Client() {
        this.nom = "Jean";
        this.tasse = new Tasse();
        this.commandeCafe = null;
    }
}
