from objects.piece import Piece


class Coordinate:
    def __init__(self, x, y, color, piece=None):
        self._x = x
        self._y = y
        self._piece = piece
        self._color = color

    @property
    def color(self):
        return self._color

    @property
    def x(self) -> int:
        return self._x

    @property
    def y(self) -> int:
        return self._y

    @property
    def piece(self) -> Piece:
        return self._piece

    @piece.setter
    def piece(self, value):
        if type(value) not in (TypeError, None):
            raise TypeError

        self._piece = value

    @color.setter
    def color(self, value):
        self._color = value
