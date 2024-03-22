using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statemaschine_tut
{
    internal interface IState
    {
        public IState Check();
        public void StartState();
        public void EndState();
    }
}
