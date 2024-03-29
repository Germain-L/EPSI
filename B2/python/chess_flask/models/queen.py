from models.piece import Piece


class Queen:
    def __init__(self, x, y, color):
        self._p = Piece(x, y, color, 'Q', '♛♕')

    def get_piece(self):
        return self._p
