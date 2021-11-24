from flask import Flask, render_template
from models.chessboard import ChessBoard

app = Flask(__name__)
chess = ChessBoard()


@app.route('/')
def hello_world():  # put application's code here
    return 'Hello World!'


@app.route('/chess')
def chess():  # put application's code here
    return render_template("chess.html")


if __name__ == '__main__':
    app.run(debug=True)
