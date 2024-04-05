using System;

using System.Security.Cryptography.X509Certificates;

namespace OCE020424
{

    

    internal class Program
    {


        public static void Main()
        //public void Main(string[] args)
        {
            Automat myAutomat = new Automat();
            Drink myDrink = myAutomat.SelectDrink();

            myDrink.DrinkBeverage();


        }
        
        

        
    }
}
