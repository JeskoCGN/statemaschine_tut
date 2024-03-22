namespace statemaschine_tut
{
    internal class Program
    {
        public static bool taschenlampe;
        public static bool uhr;
        public static bool badmintonSchläger;
        public static bool falseItem;
        static void Main(string[] args)
        {
            taschenlampe = false;
            uhr = false;
            badmintonSchläger = false;
            falseItem = false;
            StateMachine stateMachine = new StateMachine();
            while (true)
            {
                stateMachine.Update();
            }
        }
    }
}
