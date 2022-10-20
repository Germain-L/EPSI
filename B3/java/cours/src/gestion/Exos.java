package gestion;

import javax.swing.*;

public class Exos {
    public void inputMain() {
        JFrame frame = new JFrame();

        // Créer un objet restaurent.
        // Dit bonjour au client et demande lui son nom avec une JOption showInputDialog.
        // Demande au client, avec son nom, si tu peux prendre sa commande avec un JOption showMessageDialog.

        Restaurant restaurant = new Restaurant("Le café de la rue");
        String nomClient = JOptionPane.showInputDialog(frame, "Bonjour, quel est votre nom ?");

        // demande au client, avec son nom, si tu peux prendre sa commande avec un JOption showMessageDialog.
        // return false si le client ne veut pas de café.
        // return true si le client veut un café.
        boolean commande = JOptionPane.showConfirmDialog(frame, "Bonjour " + nomClient + ", voulez-vous prendre une commande ?") == JOptionPane.YES_OPTION;
        if (!commande) {
            JOptionPane.showMessageDialog(frame, "D'accord, au revoir.");
            return;
        }


    }
}
