from board import Board


class Chess:
    def __init__(self) -> None:
        self.__board = Board()
        self.__board.populate()
        self.__white_playing = True
        help()

    @staticmethod
    def help():
        print("""
        How to play:
        1. Enter a move in the format of 'A1-A2' (A1 is the starting square, A2 is the ending square)
        2. Enter 'exit' to quit
        3. Enter 'help' to see this message again
        """)

    @property
    def white_playing(self):
        return self.__white_playing

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

    def play(self):
        self.display()
        move_done = False

        while not move_done:
            if self.__white_playing:
                print("White playing")
            else:
                print("Black playing")

            print("Enter move (ex: A1-A2): ")
            move = input().lower()

            # check if user wants to quit or help
            if move == "exit":
                exit()
            elif move == "help":
                help()

            # compare move with regex and restart loop if move is invalid
            regex = r'^[a-h][1-8]-[a-h][1-8]$'
            if not regex.match(move):
                print("Invalid move")
                continue

            move_done = True

            # split move into two coordinates
            original = move[0:2]
            new = move[3:5]

            self.__board.move(original, new)
            self.__white_playing = not self.__white_playing
