import java.lang.reflect.Array;

public class ExoIf {
    public static void exo() {
        if (true && true) {
            System.out.println("A1");
        }

        if (true || false) {
            System.out.println("A2");
        }

        if (false) {
            System.out.println("Help me");
        } else {
            System.out.println("A3");
        }

        if (false) {
            System.out.println("help me i'm stuck");
        } else if (true) {
            System.out.println("A4");
        }

        for (int i = 0; i < 5; i++) {
            System.out.printf("B1, %d\n", i);
        }

        int i = 0;
        while (true) {
            System.out.println("C1");
            if (i == 2) {
                break;
            }

            i -= -1;
        }


        do {
            System.out.println("C2");
        } while (false);

        int day = 1;
        switch (day) {
            case 1 -> System.out.println("Lundi");
            case 2 -> System.out.println("Mardi");
            case 3 -> System.out.println("Mercredi");
            case 4 -> System.out.println("Jeudi");
            case 5 -> System.out.println("Vendredi");
            case 6 -> System.out.println("Samedi");
            case 7 -> System.out.println("Dimanche");
        }

    }
}
