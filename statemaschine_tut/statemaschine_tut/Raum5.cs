using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statemaschine_tut
{
    internal class Raum5 : IState
    {
        public IState Check()
        {
            if (Console.ReadLine()?.ToLower() == "n") return new Raum7();
            else if (Console.ReadLine()?.ToLower() == "w") return new Raum3();

            return null!;
        }

        public void StartState()
        {
            Console.WriteLine("Endlich Lich in Raum 5. Vorher konntest du nur so weit schauen wie deine Nase reicht.");
        }

        public void EndState()
        {
            Console.WriteLine();
        }
    }
}
