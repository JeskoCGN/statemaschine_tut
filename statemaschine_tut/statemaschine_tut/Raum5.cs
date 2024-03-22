using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statemaschine_tut
{
    internal class Raum5 : IState
    {
        private string item = "Glühbirne";
        private bool validInput = false;
        public IState Check()
        {
            if (Console.ReadLine()?.ToLower() == "n") return new Raum7();
            else if (Console.ReadLine()?.ToLower() == "w") return new Raum3();

            return null!;
        }

        public void StartState()
        {
            Console.WriteLine("Endlich Lich in Raum 5. Vorher konntest du nur so weit schauen wie deine Nase reicht.");
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
