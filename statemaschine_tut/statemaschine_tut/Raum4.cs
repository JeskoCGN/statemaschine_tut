﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statemaschine_tut
{
    internal class Raum4 : IState
    {
        private string item = "Uhr";
        private bool validInput = false;
        public IState Check()
        {
            if (Console.ReadLine()?.ToLower() == "n") return new Raum10();
            else if (Console.ReadLine()?.ToLower() == "o") return new Raum3();

            return null!;
        }

        public void StartState()
        {
            Console.WriteLine("Tick, Tack.. Tick, Tack. In Raum 4 tickt es ununterbrochen. Die Uhr nervt.");
            Console.WriteLine("Willst du " + item + " einsammeln?");
            Console.WriteLine("[J]a/ [N]ein");
            while (validInput == false)
            {
                ConsoleKey input = Console.ReadKey().Key;
                if (input == ConsoleKey.J)
                {
                    Console.WriteLine("Item wurde aufgesammelt");
                    Program.uhr = true;
                    validInput = true;
                }
                else if (input == ConsoleKey.N)
                {
                    Console.WriteLine("Item wurde nicht aufgesammelt");
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Falscher Input");
                    validInput = false;
                }
            }
        }

        public void EndState()
        {
            Console.WriteLine();
        }
    }
}
