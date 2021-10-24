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

        #endregion

        // TODO : Compléter cette classe pour implémenter les règles du puissance 4
        // Etape 1
        public int LineCount => 6;
        public int ColCount => 7;

        // Etape 2
        // TODO : Utiliser un tableau à deux dimensions
        public char GetPawn(int line, int col) => _board[line, col];

        // Etape 3
        // Remplir la colonne jouée et changer de joueur
        public int PlayerNumber
        {
            get
            {
                // get next player
                _alternator = !_alternator;
                return _alternator ? 1 : 2;
            }
        }

        public bool Play(int column)
        {
            column--;
            bool placed = false;
            // for (int i = LineCount - 1; i > 0; i--)
            // {
            //     if (GetPawn(i, column) != 'X' && GetPawn(i, column) != 'X')
            //     {
            //         _board[column, i] = _alternator ? 'O' : 'X';
            //         placed = true;
            //         break;
            //     }
            // }

            for (int line = LineCount - 1; line > 1; line--)
            {
                if (_board[column, line] != 'X' && _board[column, line] != 'O')
                {
                    Console.WriteLine($"Playing {column}, {line}");
                    _board[column, line] = _alternator ? 'X' : 'O';
                    break;
                }
            }

            return placed;
        }

        // Etape 4 
        // Améliorer le Play pour qu'il détecte la victoire/nul et implémenter Winner et Ended
        public int Winner => 0;

        public bool Ended => false;
    }
}