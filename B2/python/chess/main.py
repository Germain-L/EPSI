from objects.chess import Chess

# Press the green button in the gutter to run the script.
if __name__ == '__main__':
    chess = Chess("Germain", "Rose")
    print(chess.player1_name, chess.player2_name)
    for rows in chess.board:
        for coord in rows:
            if coord.color:
                print("x", end="")
            else:
                print("y", end="")

        print("")
