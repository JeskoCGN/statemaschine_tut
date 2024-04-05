using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Übung_WeaponGenerator
{

    public enum E_WeaponType
    {
        NONE,
        LANGSCHWERT,
        KURZSCHWERT,
        MORGENSTERN,
        KAMPFAXT,
        WURFAXT,
        LANZE,
        MAX,
    }

    public enum E_WeaponRarity
    {
        NONE,
        Common,
        Uncommon,
        Rare,
        Legendary,
        Mythical,
        MAX,
    }

    public enum E_WeaponOrigin
    {
        NONE,
        Rethramis,
        Shushire,
        Rohendel,
        Yorn,
        Feiton,
        Luterra,
        MAX,
    }

    public enum E_WeaponAdjective
    {
        NONE,
        Dämonenbestie,
        Habsuchtslegion,
        Verwüsterlegion,
        Phantomlegion,
        Pestlegion,
        MAX,
    }

    internal class Weapons
    {

        // Initiales Setzen der Default Werte
        private static int m_defaultPrice = 20;
        private static int m_defaultDurability = 100;
        private static int m_defaultAttack = 50;

        // Initiales Nullen der Variablen
        private E_WeaponType m_weaponType = E_WeaponType.NONE;
        private E_WeaponRarity m_weaponRarity = E_WeaponRarity.NONE;
        private E_WeaponOrigin m_weaponOrigin = E_WeaponOrigin.NONE;
        private E_WeaponAdjective m_weaponAdjective = E_WeaponAdjective.NONE;

        // Initiale Erstellung der Parameter
        private int m_weaponDefaultPrice;
        private int m_weaponDefaultDurability;
        private int m_weaponDefaultAttack;

        // Properties der Weapons Klasse
        public E_WeaponRarity WeaponRarity { get => m_weaponRarity; }
        public E_WeaponType WeaponType { get => m_weaponType; }
        public E_WeaponOrigin WeaponOrigin { get => m_weaponOrigin; }
        public E_WeaponAdjective WeaponAdjective { get => m_weaponAdjective; }
        public int DefaultPrice { get => m_defaultPrice; }
        public int DefaultDurability { get => m_defaultDurability; }
        public int DefaultAttack { get => m_defaultAttack; }

        // Konstruktor für Waffe
        public Weapons(E_WeaponType _weaponType, E_WeaponRarity _weaponRarity, E_WeaponOrigin _weaponOrigin, E_WeaponAdjective _weaponAdjective, int _weaponDefaultPrice = 0, int _weaponDefaultDurability = 0, int _weaponDefaultAttack = 0)
        {
            m_weaponType = _weaponType;
            m_weaponRarity = _weaponRarity;
            m_weaponOrigin = _weaponOrigin;
            m_weaponAdjective = _weaponAdjective;

            if (_weaponDefaultPrice == 0)
                m_weaponDefaultPrice = m_defaultPrice;
            m_weaponDefaultPrice = _weaponDefaultPrice;

            // Einzeilige Wenn Abfrage / Fragezeichen fungiert als DANN / Doppelpunkt fungiert als SONST
            //m_weaponDefaultPrice = _weaponDefaultPrice == 0 ? m_defaultPrice : _weaponDefaultPrice;

            if (_weaponDefaultDurability == 0)
                m_weaponDefaultDurability = m_defaultDurability;
            m_weaponDefaultDurability = _weaponDefaultDurability;

            if (_weaponDefaultAttack == 0)
                m_weaponDefaultAttack = m_defaultAttack;
            m_weaponDefaultAttack = _weaponDefaultAttack;
        }
    }





}
