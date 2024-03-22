using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statemaschine_tut
{
    internal class Raum10 : IState
    {
        private bool validInput = false;
        public IState Check()
        {
            string readLineLower = Console.ReadLine()!.ToLower();
            if (readLineLower == "s") return new Raum4();

            return null!;
        }

        public void StartState()
        {
            Console.WriteLine("Raum 10... eine große Türe darüber ein grün leuchtendes \"EXIT\" Schild... hast du es geschafft.");
            Console.WriteLine("Willst du die Türe öffnen?");
            Console.WriteLine("[J]a/ [N]ein");
            while (validInput == false)
            {
                ConsoleKey input = Console.ReadKey(true).Key;
                if (input == ConsoleKey.J)
                {
                    if(Program.uhr&&Program.taschenlampe&&Program.badmintonSchläger)
                    {
                        Console.WriteLine("Du bist erfolgreich entkommen");
                        Console.ReadKey(true);
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Du hast die falschen Sachen mitgenommen");
                    }
                    validInput = true;
                }
                else if (input == ConsoleKey.N)
                {
                    Console.WriteLine("Ok");
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
