from board import Board


class Chess:
    def __init__(self):
        self._board = Board()
        self._white = "\033[47m"
        self._black = "\033[40m"
        self._stop = "\033[0m"

    @property
    def board(self) -> Board:
        return self._board

    def make_block(self, color: str, piece: str) -> str:
        block = f'{color*5}\n{color} {piece} {color}\n{color*5}'
        return block

    def __str__(self):
        # print letters coordinates with padding
        string = "    A    B    C    D    E    F    G    H\n  "

        # Used to alternatate colors with a %2
        alternator = 0
        
        # Decremented and used to add line numbers
        line_number = 8
        
        # Iteatrate over the board
        for row in chess.board:
            
            # Print the top line of the block
            # Determine the color of the block
            # add the block to the string
            # Increment the alternator to alternate colors on the next block
            for i in range(len(row)):
                color = chess._white if alternator % 2 == 0 else chess._black
                string += f'{color}     {chess._stop}'
                alternator += 1
                
            # Add the line number to the string and a padding space
            string += f'\n{line_number} '

            for i in row:
                color = chess._white if alternator % 2 == 0 else chess._black
                string += f'{color} {chess._stop} {i} {color} {chess._stop}'
                alternator += 1
                
            string += '\n  '

            for i in range(len(row)):
                color = chess._white if alternator % 2 == 0 else chess._black
                string += f'{color}     {chess._stop}'
                alternator += 1

            string += '\n  '
            alternator += 1
            line_number -= 1

        return string


if __name__ == '__main__':
    chess = Chess()
    print(chess)
    print('------------')
