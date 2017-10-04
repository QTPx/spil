using System;

namespace spil
{

	public class TicTacToeMainMenu
	{
		TicTacToe ticTacToe { get; set; }
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
				if (ticTacToe != null)
				{
					Console.WriteLine(ticTacToe.GetGameBoardView());
				}
				Console.WriteLine("tic tac toe - vælg spil type");
				Console.WriteLine();
				Console.WriteLine("1. standard");
				Console.WriteLine("2. Variant - 3 brikker hver");

				Console.WriteLine("0. exit");
			}
			void DoActionFor1()
			{

				TicTacToeMenu ticTacToeMenu = new TicTacToeMenu();
				ticTacToeMenu.Show();

			}
		}

		private void ShowMenuSelectionError()
		{
			Console.WriteLine("Ugyldigt valg");
		}

		private void DoActionFor2()
		{
			TicTacToeVariationMenu ticTacToeVariationMenu = new TicTacToeVariationMenu();
			ticTacToeVariationMenu.Show();
		}

		private string GetUserChoise()
		{
			Console.WriteLine();
			Console.Write("Indtast dit valg: ");
			return Console.ReadLine();
		}
	}
}