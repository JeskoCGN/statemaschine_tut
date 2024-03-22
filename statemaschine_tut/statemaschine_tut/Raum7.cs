using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statemaschine_tut
{
    internal class Raum7 : IState
    {
        private string item = "Buch";
        private bool validInput = false;
        public IState Check()
        {
            string readLineLower = Console.ReadLine()!.ToLower();
            if (readLineLower == "n") return new Raum9();
            else if (readLineLower == "o") return new Raum6();
            else if (readLineLower == "s") return new Raum5();
            else if (readLineLower == "w") return new Raum8();

            return null!;
        }

        public void StartState()
        {
            Console.WriteLine("Angekommen in Raum 7 stolperst du über ein Buch. \"The Secret\" lautet der Titel.");
            Console.WriteLine("Willst du " + item + " einsammeln?");
            Console.WriteLine("[J]a/ [N]ein");
            while (validInput == false)
            {
                ConsoleKey input = Console.ReadKey(true).Key;
                if (input == ConsoleKey.J)
                {
                    Console.WriteLine("Item wurde aufgesammelt");
                    Program.falseItem = true;
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
            Console.WriteLine("Du kannst nach [N]orden, [O]sten, [S]üden oder [W]esten.");
        }

        public void EndState()
        {
            Console.WriteLine();
        }
    }
}
