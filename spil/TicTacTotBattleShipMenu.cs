using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spil
{
	class TicTacTotBattleShipMenu
	{
		public void Show()
		{
			bool running = true;
			string choice = "";
			do
			{
				ShowMenu();
				choice = GetUserChoise();
				switch (choice)
				{
					case "1": DoActionFor1(); break;
					case "2": DoActionFor2(); break;
					case "0": running = false; break;
					default: ShowMenuSelectionError(); break;
				}
			} while (running);


			void ShowMenu()
			{
				Console.Clear();
				Console.WriteLine("´Vælg spil");
				Console.WriteLine();
				Console.WriteLine("1. Tic Tac Toe");
				Console.WriteLine("2. Sænke Slagskipe");

				Console.WriteLine("0. exit");
			}
			void DoActionFor1()
			{

				TicTacToeMainMenu ticTacToeMain = new TicTacToeMainMenu();
				ticTacToeMain.Show();

			}
		}

		private void ShowMenuSelectionError()
		{
			Console.WriteLine("Ugyldigt valg");
		}

		private void DoActionFor2()
		{
			//Insæt sænke slagskibe spil
		}

		private string GetUserChoise()
		{
			Console.WriteLine();
			Console.Write("Indtast dit valg: ");
			return Console.ReadLine();
		}
	}
}

