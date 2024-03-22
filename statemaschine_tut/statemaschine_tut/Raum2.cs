namespace statemaschine_tut
{
    internal class Raum2 : IState
    {
        private string item = "Badminton-Schläger";
        private bool validInput = false;
        public IState Check()
        {
            string readLineLower = Console.ReadLine()!.ToLower();
            if (readLineLower == "o") return new Raum1();

            return null!;
        }

        public void StartState()
        {
            Console.WriteLine("Du bist in Raum 2 eingetreten. Du stolperst über einen Badminton-Schläger.");
            Console.WriteLine("Willst du " + item + " einsammeln?");
            Console.WriteLine("[J]a/ [N]ein");
            while (validInput == false)
            {
                ConsoleKey input = Console.ReadKey(true).Key;
                if (input == ConsoleKey.J)
                {
                    Console.WriteLine("Item wurde aufgesammelt");
                    Program.badmintonSchläger = true;
                    validInput = true;
                }
                else if (input == ConsoleKey.N)
                {
                    Console.WriteLine("Item wurde nicht aufgesammelt");
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Falscher Input");
                    validInput = false;
                }
            }
            Console.WriteLine("Du kannst nach [O]sten.");
        }

        public void EndState()
        {
            Console.WriteLine();
        }
    }
}
