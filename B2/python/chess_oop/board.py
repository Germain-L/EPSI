from piece import ChessPiece
from row import ChessRow


class Board:
    def __init__(self):
        self.__grid = [[None for _ in range(8)] for _ in range(8)]

    def populate(self):
        for row_index in range(0, 8):
            if row_index == 0:
                self.__grid[row_index] = ChessRow(row_index + 1, [
                    ChessPiece.WHITE_ROOK,
                    ChessPiece.WHITE_KNIGHT,
                    ChessPiece.WHITE_BISHOP,
                    ChessPiece.WHITE_QUEEN,
                    ChessPiece.WHITE_KING,
                    ChessPiece.WHITE_BISHOP,
                    ChessPiece.WHITE_KNIGHT,
                    ChessPiece.WHITE_ROOK,
                ])

            elif row_index == 7:
                self.__grid[row_index] = ChessRow(row_index + 1, [
                    ChessPiece.BLACK_ROOK,
                    ChessPiece.BLACK_KNIGHT,
                    ChessPiece.BLACK_BISHOP,
                    ChessPiece.BLACK_KING,
                    ChessPiece.BLACK_QUEEN,
                    ChessPiece.BLACK_BISHOP,
                    ChessPiece.BLACK_KNIGHT,
                    ChessPiece.BLACK_ROOK,
                ])

            elif row_index == 1:
                self.__grid[row_index] = ChessRow(
                    row_index + 1, [ChessPiece.WHITE_PAWN for _ in range(8)])

            elif row_index == 6:
                self.__grid[row_index] = ChessRow(
                    row_index + 1, [ChessPiece.BLACK_PAWN for _ in range(8)])
            else:
                self.__grid[row_index] = ChessRow(
                    row_index + 1, [ChessPiece.EMPTY for _ in range(8)])

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
