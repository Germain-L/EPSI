package game_of_life;

import java.lang.reflect.Array;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Random;

public class Board {
    Cell[][] cells;
    int xSize, ySize;

    public Board(int xSize, int ySize) {
        this.xSize = xSize;
        this.ySize = ySize;
        this.cells = new Cell[xSize][ySize];
    }

    void populate() {
        Random random = new Random();
        for (int y = 0; y < ySize; y++ ) {
            for (int x =  0; x < xSize; x++) {
                Cell newCell = new Cell();
                if (random.ints(0,3).findFirst().getAsInt() == 1) {
                    newCell.isAlive = true;
                }

                cells[y][x] = newCell;
            }
        }
    }

    @Override
    public String toString() {
        String  out = "";
        for (int y = 0; y < ySize; y++ ) {
            String newLine = "";
            for (int x =  0; x < xSize; x++) {
                newLine += cells[y][x].isAlive ? "o" : " ";
            }

            out += newLine + "\n";
        }
        return out;
    }
}
