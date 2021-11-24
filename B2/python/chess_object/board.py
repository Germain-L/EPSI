from piece import ChessPiece, Piece
from row import ChessRow


class Board:
    def __init__(self):
        self.__grid = [[None for _ in range(8)] for _ in range(8)]

    def populate(self):
        for row_index in range(0, 8):
            if row_index == 0:
                self.__grid[row_index] = ChessRow(row_index + 1, [
                    Piece("white", "♖", "rook"),
                    Piece("white", "♘", "knight"),
                    Piece("white", "♗", "bishop"),
                    Piece("white", "♕", "queen"),
                    Piece("white", "♔", "king"),
                    Piece("white", "♗", "bishop"),
                    Piece("white", "♘", "knight"),
                    Piece("white", "♖", "rook"),
                ])

            elif row_index == 7:
                self.__grid[row_index] = ChessRow(row_index + 1, [
                    Piece("black", "♜", "rook"),
                    Piece("black", "♞", "knight"),
                    Piece("black", "♝", "bishop"),
                    Piece("black", "♚", "king"),
                    Piece("black", "♛", "queen"),
                    Piece("black", "♝", "bishop"),
                    Piece("black", "♞", "knight"),
                    Piece("black", "♜", "rook"),
                ])

            elif row_index == 1:
                self.__grid[row_index] = ChessRow(
                    row_index + 1, [Piece("white", "♙", "pawn") for _ in range(8)])

            elif row_index == 6:
                self.__grid[row_index] = ChessRow(
                    row_index + 1, [Piece("black", "♟", "pawn") for _ in range(8)])
            else:
                self.__grid[row_index] = ChessRow(
                    row_index + 1, [Piece("", " ", "empty") for _ in range(8)])

    def move(self, orignal, new):
        '''convert Letter to row number'''
        row = orignal[0].translate(str.maketrans('12345678', 'ABCDEFGH'))
        column = orignal[1]
        # TODO

    def __str__(self) -> str:
        return str(self.__grid)

    def __getitem__(self, index):
        return self.__grid[index]

    def __len__(self):
        return len(self.__grid)

    def __iter__(self):
        '''Returns the next row'''
        return BoardIterator(self)


class BoardIterator:
    def __init__(self, board):
        self.__board = board
        self.__row_index = 0

    # Override next method to be able to get the next result of the iterator
    def __next__(self):
        if self.__row_index < len(self.__board):
            result = self.__board[self.__row_index]

            self.__row_index += 1

            return result

        # End of Iteration
        raise StopIteration
