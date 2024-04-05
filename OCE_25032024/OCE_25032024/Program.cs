namespace OCE_25032024
{
    internal class Program
    {
        /// <summary>
        /// Ruft sich selbst immer wieder auf
        /// </summary>
        /// <param name="_param">Die Zahl, mit der die Methode immer wieder aufgerufen wird</param>
        static void Recursive(int _param)
        {
           _param = _param + 1;
            Console.WriteLine(_param);
            Recursive(_param);
        }

        static void Main(string[] args)
        {
            //int x = 10;
            //int y = 20;

            //int z = x + y;

            //{
            //    int tmp = 200;
            //    tmp = tmp + x;
            //    Console.Write(tmp);
            //}

            //Recursive(x);

            string input = Console.ReadLine()!;


            Console.WriteLine(input);

        }
    }
}
