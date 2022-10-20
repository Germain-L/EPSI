package game_of_life_cli;

import java.util.Random;

public class Board {
    Cell[][] cells;
    int xSize, ySize;

    int genNumber = 0;

    public Board(int xSize, int ySize) {
        this.xSize = xSize;
        this.ySize = ySize;
        this.cells = new Cell[xSize][ySize];
    }

    void populate() {
        Random random = new Random();
        for (int y = 0; y < ySize; y++) {
            for (int x = 0; x < xSize; x++) {
                Cell newCell = new Cell();
                if (random.ints(0, 2).findFirst().getAsInt() == 1) {
                    newCell.isAlive = true;
                }

                cells[y][x] = newCell;
            }
        }
        genNumber++;
    }

    int countAliveNeighbours(int xCell, int yCell) {
        int numNeighborsAlive = 0;
        for (int y = yCell - 1; y < yCell + 1; y++) {
            int oldY = y;

            if (y < 0) {
                y = ySize - 1;
            } else if (y == ySize - 1) {
                y = 0;
            }

            for (int x = xCell - 1; x < xCell + 1; x++) {
                if (x == xCell && y == yCell) {
                    break;
                }

                int oldX = x;

                if (x < 0) {
                    x = xSize - 1;
                } else if (x == xSize - 1) {
                    x = 0;
                }

                if (cells[y][x].isAlive) {
                    numNeighborsAlive++;
                }

                x = oldX;
            }

            y = oldY;
        }
        return numNeighborsAlive;
    }

    void next() {
        // next generation
        for (int y = 0; y < ySize; y++) {
            for (int x = 0; x < xSize; x++) {
                Cell cell = cells[y][x];
                int aliveNeighbours = countAliveNeighbours(x, y);
                if (cell.isAlive) {
                    if (aliveNeighbours < 2) {
                        cell.isAlive = false;
                    } else if (aliveNeighbours > 3) {
                        cell.isAlive = false;
                    }
                } else {
                    if (aliveNeighbours == 3) {
                        cell.isAlive = true;
                    }
                }
            }
        }
        genNumber++;
    }

    @Override
    public String toString() {
        String out = "";
        for (int y = 0; y < ySize; y++) {
            String newLine = "";
            for (int x = 0; x < xSize; x++) {
                newLine += cells[y][x].isAlive ? "o" : " ";
            }

            out += newLine + "\n";
        }
        return out;
    }
}
