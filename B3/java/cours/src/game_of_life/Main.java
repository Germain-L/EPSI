package game_of_life;

public class Main {
    public static void main(String[] args) {
        Board board = new Board(10, 10);
        board.populate();

        System.out.printf(board.toString());
    }
}
