import javax.swing.*;
import java.util.ArrayList;

public class Vaisseau extends Vehicule {
    Creature capitaine;
    ArrayList<CapsuleDeSecour> capsulesDeSecour;
    int nbMaximumPassager;

    Vaisseau() {
        this.capitaine = new Creature("Leignel Germain", Race.Humain, 42);

        this.capsulesDeSecour = new ArrayList<>();
        this.capsulesDeSecour.add(new CapsuleDeSecour());
        this.capsulesDeSecour.add(new CapsuleDeSecour());

        this.passagers = new ArrayList<Creature>();

        this.nbMaximumPassager = 10;
    }

    Vaisseau(Creature capitaine, ArrayList<Creature> passagers, int nbPassagerMax, int nbCapsuleMax) {
        this.capitaine = capitaine;
        this.passagers = passagers;
        this.nbMaximumPassager = nbPassagerMax;
        this.capsulesDeSecour = new ArrayList<>();

        for (int i = 0; i < nbCapsuleMax; i++) {
            this.capsulesDeSecour.add(new CapsuleDeSecour());
        }
    }

    @Override
    boolean ajouterPassager(Creature creature) {
        boolean ajoute = super.ajouterPassager(creature);
        if (ajoute) {
            System.out.println("Passager rajouté");
        } else {
            System.out.println("Plus de place, passager non ajouté");
        }

        return ajoute;
    }

    void ajouterPassagerClandestin(Creature passager, int potDeVin) {
        this.passagers.add(passager);

    }

    boolean ajouterPassagerCapsuleSecour() {
        if (this.passagers.size() == 0 || this.capsulesDeSecour.size() == 0) {
            return false;
        }

        Creature passager = this.passagers.get(0);
        boolean isAdded;
        for (int i = 0; i < this.capsulesDeSecour.size(); i++) {
            isAdded = this.capsulesDeSecour.get(i).ajouterPassager(passager);
            if (isAdded) {
                this.passagers.remove(0);
                return true;
            }
        }

        return false;
    }

    void lanceCapsule(int numCapsule) {
        CapsuleDeSecour capsuleDeSecour = this.capsulesDeSecour.get(numCapsule);
        if (capsuleDeSecour.passagers.size() == capsuleDeSecour.nbMaximumPassager) {
            capsuleDeSecour.lanceCapsule();
        } else {
            if (this.passagers.size() == 0) {

                if (capitaine.nom == "Leignel Germain") {
                    JFrame frame = new JFrame();
                    JOptionPane.showMessageDialog(frame, "J'ai bien peur de ne pas pouvoir faire ça, Dave");
                    return;
                }

                capsuleDeSecour.ajouterPassager(capitaine);
                capsuleDeSecour.lanceCapsule();
            }
        }
    }
}
