
namespace BMI_Rechner
{
    internal class Program
    {
        static double weightInput; // Gewicht Eingabe
        static double heightInput; // Größe Eingabe
        static double ageInput; // NEW
        static string sexInput; // NEW
        static double bmi;


        static void Main(string[] args)
        {
            Console.WriteLine("Hallo, bitte geben Sie ihr Gewicht in kg ein!");
            weightInput = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Danke! Bitte geben Sie ihre Größe ein!");
            heightInput = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Danke! Bitte geben Sie ihre Alter ein!"); // NEW
            ageInput = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Danke! Bitte geben Sie ihre Geschlecht ein! Bitte M für männlich und W für weiblich eingeben."); // NEW
            sexInput = Console.ReadLine();

            bmi = CalculationBMI(weightInput, heightInput); // NEW

            if (sexInput == "M")
            {
                switch (bmi)
                {
                    case double d when bmi > 0 && bmi < 18.5f:
                        {
                            Console.WriteLine("Untergewicht");
                            Console.WriteLine("Dein BMI: " + d);
                            break;
                        }
                    case double d when bmi >= 18.5 && bmi <= 24.9:
                        {
                            Console.WriteLine("Normalgewicht");
                            Console.WriteLine("Dein BMI: " + d);
                            break;
                        }
                    case double d when bmi >= 25 && bmi <= 29.9:
                        {
                            Console.WriteLine("Übergewicht");
                            Console.WriteLine("Dein BMI: " + d);
                            break;
                        }
                    case double d when bmi >= 30 && bmi <= 34.9:
                        {
                            Console.WriteLine("Starkes Übergewicht / Adipositas Grad 1");
                            Console.WriteLine("Dein BMI: " + d);
                            break;
                        }
                    case double d when bmi >= 35 && bmi <= 39.9:
                        {
                            Console.WriteLine("Adipositas Grad 2");
                            Console.WriteLine("Dein BMI: " + d);
                            break;
                        }
                    default:
                        Console.WriteLine("Through the roof!!");
                        break;
                }
            }

            else if(sexInput == "W") 
            {
                switch (bmi)
                {
                    case double d when bmi > 0 && bmi < 18.5f:
                        {
                            Console.WriteLine("Untergewicht");
                            Console.WriteLine("Dein BMI: " + d);
                            break;
                        }
                    case double d when bmi >= 18.5 && bmi <= 24.9:
                        {
                            Console.WriteLine("Normalgewicht");
                            Console.WriteLine("Dein BMI: " + d);
                            break;
                        }
                    case double d when bmi >= 25 && bmi <= 29.9:
                        {
                            Console.WriteLine("Übergewicht");
                            Console.WriteLine("Dein BMI: " + d);
                            break;
                        }
                    case double d when bmi >= 30 && bmi <= 34.9:
                        {
                            Console.WriteLine("Starkes Übergewicht / Adipositas Grad 1");
                            Console.WriteLine("Dein BMI: " + d);
                            break;
                        }
                    case double d when bmi >= 35 && bmi <= 39.9:
                        {
                            Console.WriteLine("Adipositas Grad 2");
                            Console.WriteLine("Dein BMI: " + d);
                            break;
                        }
                    default:
                        Console.WriteLine("Through the roof!!");
                        break;

                }
            }
            
            
            
            static double CalculationBMI(double weightInput, double heightInput)
            {
                return weightInput / (heightInput * heightInput);
            }
        }

















        //switch (sexInput)
        //{
        //    case 'M':
        //        {
        //            if (bmi < 18.5)
        //            {
        //                Console.WriteLine("Untergewicht");
        //            }
        //            else if (bmi >= 18.5 && bmi <= 24.9)
        //            {
        //                Console.WriteLine("Normalgewicht");
        //            }
        //            else if (bmi >= 25 && bmi <= 29.9)
        //            {
        //                Console.WriteLine("Übergewicht");
        //            }
        //            else if (bmi >= 30 && bmi <= 34.9)
        //            {
        //                Console.WriteLine("Starkes Übergewicht / Adipositas Grad 1");
        //            }
        //            else if (bmi >= 35 && bmi <= 39.9)
        //            {
        //                Console.WriteLine("Adipositas Grad 2");
        //            }
        //            else
        //            {
        //                Console.WriteLine("Adipositas Grad 3");
        //            }
        //            break;

        //        }
        //    case 'F':
        //        {
        //            if (bmi < 18.5)
        //            {
        //                Console.WriteLine("Untergewicht");
        //            }
        //            else if (bmi >= 18.5 && bmi <= 24.9)
        //            {
        //                Console.WriteLine("Normalgewicht");
        //            }
        //            else if (bmi >= 25 && bmi <= 29.9)
        //            {
        //                Console.WriteLine("Übergewicht");
        //            }
        //            else if (bmi >= 30 && bmi <= 34.9)
        //            {
        //                Console.WriteLine("Starkes Übergewicht / Adipositas Grad 1");
        //            }
        //            else if (bmi >= 35 && bmi <= 39.9)
        //            {
        //                Console.WriteLine("Adipositas Grad 2");
        //            }
        //            else
        //            {
        //                Console.WriteLine("Adipositas Grad 3");
        //            }
        //            break;
        //        }
        //}

    }

    /*private static double calculationBMI(double weightInput, double heightInput)
    {
        throw new NotImplementedException();
    }

    if (bmi < 18.5)
    {
        Console.WriteLine("Untergewicht");
    }
    else if (bmi >= 18.5 && bmi <= 24.9)
    {
        Console.WriteLine("Normalgewicht");
    }
    else if (bmi >= 25 && bmi <= 29.9)
    {
        Console.WriteLine("Übergewicht");
    }
    else if (bmi >= 30 && bmi <= 34.9)
    {
        Console.WriteLine("Starkes Übergewicht / Adipositas Grad 1");
    }
    else if (bmi >= 35 && bmi <= 39.9)
    {
        Console.WriteLine("Adipositas Grad 2");
    }
    else
    {
        Console.WriteLine("Adipositas Grad 3");
    }

    Console.ReadLine(); */

        



}




