using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statemaschine_tut
{
    internal class Raum8 : IState
    {
        private string item = "Taschenlampe";
        private bool validInput = false;
        public IState Check()
        {
            string readLineLower = Console.ReadLine()!.ToLower();
            if (readLineLower == "o") return new Raum7();

            return null!;
        }

        public void StartState()
        {
            Console.WriteLine("Nächster Raum... und nur eine Taschhenlampe. Der Lichkegel erhellt die aufgemalte 8 an der Wand.");
            Console.WriteLine("Willst du " + item + " einsammeln?");
            Console.WriteLine("[J]a/ [N]ein");
            while (validInput == false)
            {
                ConsoleKey input = Console.ReadKey(true).Key;
                if (input == ConsoleKey.J)
                {
                    Console.WriteLine("Item wurde aufgesammelt");
                    Program.taschenlampe = true;
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
            Console.WriteLine("Du kannst nach [O]sten.");
        }

        public void EndState()
        {
            Console.WriteLine();
        }
    }
}
