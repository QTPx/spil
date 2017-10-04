using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spil
{
    public class TicTacToe
    {
        public char[,] GameBoard { get; set; }
        public TicTacToe()
        {
            GameBoard = new char[3, 3] { {' ', ' ', ' '},
                {' ', ' ', ' '}, 
                { ' ', ' ', ' '} };
        }

        public string GetGameBoardView()
        {
            string resultat = "";
			resultat = resultat + "   \n";
            resultat = resultat + "    Y\n";
            resultat = resultat + "    *******************\n";
            resultat = resultat + "    *     *     *     *\n";
            resultat = resultat + "  3 *  " + GameBoard[0, 2] + "  *  " + GameBoard[1, 2] + "  *  " + GameBoard[2, 2] + "  *\n";
            resultat = resultat + "    *     *     *     *\n";
            resultat = resultat + "    *******************\n";
            resultat = resultat + "    *     *     *     *\n";
            resultat = resultat + "  2 *  " + GameBoard[0, 1] + "  *  " + GameBoard[1, 1] + "  *  " + GameBoard[2, 1] + "  *\n";
            resultat = resultat + "    *     *     *     *\n";
            resultat = resultat + "    *******************\n";
            resultat = resultat + "    *     *     *     *\n";
            resultat = resultat + "  1 *  " + GameBoard[0, 0] + "  *  " + GameBoard[1, 0] + "  *  " + GameBoard[2, 0] + "  *\n";
            resultat = resultat + "    *     *     *     *\n";
            resultat = resultat + "    *******************\n";
            resultat = resultat + "       1     2     3    X\n";

            return resultat;
        }

        public void Validate()
        {
			for (int i = 0; i < 3; i++)
			{

				char TestVinder1 = ' ';
				char TestVinder2 = ' ';
				void SlutValg()


				{
					Console.WriteLine("Der er en vinder - vælg '1' for nyt spil eller '2' for Hovedmenu");
					string NewInput = Console.ReadLine();


					if (NewInput == "1")
					{
						GameBoard = new char[3, 3] { {' ', ' ', ' '},
				{' ', ' ', ' '},
				{ ' ', ' ', ' '} };
					}
					else if (NewInput == "2")
					{
						TicTacToeMainMenu ticTacToeMainMenu = new TicTacToeMainMenu();
						ticTacToeMainMenu.Show();
					}


				}
				TestVinder1 = GameBoard[i,0];
				TestVinder2 = GameBoard[0, i];
				if (TestVinder1 == 'x' || TestVinder1 == 'o') 
				{
					if (GameBoard[i,0] == GameBoard[i,1] && GameBoard[i,0] == GameBoard[i,2])
					{

						SlutValg();

					}

				}
				else if (TestVinder2 == 'x' || TestVinder2 == 'o')
				{
					if (GameBoard[0, i] == GameBoard[1, i] && GameBoard[0, i] == GameBoard[2, i])
					{
						SlutValg();

					}
				}
				else if (GameBoard[1,1] == 'x' || GameBoard[1,1] == 'o')
				{
					if (GameBoard[0,0] == GameBoard[1,1] && GameBoard[1,1] == GameBoard[2, 2])
					{
						SlutValg();
					}
					else if (GameBoard[0,2] == GameBoard [1,1] && GameBoard[2,0] == GameBoard[1, 1])
					{
						SlutValg();
					}
				}
			}
            if (playerNr == 1)
            {
                playerNr = 2;
            }
            else
            {
                playerNr = 1;
            }
		}
        int playerNr = 1;
        char piece = 'X';
		public void Place(string Input)
		{
			string[] Inputs;
			Inputs = Input.Split(',');
			int x;
			x = Convert.ToInt32(Inputs[0]) - 1;
			int y;
			y = Convert.ToInt32(Inputs[1]) - 1;

            if (GameBoard[x, y] == ' ')
            {
                if (playerNr == 1)
                {
                    piece = 'X';
                    GameBoard[x, y] = piece;
                }
                else
                {
                    piece = 'O';
                    GameBoard[x, y] = piece;
                }
                if (GameBoard[x, y] == 'X' || GameBoard [x, y] == 'O')
                {
                    Console.WriteLine("Pladsen er allerede taget");
                }
            }
            else
            {
                Console.WriteLine("Ugyldigt valg, vælg vengligst andet plads");
            }
			
		
			
		}
		public void FlytBrik(string Input)
		{
			string[] Inputs;
			Inputs = Input.Split(',');

			int x1;
			x1 = Convert.ToInt32(Inputs[0]) - 1;
			int y1;
			y1 = Convert.ToInt32(Inputs[1]) - 1;
			int x2;
			x2 = Convert.ToInt32(Inputs[2]) - 1;
			int y2;
			y2 = Convert.ToInt32(Inputs[3]) - 1;

			if (GameBoard[x1,y1] == ' ')
			{
				Console.WriteLine("ugyldigt valg, ingen brik at flytte");
				Console.ReadLine();
			}
			else if (GameBoard[x1,y1] == 'x' || GameBoard[x1,y1] == 'o')
			{
				if (GameBoard[x2,y2] == ' ' )
				{
					GameBoard[x2, y2] = GameBoard[x1, y1];
					GameBoard[x1, y1] = ' ';
				}
				else
				{
					Console.WriteLine("Ugyldigt valg, destination er optaget");
					Console.ReadLine();
				}
			}
			Validate();
		}
		// her kan implementeres metoder til at sætte og flytte en brik


	}
}
