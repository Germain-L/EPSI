import java.util.ArrayList;

public abstract class Vehicule {
    ArrayList<Creature> passagers;
    int nbMaximumPassager;

    boolean ajouterPassager(Creature creature) {
        if (passagers.size() < nbMaximumPassager) {
            passagers.add(creature);
            return true;
        }

        return false;
    }
}
