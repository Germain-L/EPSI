package gestion;

import java.util.ArrayList;

public class Restaurant {
    Cafetiere cafetiere;
    double profit;

    ArrayList<Client> listClientServi;

    String nom;

    public Restaurant(String nom) {
        this.cafetiere = new Cafetiere();
        this.nom = nom;
        listClientServi = new ArrayList<Client>();
    }

    public boolean servir(Client client) {
        if (client.commandeCafe == null) {
            client.valeurFacture = 0;
            return false;
        }

        if (client.tasse == null) {
            client.valeurFacture += 2;
            client.tasse = new Tasse(100);

            if (client.commandeCafe.quantiteLiquideMl > client.tasse.quantiteCafeMax) {
                client.tasse.quantiteCafeMax = 500;
                client.valeurFacture += 1;
            }
        }

        if (client.commandeCafe.typeCafe == TypeCafe.BATARD) {
            System.out.println("Cafe non valide, dégage");
            client.valeurFacture = 0;
            return false;
        }

        if (client.tasse.cafe == null) {
            client.tasse.cafe = new Cafe(client.commandeCafe.typeCafe, client.commandeCafe.quantiteLiquideMl);
        }

        if (client.tasse.cafe.typeCafe != client.commandeCafe.typeCafe) {
            client.tasse.cafe.typeCafe = TypeCafe.BATARD;
            client.tasse.cafe.quantiteLiquideMl += client.commandeCafe.quantiteLiquideMl;
        }

        if (client.tasse.quantiteCafeMax < client.commandeCafe.quantiteLiquideMl) {
            System.out.println("Tasse trop petite");
            client.tasse.cafe.quantiteLiquideMl = client.tasse.quantiteCafeMax;
        }

        client.valeurFacture += client.tasse.cafe.typeCafe.coutParMl * client.commandeCafe.quantiteLiquideMl;
        this.profit += client.valeurFacture;
        this.listClientServi.add(client);
        return true;
    }
}
