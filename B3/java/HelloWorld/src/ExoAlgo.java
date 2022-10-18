import java.util.Objects;
import java.util.Random;

public class ExoAlgo {
    void ex1point0() {
        System.out.println("J’ai compris comment faire une méthode !");
    }

    void ex1point1(int num) {
        System.out.println(num);

        while (num != 0) {

            if (num < 0) {
                num++;
            } else {
                num--;
            }

            System.out.println(num);
        }
    }

    void exo1point2(String text) {
        int len = text.length();
        for (int i = 0; i < len; i++) {
            System.out.println(text);
        }
    }

    void exo1point3(int num) {
        int total = 0;
        while (num != 0) {
            total += num;
            num--;
        }

        System.out.println(total);
    }

    void exo1point4(int num) {
        if (num < 0) {
            System.out.println("Num est négatif");
        } else if (num > 0) {
            System.out.println("num est positif");
        } else {
            System.out.println("Num est 0");
        }

        float mod = num % 2;
        if (mod == 0) {
            System.out.println(num + " est paire");
        } else {
            System.out.println(num + " est impaire");
        }
    }

    void exo2point0(int num) {
        int total = 0;
        while (num > 100) {
            total += 1;
            num -= 100;
        }

        System.out.println(total + " Gold coins");
    }

    void exo2point1() {
        Random rand = new Random();
        int de1 = rand.ints(0, 6).findFirst().getAsInt();
        int de2 = rand.ints(0, 6).findFirst().getAsInt();

        if (de1 + de2 == 7) {
            System.out.println("A zut tu a gagné");
        } else {
            System.out.println("Tu a perdu !");
        }
    }


    String padPassword(int num) {
        int len = String.valueOf(num).length();
        String res = String.valueOf(num);
        while (res.length() != 4) {
            res = "0" + res;
            System.out.println(res.length());
        }

        return res.toString();
    }

    void exo2point2(String password) {
        int start = 0;
        String testPassword = padPassword(start);
        while (!Objects.equals(testPassword, password)) {
            start++;
            testPassword = padPassword(start);
        }

        System.out.println("Password is " + testPassword);
    }

    void exo3point1() {

    }
}
