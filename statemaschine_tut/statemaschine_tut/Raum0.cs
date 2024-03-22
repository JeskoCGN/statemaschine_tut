using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statemaschine_tut
{
    internal class Raum0 : IState
    {

        public IState Check()
        {
            {
                if (Console.ReadLine().ToLower() == "n")
                    return new Raum1();

                return null!;
            }
        }

        public void StartState()
        {
            Console.WriteLine("Folgendes Rätsel hilft dir beim finden der richtigen Items:");
            Console.WriteLine("Mir fehlt Zeit.. sehen kann ich in dieser Dunkelheit auch nichts.. und ich vermisse Sport.");
            Console.WriteLine();
            Console.WriteLine("Viel Glück und viel Segen, auf all deinen Wegen.. stirb nicht. Tschüss.");
        }

        public void EndState()
        {
            Console.WriteLine();
        }
    }
}
