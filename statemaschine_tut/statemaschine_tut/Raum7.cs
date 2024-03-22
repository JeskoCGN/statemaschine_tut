using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statemaschine_tut
{
    internal class Raum7 : IState
    {
        public IState Check()
        {
            if (Console.ReadLine()?.ToLower() == "n") return new Raum9();
            else if (Console.ReadLine()?.ToLower() == "o") return new Raum6();
            else if (Console.ReadLine()?.ToLower() == "s") return new Raum5();
            else if (Console.ReadLine()?.ToLower() == "w") return new Raum8();

            return null!;
        }

        public void StartState()
        {
            Console.WriteLine("Angekommen in Raum 7 stolperst du über ein Buch. \"The Secret\" lautet der Titel.");
        }

        public void EndState()
        {
            Console.WriteLine();
        }
    }
}
