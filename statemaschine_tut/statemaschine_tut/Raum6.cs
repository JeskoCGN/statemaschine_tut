using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statemaschine_tut
{
    internal class Raum6 : IState
    {
        private string item = "Würfel";
        private bool validInput = false;
        public IState Check()
        {
            if (Console.ReadLine()?.ToLower() == "w") return new Raum7();

            return null!;
        }

        public void StartState()
        {
            Console.WriteLine("In Raum 6 findest du Würfel... ob dich ein Pasch wohl hier raus bring?");
            Console.WriteLine("Willst du " + item + " einsammeln?");
            Console.WriteLine("[J]a/ [N]ein");
            while (validInput == false)
            {
                ConsoleKey input = Console.ReadKey().Key;
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
        }

        public void EndState()
        {
            Console.WriteLine();
        }
    }
}
