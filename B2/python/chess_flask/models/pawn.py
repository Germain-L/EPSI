from models.piece import Piece


class Pawn:
    def __init__(self, x, y, color):
        self._p = Piece(x, y, color, 'P', '♟♙')

    def get_piece(self):
        return self._p
