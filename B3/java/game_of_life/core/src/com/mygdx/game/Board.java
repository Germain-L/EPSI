package com.mygdx.game;

import java.util.ArrayList;

public class Board {
    ArrayList<ArrayList<Cell>> cells;
    int width;
    int height;

    int cellSize;

    public Board(int x, int y, int cellSize) {
        this.cellSize = cellSize;
        this.cells = new ArrayList<ArrayList<Cell>>();
        this.width = x / cellSize;
        this.height = y / cellSize;
        for (int iY = 0; iY < y; iY++) {
            ArrayList<Cell> row = new ArrayList<Cell>();
            for (int iX = 0; iX < x; iX++) {
                Cell cell = new Cell();
                cell.x = iX * this.cellSize;
                cell.y = iY * this.cellSize;
                row.add(cell);
            }
            this.cells.add(row);
        }
    }

    public void generateNext() {
        ArrayList<ArrayList<Cell>> next = new ArrayList<ArrayList<Cell>>();
        for (int y = 0; y < this.height; y++) {
            ArrayList<Cell> row = new ArrayList<Cell>();
            for (int x = 0; x < this.width; x++) {
                Cell cell = new Cell();
                cell.x = x * this.cellSize;
                cell.y = y * this.cellSize;
                row.add(cell);
            }
            next.add(row);
        }

        for (int y = 0; y < this.height; y++) {
            for (int x = 0; x < this.width; x++) {
                int neighbors = this.countNeighbors(x, y);
                if (this.cells.get(y).get(x).isAlive) {
                    if (neighbors < 2) {
                        next.get(y).get(x).isAlive = false;
                    } else if (neighbors == 2 || neighbors == 3) {
                        next.get(y).get(x).isAlive = true;
                    } else if (neighbors > 3) {
                        next.get(y).get(x).isAlive = false;
                    }
                } else {
                    if (neighbors == 3) {
                        next.get(y).get(x).isAlive = true;
                    }
                }
            }
        }
        this.cells = next;
    }

    private int countNeighbors(int x, int y) {
        int total = 0;
        for (int neighY = y - 1; neighY < y + 2; neighY++) {
            if (neighY < 0 || neighY >= height) {
                continue;
            }

            for (int neighX = x - 1; neighX < x + 2; neighX++) {
                if (neighX == x && neighY == y) {
                    continue;
                }

                if (neighX < 0 || neighX >= width) {
                    continue;
                }

                if (this.cells.get(neighY).get(neighX).isAlive) {
                    total += 1;
                }
            }
        }

        return total;
    }
}
