class Piece:
    def __init__(self, icon, color) -> None:
        self._icon = icon
        self._color = color

    @property
    def icon(self) -> str:
        return self._icon

    @property
    def color(self) -> str:
        return self._color

    @color.setter
    def color(self, value):
        self._color = value

    # Used to print the piece
    def __str__(self) -> str:
        return self._icon
