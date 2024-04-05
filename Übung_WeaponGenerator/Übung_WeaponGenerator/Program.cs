namespace Übung_WeaponGenerator
{
    internal class Program
    {

        //static void Main(string[] args)
        static void Main()
        {
            int weaponsToGenerate = 5;
            int chosenWeapon = 3;

            Generator weapons = new Generator(weaponsToGenerate);

            Weapons weapon = weapons.GenWeaponOutput(chosenWeapon);
            
            //Console.WriteLine("Hello, World!");
            //return GenWeaponOutput;
        }
    }
}
