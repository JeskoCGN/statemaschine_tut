using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statemaschine_tut
{
    internal class Raum8 : IState
    {
        public IState Check()
        {
            if (Console.ReadLine()?.ToLower() == "o") return new Raum7();

            return null!;
        }

        public void StartState()
        {
            Console.WriteLine("Nächster Raum... und nur eine Taschhenlampe. Der Lichkegel erhellt die aufgemalte 8 an der Wand.");
        }

        public void EndState()
        {
            Console.WriteLine();
        }
    }
}
