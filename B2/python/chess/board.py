from piece import Piece


class Board:
    def __init__(self):
        self._turn = 'white'
        self._board = [[' ' for _ in range(8)] for _ in range(8)]
        
        # Add pieces to the board
        self.populate_board()

    def populate_board(self):
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

    
    # Override iter method to be able to iterate over the board
    def __iter__(self):
        '''Returns the next row'''
        return BoardIterator(self)
    
    # Override len method to be able to get the length of the board
    def __len__(self):
        return len(self._board)
    
    # Override getitem method to be able to get the item at a specific index
    def __getitem__(self, index):
        return self._board[index]


# Iterator class to iterate over the board
class BoardIterator:
    def __init__(self, board):
        self._board = board
        self.__index = 0

    # Override next method to be able to get the next result of the iterator
    def __next__(self):
        if self.__index < len(self._board.board):
            result = self._board.board[self.__index]

            self.__index += 1

            return result

        # End of Iteration
        raise StopIteration
