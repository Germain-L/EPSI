package game_of_life_cli;

public class Main {
    public static void main(String[] args) {
        Board board = new Board(1000, 1000);
        board.populate();

        while (true) {
            System.out.println("Generation " + board.genNumber);
            System.out.printf(board.toString());
            // wait 1 second, then run board.next()
            try {
                Thread.sleep(1000);
            } catch (InterruptedException e) {
                e.printStackTrace();
            }
            board.next();
        }

    }
}
