namespace OCE020424
{
    internal class Automat
    {

        private Drink[] m_inventory;

        public Automat()
        {

            // Initialisieren des Inventar Arrays
            m_inventory = new Drink[(int)DrinkType.MAX - 1];

            Random rnd = new Random();

            // Befüllen des Inventars
            for (int i = 1; i < m_inventory.Length; i++)
            {
                uint randomPrice = (uint)rnd.Next(1, 11);
                uint randomVolume = (uint)rnd.Next(100, 1001);

                m_inventory[i] = new Drink(randomPrice, randomVolume, (DrinkType)i + 1);



            }
        }

        public Drink SelectDrink()
        {
            Console.WriteLine("Bitte wählen Sie ein Getränk:");

            int i = 1;
            foreach (Drink drink in m_inventory)
            {
                Console.WriteLine(i + ". " + drink.m_type
                                    + ", Volumen:" + drink.m_volume
                                    + ", Preis:" + drink.m_price);

                i++; // Breakpoint zur Kontrolle der Größe i (Programmablauf) 

            }

            int selectedDrink;
            bool correctInput = false;

            do
            {
                Console.WriteLine("Eingabe: ");
                correctInput = int.TryParse(Console.ReadLine(), out selectedDrink);
            } while (!correctInput);

            PayMoney(selectedDrink);

            return DispenseDrink(selectedDrink);

        }

        private void PayMoney(int _selectedDrink)
        {
            uint currentMoney = 0;
            uint requiredMoney = m_inventory[_selectedDrink - 1].m_price;

            int input = 0;

            do
            {
                Console.WriteLine("Kosten für " + m_inventory[_selectedDrink - 1].m_type + ": "
                                    + requiredMoney + " " + "Bisher gezahlt: " + currentMoney);

                Console.WriteLine("Bitte Geld eingeben: ");
                int.TryParse(Console.ReadLine(), out input);

                currentMoney += (uint)input;

            } while (currentMoney < requiredMoney);

            if (currentMoney > requiredMoney)
            {
                Console.WriteLine("Rückgeld: " + (currentMoney - requiredMoney));

            }

        }

        private Drink DispenseDrink(int _selectedDrink)
        {
            Drink selected = m_inventory[_selectedDrink - 1];

            Console.WriteLine("Viel Spaß mit ihrem " + selected.m_type);
            return null;
        }
    }
}
