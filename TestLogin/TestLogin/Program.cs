using System;

namespace TestLogin
{
    internal class Program
    {
        private const string name = "Jesko";

        private string inputName;

        static void Main()
        {

            LoginWindow();
        }

        private void LoginWindow()
        {
            inputName = Console.ReadLine();

            //Console.ReadLine();
            if (inputName == name)
            {
                Console.WriteLine("Willkommen");
            }
            else
            {
                Console.WriteLine("Fehler");

            }
        }
    }
}
