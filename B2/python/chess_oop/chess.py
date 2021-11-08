from board import Board


class Chess:
    def __init__(self) -> None:
        self.__board = Board()
        self.__board.populate()

    @property
    def board(self) -> Board:
        return self.__board

    @board.setter
    def board(self, value):
        if not isinstance(value, Board):
            raise TypeError("board must be a Board")
        self.__board = value

    def display(self) -> None:
        print('  A B C D E F G H')
        for row in self.__board:
            print(row.number, end=" ")
            for piece in row:
                print(piece, end=" ")
            print()