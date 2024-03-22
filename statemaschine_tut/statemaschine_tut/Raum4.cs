using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statemaschine_tut
{
    internal class Raum4 : IState
    {
        public IState Check()
        {
            if (Console.ReadLine()?.ToLower() == "n") return new Raum10();
            else if (Console.ReadLine()?.ToLower() == "o") return new Raum3();

            return null!;
        }

        public void StartState()
        {
            Console.WriteLine("Tick, Tack.. Tick, Tack. In Raum 4 tickt es ununterbrochen. Die Uhr nervt.");
        }

        public void EndState()
        {
            Console.WriteLine();
        }
    }
}
