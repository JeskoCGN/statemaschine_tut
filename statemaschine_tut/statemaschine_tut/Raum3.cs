using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statemaschine_tut
{
    internal class Raum3 : IState
    {
        public IState Check()
        {
            if (Console.ReadLine()?.ToLower() == "o") return new Raum5();
            if (Console.ReadLine()?.ToLower() == "s") return new Raum1();
            if (Console.ReadLine()?.ToLower() == "w") return new Raum4();

            return null!;
        }

        public void StartState()
        {
            Console.WriteLine("In Raum 3 riechts streng.. eine Käsereibe findest du in der Ecke liegen.");
        }

        public void EndState()
        {
            Console.WriteLine();
        }
    }
}
