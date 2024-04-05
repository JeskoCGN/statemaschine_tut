namespace OCE020424
{

    enum DrinkType
    {
        NONE,
        TEA,
        COFFEE,
        SOFTDRINK,
        WATER,
        BEER,
        SUPERBEER,
        MAX,

    }



    internal class Drink
    {
        public DrinkType m_type = DrinkType.NONE;
        public uint m_price = 0;
        public uint m_volume = 0;


        // Konstruktor für einen Drink 
        public Drink(uint _price, uint _volume, DrinkType _type) // Parameterzuweisung für Konstruktor
        {
            m_price = _price; // Preis Drink
            m_volume = _volume; // Füllvolumenm 
            m_type = _type; // Drinktyp



        }

        public uint DrinkBeverage()
        {
            Console.WriteLine("Du hast " + m_type + "getrunken. LECKAAAA");
            return m_volume;


        }


    }
}
