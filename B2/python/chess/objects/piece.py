class Piece:
    def __init__(self, letter, color):
        self._letter = letter
        self._color = color

    @property
    def color(self) -> bool:
        return self._color

    @property
    def letter(self):
        return self._letter
