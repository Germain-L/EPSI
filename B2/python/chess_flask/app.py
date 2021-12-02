from flask import Flask, render_template, request
from models.chessboard import ChessBoard
from pprint import pprint

app = Flask(__name__)
chessBoard = ChessBoard()


@app.route('/')
def hello_world():  # put application's code here
    return render_template("chess.html")


@app.route('/chess')
def chess():  # put application's code here
    board = []

    to = request.args.get("move")
    original = request.args.get("original")
    undo = request.args.get("to")

    for y in range(0, 8):
        row = []
        for x in range(0, 8):
            piece = chessBoard.get_piece(x, y)
            symbol = ""
            if piece is not None:
                symbol = piece.get_piece().get_symbol(0)
            row.append(symbol)
        board.append(row)

    for i in board:
        print(i)

    return render_template("dynamic.html", board=board, board_len=len(board), len_row=len(board[0]))


if __name__ == '__main__':
    app.run(debug=True)
