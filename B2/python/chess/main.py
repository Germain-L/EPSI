from board import Board


class Chess:

    def __init__(self):
        self._board = Board()

    @property
    def board(self) -> Board:
        return self._board

    def __str__(self):
        string = ""

        for row in self._board:
            for col in row:
                string += str(col) + " "

            string += "\n"

        return string


if __name__ == '__main__':
    chess = Chess()
    print(chess)
