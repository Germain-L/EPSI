board = [
    [('R', 1), ('N', 1), ('B', 1), ('Q', 1),
     ('K', 1), ('B', 1), ('N', 1), ('B', 1)],
    [('P', 1), ('P', 1), ('P', 1), ('P', 1),
     ('P', 1), ('P', 1), ('P', 1), ('P', 1)],
    [(''), (''), (''), (''), (''), (''), (''), ('')],
    [(''), (''), (''), (''), (''), (''), (''), ('')],
    [(''), (''), (''), (''), (''), (''), (''), ('')],
    [(''), (''), (''), (''), (''), (''), (''), ('')],
    [('P', 0), ('P', 0), ('P', 0), ('P', 0),
     ('P', 0), ('P', 0), ('P', 0), ('P', 0)],
    [('R', 0), ('N', 0), ('B', 0), ('Q', 0),
     ('K', 0), ('B', 0), ('N', 0), ('B', 0)],
]

WHITE_BLOCK = '█'
BLACK_BLOCK = ' '

WHITES = {
    'R': '♜',
    'N': '♞',
    'B': '♝',
    'Q': '♛',
    'K': '♚',
    'P': '.'
}

BLACKS = {
    'R': '♖',
    'N': '♘',
    'B': '♗',
    'Q': '♕',
    'K': '♔',
    'P': '.'
}


def printBard():
    alternator = 1
    line_number = 8
    for row in board:
        print("  ", end='')

        for _ in range(len(row)):
            if alternator % 2 == 0:
                print(WHITE_BLOCK*4, end='')
            else:
                print(BLACK_BLOCK*4, end='')
            alternator += 1
        print()

        print(f'{line_number} ', end='')
        for piece in row:
            color = WHITE_BLOCK if alternator % 2 == 0 else BLACK_BLOCK
            if piece == '':
                piece = color

            else:
                if color == WHITE_BLOCK:
                    piece = WHITES[piece[0]]
                else:
                    piece = BLACKS[piece[0]]

            if alternator % 2 == 0:
                print(f'{WHITE_BLOCK}{piece}{WHITE_BLOCK*2}', end='')
            else:
                print(f'{BLACK_BLOCK}{piece}{BLACK_BLOCK*2}', end='')
            alternator += 1
        print()

        print("  ", end='')
        for _ in range(len(row)):
            if alternator % 2 == 0:
                print(WHITE_BLOCK*4, end='')
            else:
                print(BLACK_BLOCK*4, end='')
            alternator += 1
        alternator += 1
        print()

    letters = ["A", "B", "C", "D", "E", "F", "G", "H"]
    print("    ", end='')
    for letter in letters:
        print(f"{letter}", end="")
        print("   ", end='')


printBard()
