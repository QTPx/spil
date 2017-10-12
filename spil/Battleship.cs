namespace spil
{
    public class BattleShip
    {
        public char[,] GameBoard { get; set; }
        public BattleShip()
        {
            GameBoard = new char[10, 10] { {' ', ' ', ' ',' ' , ' ', ' ', ' ', ' ',' ' , ' '},
                {' ', ' ', ' ',' ' , ' ', ' ', ' ', ' ',' ' , ' '},
                {' ', ' ', ' ',' ' , ' ', ' ', ' ', ' ',' ' , ' '},
                {' ', ' ', ' ',' ' , ' ', ' ', ' ', ' ',' ' , ' '},
                {' ', ' ', ' ',' ' , ' ', ' ', ' ', ' ',' ' , ' '},
                {' ', ' ', ' ',' ' , ' ', ' ', ' ', ' ',' ' , ' '},
                {' ', ' ', ' ',' ' , ' ', ' ', ' ', ' ',' ' , ' '},
                {' ', ' ', ' ',' ' , ' ', ' ', ' ', ' ',' ' , ' '},
                {' ', ' ', ' ',' ' , ' ', ' ', ' ', ' ',' ' , ' '},
                {' ', ' ', ' ',' ' , ' ', ' ', ' ', ' ',' ' , ' '} };
        }

        public string GetGameBoardView()
        {
            string resultat = "";
            resultat = resultat + "    \n";
            resultat = resultat + "     Y\n";
            resultat = resultat + "     ***************************************************************\n";
            resultat = resultat + "      *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  10  *  " + GameBoard[0, 9] + "  *  " + GameBoard[1, 9] + "  *  " + GameBoard[2, 9] + "  *  " + GameBoard[3, 9] + "  *  " + GameBoard[4, 9] + "  *  " + GameBoard[5, 9] + "  *  " + GameBoard[6, 9] + "  *  " + GameBoard[7, 9] + "  *  " + GameBoard[8, 9] + "  *  " + GameBoard[9, 9] + "  *\n";
            resultat = resultat + "      *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "      ***************************************************************\n";
            resultat = resultat + "      *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  9   *  " + GameBoard[0, 8] + "  *  " + GameBoard[1, 8] + "  *  " + GameBoard[2, 8] + "  *  " + GameBoard[3, 8] + "  *  " + GameBoard[4, 8] + "  *  " + GameBoard[5, 8] + "  *  " + GameBoard[6, 8] + "  *  " + GameBoard[7, 8] + "  *  " + GameBoard[8, 8] + "  *  " + GameBoard[9, 8] + "  *\n";
            resultat = resultat + "      *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "      ***************************************************************\n";
            resultat = resultat + "      *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  8   *  " + GameBoard[0, 7] + "  *  " + GameBoard[1, 7] + "  *  " + GameBoard[2, 7] + "  *  " + GameBoard[3, 7] + "  *  " + GameBoard[4, 7] + "  *  " + GameBoard[5, 7] + "  *  " + GameBoard[6, 7] + "  *  " + GameBoard[7, 7] + "  *  " + GameBoard[8, 7] + "  *  " + GameBoard[9, 7] + "  *\n";
            resultat = resultat + "      *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "      ***************************************************************\n";
            resultat = resultat + "      *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  7   *  " + GameBoard[0, 6] + "  *  " + GameBoard[1, 6] + "  *  " + GameBoard[2, 6] + "  *  " + GameBoard[3, 6] + "  *  " + GameBoard[4, 6] + "  *  " + GameBoard[5, 6] + "  *  " + GameBoard[6, 6] + "  *  " + GameBoard[7, 6] + "  *  " + GameBoard[8, 6] + "  *  " + GameBoard[9, 6] + "  *\n";
            resultat = resultat + "      *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "      ***************************************************************\n";
            resultat = resultat + "      *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  6   *  " + GameBoard[0, 5] + "  *  " + GameBoard[1, 5] + "  *  " + GameBoard[2, 5] + "  *  " + GameBoard[3, 5] + "  *  " + GameBoard[4, 5] + "  *  " + GameBoard[5, 5] + "  *  " + GameBoard[6, 5] + "  *  " + GameBoard[7, 5] + "  *  " + GameBoard[8, 5] + "  *  " + GameBoard[9, 5] + "  *\n";
            resultat = resultat + "      *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "      ***************************************************************\n";
            resultat = resultat + "      *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  5   *  " + GameBoard[0, 4] + "  *  " + GameBoard[1, 4] + "  *  " + GameBoard[2, 4] + "  *  " + GameBoard[3, 4] + "  *  " + GameBoard[4, 4] + "  *  " + GameBoard[5, 4] + "  *  " + GameBoard[6, 4] + "  *  " + GameBoard[7, 4] + "  *  " + GameBoard[8, 4] + "  *  " + GameBoard[9, 4] + "  *\n";
            resultat = resultat + "      *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "      ***************************************************************\n";
            resultat = resultat + "      *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  4   *  " + GameBoard[0, 3] + "  *  " + GameBoard[1, 3] + "  *  " + GameBoard[2, 3] + "  *  " + GameBoard[3, 3] + "  *  " + GameBoard[4, 3] + "  *  " + GameBoard[5, 3] + "  *  " + GameBoard[6, 3] + "  *  " + GameBoard[7, 3] + "  *  " + GameBoard[8, 3] + "  *  " + GameBoard[9, 3] + "  *\n";
            resultat = resultat + "      *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "      ***************************************************************\n";
            resultat = resultat + "      *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  3   *  " + GameBoard[0, 2] + "  *  " + GameBoard[1, 2] + "  *  " + GameBoard[2, 2] + "  *  " + GameBoard[3, 2] + "  *  " + GameBoard[4, 2] + "  *  " + GameBoard[5, 2] + "  *  " + GameBoard[6, 2] + "  *  " + GameBoard[7, 2] + "  *  " + GameBoard[8, 2] + "  *  " + GameBoard[9, 2] + "  *\n";
            resultat = resultat + "      *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "      ***************************************************************\n";
            resultat = resultat + "      *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  2   *  " + GameBoard[0, 1] + "  *  " + GameBoard[1, 1] + "  *  " + GameBoard[2, 1] + "  *  " + GameBoard[3, 1] + "  *  " + GameBoard[4, 1] + "  *  " + GameBoard[5, 1] + "  *  " + GameBoard[6, 1] + "  *  " + GameBoard[7, 1] + "  *  " + GameBoard[8, 1] + "  *  " + GameBoard[9, 1] + "  *\n";
            resultat = resultat + "      *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "      ***************************************************************\n";
            resultat = resultat + "      *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  1   *  " + GameBoard[0, 0] + "  *  " + GameBoard[1, 0] + "  *  " + GameBoard[2, 0] + "  *  " + GameBoard[3, 0] + "  *  " + GameBoard[4, 0] + "  *  " + GameBoard[5, 0] + "  *  " + GameBoard[6, 0] + "  *  " + GameBoard[7, 0] + "  *  " + GameBoard[8, 0] + "  *  " + GameBoard[9, 0] + "  *\n";
            resultat = resultat + "      *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "      ***************************************************************\n";
            resultat = resultat + "       1     2     3     4     5     6     7     8     9     10    X\n";

            return resultat;
        }
            }
        }
