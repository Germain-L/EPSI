from objects.coordinate import Coordinate


class Chess:
    def __init__(self, player1=None, player2=None):
        self._player1_name = player1
        self._player2_name = player2
        self._board = []
        self.populate_board()

    @staticmethod
    def generate_board():
        board = []
        alternator = 0

        for row in range(8):
            new_row = []

            for index in range(8):
                color = alternator % 2 == 0

                coord = Coordinate(row, index, color)
                new_row.append(coord)

                alternator += 1

            board.append(new_row)

        return board

    def populate_board(self):
        self.board = self.generate_board()

        pos = {
            "RW": [(0, 0), (0, 7)],
            "NW": [(0, 2), (0, 6)],
            "BW": [(0, 3), (0, 5)],
            "QW": [(0, 4)],
            "KW": [(0, 5)],
            "PW": [(1, x) for x in range(8)],

            "RB": [(7, 0), (7, 7)],
            "NB": [(7, 2), (7, 6)],
            "BB": [(7, 3), (7, 5)],
            "KB": [(7, 4)],
            "QB": [(7, 5)],
            "PB": [(6, x) for x in range(8)]
        }

        for piece in pos:
            for num_of_pieces in pos[piece]:
                for i in range(len(num_of_pieces)):
                    self._board[i[0]][i[1]].piece = piece

    @property
    def board(self):
        return self._board

    @property
    def player1_name(self) -> str:
        return self._player1_name or None

    @property
    def player2_name(self) -> str:
        return self._player2_name or None

    @player1_name.setter
    def player1_name(self, value):
        if type(value) != str:
            raise TypeError
        elif len(value) < 1:
            raise ValueError

        self._player1_name = value

    @player2_name.setter
    def player2_name(self, value):
        if type(value) != str:
            raise TypeError
        elif len(value) < 1:
            raise ValueError

        self._player2_name = value

    @board.setter
    def board(self, value) -> []:
        self._board = value
