from board import Board


class Chess:
    def __init__(self):
        self._board = Board()
        self.white = "\033[47m"
        self.black = "\033[40m"
        self.stop = "\033[0m"

        self._line = {
            0: False,
            1: True,
            2: False,
            3: False,
            4: True,
            5: False,
            6: False,
            7: True,
            8: False,
            9: False,
            10: True,
            11: False,
            12: False,
            13: True,
            14: False,
            15: False,
            16: True,
            17: False,
            18: False,
            19: True,
            20: False,
            21: False,
            22: True,
            23: False,
        }

    @property
    def board(self) -> Board:
        return self._board

    def __str__(self):
        string = ""

        alternator = 0

        # TODO: find a way to put squares around each positions

        for row in self._board:
            for piece in row:
                background = self.black if alternator % 2 == 0 else self.white
                alternator += 1
                print(f'{background}{piece}{self.stop}', end=" ")
            print()
            alternator += 1
        return string


if __name__ == '__main__':
    chess = Chess()
    print(chess)
