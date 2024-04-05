namespace Übung_WeaponGenerator
{ // Name in Lesson umbenennen - Umlaute = Scheiße 

    internal class Generator
    {
        //private m_generate = null;
        private Weapons[] m_generatedWeapons;

        public Generator(int _numberOfWeapons)
        {
            // Initialisierung Weapon Array
            m_generatedWeapons = new Weapons[_numberOfWeapons];

            Random rnd = new Random();

            for (int i = 0; i < m_generatedWeapons.Length - 1; i++)
            {
                E_WeaponType rndWeaponType = (E_WeaponType)rnd.Next(1, (int)E_WeaponType.MAX);
                E_WeaponRarity rndWeaponRarity = (E_WeaponRarity)rnd.Next(1, (int)E_WeaponRarity.MAX);
                E_WeaponOrigin rndWeaponOrigin = (E_WeaponOrigin)rnd.Next(1, (int)E_WeaponOrigin.MAX);
                E_WeaponAdjective rndWeaponAdjective = (E_WeaponAdjective)rnd.Next(1, (int)E_WeaponAdjective.MAX);

                m_generatedWeapons[i] = new Weapons(rndWeaponType, rndWeaponRarity, rndWeaponOrigin, rndWeaponAdjective);
            }
        }

        public Weapons GenWeaponOutput(int _chosenWeapon)
        {
            Weapons weapon = m_generatedWeapons[_chosenWeapon];
            Console.WriteLine("Generiete Waffe ist: " + weapon.WeaponRarity.ToString() + " " + weapon.WeaponType.ToString() + " der " + weapon.WeaponAdjective.ToString() + " aus " + weapon.WeaponOrigin.ToString());

            return weapon;
            //return null;
        }

    }











}
