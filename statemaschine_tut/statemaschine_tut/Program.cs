namespace statemaschine_tut
{
    internal class Program
    {
        public static bool taschenlampe = false;
        public static bool uhr = false;
        public static bool badmintonSchläger = false;
        public static bool falseItem = false;

        static void Main()
        {
            StateMachine stateMachine = new StateMachine();
            while (true) stateMachine.Update();
        }
    }
}
