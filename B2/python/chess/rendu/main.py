def gen_board():
    board = [[' ' for _ in range(8)] for _ in range(8)]
    first_line = [
        '♖',
        '♘',
        '♗',
        '♕',
        '♔',
        '♗',
        '♘',
        '♖'
    ]

    last_line = [
        '♜',
        '♞',
        '♝',
        '♚',
        '♛',
        '♝',
        '♞',
        '♜'
    ]

    board[0] = first_line
    board[1] = ['♙'for  _ in range(8)]
    board[6] = ['♟'for  _ in range(8)]
    board[7] = last_line
    
    return board


def make_string(board):
    white = "\033[47m"
    black = "\033[40m"
    stop = "\033[0m"
        
    # add the first line with line letters and a padding for the second line
    string = "    A    B    C    D    E    F    G    H\n  "

    # Used to alternatate colors with a %2
    alternator = 0

    # Decremented and used to add line numbers
    line_number = 8

    # Iteatrate over the board
    for row in board:

        # Print the top line of the block
        # Determine the color of the block
        # add the block to the string
        # Increment the alternator to alternate colors on the next block
        for i in range(len(row)):
            color = white if alternator % 2 == 0 else black
            string += f'{color}     {stop}'
            alternator += 1

        # Add the line number to the string and a padding space
        string += f'\n{line_number} '

        for i in row:
            color = white if alternator % 2 == 0 else black
            string += f'{color} {stop} {i} {color} {stop}'
            alternator += 1

        string += '\n  '

        for i in range(len(row)):
            color = white if alternator % 2 == 0 else black
            string += f'{color}     {stop}'
            alternator += 1

        string += '\n  '
        alternator += 1
        line_number -= 1

    return string


board = gen_board()
print(make_string(board))