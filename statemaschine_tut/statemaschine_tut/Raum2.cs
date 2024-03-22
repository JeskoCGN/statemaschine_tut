namespace statemaschine_tut
{
    internal class Raum2 : IState
    {
        public IState Check()
        {
            if (Console.ReadLine()?.ToLower() == "o") return new Raum1();

            return null!;
        }

        public void StartState()
        {
            Console.WriteLine("Du bist in Raum 2 eingetreten. Du stolperst über einen Badminton-Schläger.");
        }

        public void EndState()
        {
            Console.WriteLine();
        }
    }
}
