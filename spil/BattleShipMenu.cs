﻿using System;
namespace spil
{
    internal class BattleShipMenu
    {
        BattleShip battleShip { get; set; }
        public void show()
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
        }
        private void ShowMenu()
        {
            Console.Clear();
            if (battleShip != null)
            {
                Console.WriteLine(battleShip.GetGameBoardView());
            }
            Console.WriteLine("Sænke Slagskip");
            Console.WriteLine();
            Console.WriteLine("1. Opret nyt spil");
            Console.WriteLine("2. Set en brik");
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
            battleShip = new BattleShip();
        }
        private void DoActionFor2()
        {

            String PrintSelect = "";
            PrintSelect += "vælg skibstype \n";
            PrintSelect += "\n";
            PrintSelect += "1. Hangarskib " + " tilbage\n"; //husk at tilføje antal her og under
            PrintSelect += "2. Slagskib " + " tilbage\n";
            PrintSelect += "3. Destroyer " + " tilbage\n";
            PrintSelect += "4. Ubåd " + " tilbage\n";
            PrintSelect += "5. Patroljeskib " + "tilbage\n";

            Console.WriteLine(PrintSelect);

			Console.ReadLine();

        }
    }
}