using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statemaschine_tut
{
    internal class Raum1 : IState
    {
        public IState Check()
        {
            if (Console.ReadLine()?.ToLower() == "n") return new Raum3();
            if (Console.ReadLine()?.ToLower() == "w") return new Raum2();

            return null!;
        }

        public void StartState()
        {
            Console.WriteLine("Der erste Raum. Vor dir liegt ein Handschuh.");
        }

        public void EndState()
        {
            Console.WriteLine();
        }
    }
}
