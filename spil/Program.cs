using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spil
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Run();
        }

        private void Run()
        {
			Console.WriteLine("Vælg spil");
			Console.WriteLine("1. TicTacToe");
			Console.WriteLine("2. Sænke Slagskibe");
			string choise = Console.ReadLine();
			if (choise == "1")
			{
				TicTacToeMainMenu ticTacToeMainMenu = new TicTacToeMainMenu();
				ticTacToeMainMenu.Show();
			}
			if (choise == "2")
			{
			    BattleShipMenu battleShipMenu = new BattleShipMenu();
                battleShipMenu.show();
			}
        }
    }
}
