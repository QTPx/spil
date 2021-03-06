﻿using System;

namespace spil
{
	public class TicTacToeVariationMenu
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
					case "3": DoActionFor3(); break;
					case "0": running = false; break;
					default: ShowMenuSelectionError(); break;
				}
			} while (running);
		}

		private void ShowMenu()
		{
			Console.Clear();
			if (ticTacToe != null)
			{
				Console.WriteLine(ticTacToe.GetGameBoardView());
			}
			Console.WriteLine("tic tac toe Variation");
			Console.WriteLine();
			Console.WriteLine("1. Opret nyt spil");
			Console.WriteLine("2. Set en brik");
			Console.WriteLine("3. Flyt en brik");
			Console.WriteLine();
			Console.WriteLine("0. exit");
		}

		private string GetUserChoise()
		{
			Console.WriteLine();
			Console.Write("Indtast dit valg: ");
			return Console.ReadLine();
		}

		private void ShowMenuSelectionError()
		{
			Console.WriteLine("Ugyldigt valg.");
			Console.ReadLine();
		}

		private void DoActionFor1()
		{
			ticTacToe = new TicTacToe();
		}
		private void DoActionFor2()
		{
			Console.WriteLine("vælg koordinat 'x,y'");
			ticTacToe.Place(Console.ReadLine());

		}
		private void DoActionFor3()
		{
			Console.WriteLine("Vælg Koordinat for brik der skal flyttes og koordinat den skal placeres i 'x,y,x,y'");
			ticTacToe.FlytBrik(Console.ReadLine());
		}
	}
}