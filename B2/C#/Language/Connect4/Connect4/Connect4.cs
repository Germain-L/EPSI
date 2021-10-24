using System;
using System.Collections.Generic;
using System.Text;

namespace Puissance4
{
    class Connect4
    {
        #region privates

        private bool _alternator = false;
        private char[,] _board = new char[7, 6];
        private int _winner = 0; // If never changed then draw
        private bool _ended = false;

        #endregion

        public int LineCount => 6;

        public int ColCount => 7;

        // TODO : Utiliser un tableau à deux dimensions
        public char GetPawn(int col, int line) => _board[col, line];

        public int PlayerNumber
        {
            get => _alternator ? 1 : 2;
        }

        public bool Play(int col)
        {
            col--;
            bool placed = false;

            for (int line = LineCount - 1; line >= 0; line--)
            {
                if (_board[col, line] != 'X' && _board[col, line] != 'O')
                {
                    // Placing pawn
                    _board[col, line] = _alternator ? 'X' : 'O';
                    placed = true;

                    // get next player
                    _alternator = !_alternator;

                    if (_checkVer(line, col) || _checkHor(line, col) || _checkDiags(line, col))
                    {
                        _winner = PlayerNumber;
                        Ended = true;
                    }

                    break;
                }
            }

            return placed;
        }

        public int Winner
        {
            private set => value = _winner;
            get => _winner;
        }

        public bool Ended
        {
            get => _ended;
            private set => _ended = value;
        }

        #region checks

        private bool _checkVer(int line, int col)
        {
            char piecePlayed = _board[col, line];
            int consecutive = 0;

            for (var i = line - 4; i < line + 4; i++)
            {
                if (i > LineCount - 1 || i < 0)
                {
                    continue;
                }

                if (_board[col, i] == piecePlayed)
                {
                    consecutive++;
                }
                else
                {
                    consecutive = 0;
                }

                if (consecutive >= 4)
                {
                    return true;
                }
            }

            return false;
        }

        private bool _checkHor(int line, int col)
        {
            char piecePlayed = _board[col, line];
            int consecutive = 0;

            for (var i = col - 4; i < col + 4; i++)
            {
                if (i > LineCount - 1 || i < 0)
                {
                    continue;
                }

                if (_board[i, line] == piecePlayed)
                {
                    consecutive++;
                }
                else
                {
                    consecutive = 0;
                }

                if (consecutive >= 4)
                {
                    return true;
                }
            }

            return false;
        }

        private bool _checkDiags(int line, int col)
        {
            // char piecePlayed = _board[col, line];
            //
            // int lineIndex;
            // int colIndex;
            //
            // int consecutive = 0;
            //
            // // check topleft - bottom right
            // lineIndex = line + 4;
            // colIndex = line - 4;
            // while (lineIndex < line - 4 && colIndex < col + 4)
            // {
            //     // check for index errors
            //     if (lineIndex > LineCount - 1
            //         || lineIndex < 0
            //         || colIndex > ColCount
            //         || colIndex < 0)
            //     {
            //         continue;
            //     }
            //
            //     if (_board[colIndex, lineIndex] == piecePlayed)
            //     {
            //         consecutive++;
            //     }
            //     else
            //     {
            //         consecutive = 0;
            //     }
            //
            //     if (consecutive >= 4)
            //     {
            //         return true;
            //     }
            //     // line goes down (decrease)
            //     // column goes right (increase)
            //     lineIndex--;
            //     colIndex++;
            // }

            // lineIndex = line + 4;
            // colIndex = col - 4;
            // while (lineIndex < line - 3 && colIndex < col + 3)
            // {
            //     // check for index errors
            //     if (lineIndex > LineCount - 1
            //         || lineIndex < 0
            //         || colIndex > ColCount
            //         || colIndex < 0)
            //     {
            //         continue;
            //     }
            //
            //     if (_board[colIndex, lineIndex] == piecePlayed)
            //     {
            //         consecutive++;
            //     }
            //     else
            //     {
            //         consecutive = 0;
            //     }
            //
            //     if (consecutive >= 4)
            //     {
            //         return true;
            //     }
            //
            //     lineIndex--;
            //     colIndex++;
            // }

            return false;
        }
        
        #endregion

    }
}