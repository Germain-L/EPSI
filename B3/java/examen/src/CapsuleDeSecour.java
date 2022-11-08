import java.util.ArrayList;

public class CapsuleDeSecour extends Vehicule{
    boolean isInSpace;

    CapsuleDeSecour() {
        super();
        this.passagers = new ArrayList<Creature>();
        this.nbMaximumPassager = 3;
        this.isInSpace = false;
    }

    @Override
    boolean ajouterPassager(Creature passager) {
        boolean ajoute = super.ajouterPassager(passager);
        if (ajoute) {
            System.out.println("Passager ajouté");
        } else {
            System.out.println("Plus de place, passager non ajouté");
        }

        return ajoute;
    }



    ArrayList<Creature> lanceCapsule() {
        this.isInSpace = true;
        return passagers;
    }
}
