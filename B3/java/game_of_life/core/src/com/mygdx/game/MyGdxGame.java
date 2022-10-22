package com.mygdx.game;

import com.badlogic.gdx.ApplicationAdapter;
import com.badlogic.gdx.Gdx;
import com.badlogic.gdx.graphics.GL20;
import com.badlogic.gdx.graphics.glutils.ShapeRenderer;

import java.util.ArrayList;

public class MyGdxGame extends ApplicationAdapter {
    ShapeRenderer shapeRenderer;
    boolean play = false;

    Board board;

    @Override
    public void create() {
        // set display size to 1000x1000
        Gdx.graphics.setWindowedMode(2000, 1000);
        this.shapeRenderer = new ShapeRenderer();

        // Create a new board with cells 10 pixels wide and 10 pixels tall
        int width = Gdx.graphics.getWidth();
        int height = Gdx.graphics.getHeight();
        this.board = new Board(width, height, 10);
        System.out.println("Board width: " + this.board.width);
        System.out.println("Board height: " + this.board.height);
    }

    @Override
    public void render() {
        int cellX = 0;
        int cellY = 0;

        // listen for space key
        if (Gdx.input.isKeyJustPressed(62)) {
            this.play = !play;
        }

        ArrayList<int[]> updatedCells = new ArrayList<int[]>();

        if (Gdx.input.isTouched()) {
            cellX = Gdx.input.getX();
            cellY = Gdx.graphics.getHeight() - Gdx.input.getY();

            // Convert the mouse coordinates to cell coordinates
            cellX = cellX / 10;
            cellY = cellY / 10;

            int[] coords = {cellX, cellY};

            // check not out of bounds
            if (cellX < this.board.width && cellY < this.board.height && !updatedCells.contains(coords)) {
                this.board.cells.get(cellY).get(cellX).isAlive = true;
                updatedCells.add(new int[]{cellX, cellY});
            }
        }


        Gdx.gl.glClearColor(.25f, .25f, .25f, 1);
        Gdx.gl.glClear(GL20.GL_COLOR_BUFFER_BIT);

        this.renderBoard();

        if (play) {
            this.board.generateNext();
        }
    }

    private void renderBoard() {
        shapeRenderer.begin(ShapeRenderer.ShapeType.Filled);
        for (int y = 0; y < this.board.height; y++) {
            for (int x = 0; x < this.board.width; x++) {
                Cell cell = this.board.cells.get(y).get(x);
                if (cell.isAlive) {
                    this.shapeRenderer.setColor(0, 1, 0, 1);
                } else {
                    this.shapeRenderer.setColor(0, 0, 0, 1);
                }
                this.shapeRenderer.rect(cell.x, cell.y, 10, 10);
            }
        }
        shapeRenderer.end();
    }

    @Override
    public void dispose() {
        shapeRenderer.dispose();
    }
}