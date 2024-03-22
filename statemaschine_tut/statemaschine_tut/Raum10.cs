using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statemaschine_tut
{
    internal class Raum10 : IState
    {
        public IState Check()
        {
            if (Console.ReadLine()?.ToLower() == "s") return new Raum4();

            return null!;
        }

        public void StartState()
        {
            Console.WriteLine("Raum 10... eine große Türe darüber ein grün leuchtendes \"EXIT\" Schild... hast du es geschafft.");
        }

        public void EndState()
        {
            Console.WriteLine();
        }
    }
}
