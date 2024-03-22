using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statemaschine_tut
{
    internal class Raum6 : IState
    {
        public IState Check()
        {
            if (Console.ReadLine()?.ToLower() == "w") return new Raum7();

            return null!;
        }

        public void StartState()
        {
            Console.WriteLine("In Raum 6 findest du Würfel... ob dich ein Pasch wohl hier raus bring?");
        }

        public void EndState()
        {
            Console.WriteLine();
        }
    }
}
