using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statemaschine_tut
{
    internal class StateMachine
    {
        private IState curState = null;

        public StateMachine()
        {
            Start();
        }
        private void Start()
        {
            curState = new Raum0();
            curState.StartState();
        }

        public void Update()
        {
            IState nextState = curState.Check();
            if (nextState != null)
            {
                curState.EndState();
                curState = nextState;
                curState.StartState();
                if(Program.falseItem)
                {
                    Console.WriteLine("Du bist gestorben");
                    Environment.Exit(0);
                }
            }
        }
    }
}
