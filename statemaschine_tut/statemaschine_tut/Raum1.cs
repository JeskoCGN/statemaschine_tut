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
            {
                if (Console.ReadLine().ToLower() == "n") return new Raum3();
                else if (Console.ReadLine().ToLower() == "w") return new Raum2();

                return null!;
            }
        }

        public void StartState()
        {

        }

        public void EndState()
        {

        }
    }
}
