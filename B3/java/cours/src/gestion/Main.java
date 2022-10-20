package gestion;

import javax.swing.*;
import java.util.ArrayList;

public class Main {
    public static void main(String args[]) {
        new Exos().inputMain();
    }

    public void randomMain() {
        ArrayList<Restaurant> restaurants = new ArrayList<Restaurant>();
        restaurants.add(new Restaurant("Latte sur les rochers"));
        restaurants.add(new Restaurant("Une tasse de joie"));
        restaurants.add(new Restaurant("Le Restaurant"));

        ArrayList<Client> listeClient1 = new ArrayList<Client>();
        ArrayList<Client> listeClient2 = new ArrayList<Client>();
        ArrayList<Client> listeClient3 = new ArrayList<Client>();
        ArrayList<Client> listeClientsExpulse = new ArrayList<Client>();

        // generate 20 clients per  list
        for (int i = 0; i < 20; i++) {
            listeClient1.add(generateClient());
            listeClient2.add(generateClient());
            listeClient3.add(generateClient());
        }

        // iterate over the list of clients and serve them
        for (Client client : listeClient1) {
            // chose random restaurant
            int randomRestaurant = (int) (Math.random() * restaurants.size());
            boolean isDehors = restaurants.get(randomRestaurant).servir(client);

            if (isDehors) {
                listeClientsExpulse.add(client);
            }
        }

        // print the profit of each restaurant
        for (Restaurant restaurant : restaurants) {
            System.out.println(restaurant.nom + " a fait un profit de " + restaurant.profit);
        }

        // print the list of expelled clients
        System.out.println("Les clients expulsés sont :");
        for (Client client : listeClientsExpulse) {
            System.out.println(client.nom);
        }
    }

    private static Client generateClient() {
        Tasse tasse = BanqueDeDonne.listeTasses.get((int) (Math.random() * BanqueDeDonne.listeTasses.size()));
        Cafe commande = BanqueDeDonne.listeCommandes.get((int) (Math.random() * BanqueDeDonne.listeCommandes.size()));
        String nom = BanqueDeDonne.listeNoms.get((int) (Math.random() * BanqueDeDonne.listeNoms.size()));

        return new Client(nom, commande, tasse);
    }
}