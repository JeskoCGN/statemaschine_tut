using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statemaschine_tut
{
    internal class Raum9 : IState
    {
        public IState Check()
        {
            if (Console.ReadLine()?.ToLower() == "s") return new Raum7();

            return null!;
        }

        public void StartState()
        {
            Console.WriteLine("Ein Raschel in der Ecke! Du gehst einige Schritte zurück und stolperst über Pfeil und Bogen.");
        }

        public void EndState()
        {
            Console.WriteLine();
        }
    }
}
