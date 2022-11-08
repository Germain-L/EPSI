public class Controleur {
    Race race;

    Controleur(Race race) {
        this.race = race;
    }

    boolean verifierVaisseau(Vaisseau vaisseau) {
        if (!vaisseau.capitaine.isAdult()) {
            System.out.println("Capitaine n'est pas adulte");
            return false;
        }

        if (this.race == Race.Klingon) {
            for (Creature creature : vaisseau.passagers) {
                if (creature.race == Race.Klingon) {
                    System.out.println("Klingon controleur, Klingons passager détécté");
                    return false;
                }
            }
        }

        boolean klackonsAlreadyExist = false;
        for (Creature creature : vaisseau.passagers) {
            if (creature.race ==  Race.Klackons) {
                if (klackonsAlreadyExist) {
                    System.out.println("Trop de Klackons sur ce vaisseau");
                    return false;
                } else {
                    klackonsAlreadyExist = true;
                }
            }
        }

        int numHumans = 0;
        for (Creature creature : vaisseau.passagers) {
            if (creature.race == Race.Humain) {
                numHumans++;
            }
        }
        if (numHumans % 2 != 0) {
            System.out.println("Nombre d'humain est impaire");
            return false;
        }

        for (Creature creature : vaisseau.passagers) {
            if (creature.nom == "Leignel Germain" && creature.race != Race.Humain) {
                System.out.println("J'existe mais pas humain");
                return false;
            }
        }

        if (vaisseau.passagers.size() > vaisseau.nbMaximumPassager) {
            System.out.println("Trop de passagers");
            return false;
        }

        System.out.println("Tests OK");
        return true;
    }
}
