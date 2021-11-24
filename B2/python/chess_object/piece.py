class ChessPiece:
    BLACK_ROOK = '♜'
    BLACK_KNIGHT = '♞'
    BLACK_BISHOP = '♝'
    BLACK_QUEEN = '♛'
    BLACK_KING = '♚'
    BLACK_PAWN = '♟'
    WHITE_ROOK = '♖'
    WHITE_KNIGHT = '♘'
    WHITE_BISHOP = '♗'
    WHITE_QUEEN = '♕'
    WHITE_KING = '♔'
    WHITE_PAWN = '♙'
    EMPTY = ' '


class Piece:
    def __init__(self, color, string, name) -> None:
        self.__color = color
        self.__string = string
        self.__name = name

    @property
    def color(self) -> str:
        return self.__color

    @property
    def __str__(self) -> str:
        return self.__string

    @property
    def name(self) -> str:
        return self.__name
