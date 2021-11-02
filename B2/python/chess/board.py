from piece import Piece


class Board:
    def __init__(self):
        self._turn = 'white'
        self._board = [[' ' for _ in range(8)] for _ in range(8)]
        self.populate_board()

    def next_turn(self):
        self._turn = 'black' if self._turn == 'white' else 'white'

    def populate_board(self):
        print('Populating board...')

        first_line = [
            Piece('♖', 'white'),
            Piece('♘', 'white'),
            Piece('♗', 'white'),
            Piece('♕', 'white'),
            Piece('♔', 'white'),
            Piece('♗', 'white'),
            Piece('♘', 'white'),
            Piece('♖', 'white')
        ]

        last_line = [
            Piece('♜', 'black'),
            Piece('♞', 'black'),
            Piece('♝', 'black'),
            Piece('♚', 'black'),
            Piece('♛', 'black'),
            Piece('♝', 'black'),
            Piece('♞', 'black'),
            Piece('♜', 'black')
        ]

        self._board[0] = first_line
        self._board[1] = [Piece('♙', 'white') for _ in range(8)]
        self._board[6] = [Piece('♟', 'black') for _ in range(8)]
        self._board[7] = last_line

    @property
    def board(self) -> list:
        return self._board

    def __iter__(self):
        ''' Returns the Iterator object '''
        return BoardIterator(self)


class BoardIterator:
    def __init__(self, board):
        self._board = board
        self._row_index = 0
        self._col_index = 0

    def __next__(self):
        if self._row_index < len(self._board.board):
            result = self._board[self._row_index][self._col_index]

            if self._col_index == 7:
                self._row_index += 1
                self._col_index = 0

            else:
                self._col_index += 1

            return result

        # End of Iteration
        raise StopIteration
