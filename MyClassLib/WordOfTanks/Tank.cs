namespace MyClassLib.WordOfTanks
{
    public class Tank
    {
        private string name;
        private int allowanceOfAmmunition;
        private int armor;
        private int maneuverability;


        public Tank() { }

        public Tank(string name, int allowanceOfAmmunition, int armor, int maneuverability)
        {
            this.name = name;
            this.allowanceOfAmmunition = allowanceOfAmmunition;
            this.armor = armor;
            this.maneuverability = maneuverability;
        }

        
        public string GetAllowanceOfAmmunition()
        {
            return allowanceOfAmmunition.ToString(); 
        }

        public string GetArmor()
        {
            return armor.ToString();
        }

        public string GetManeuverability()
        {
            return maneuverability.ToString();
        }

        public static string operator *(Tank T34, Tank pantera)
        {
            if (T34.allowanceOfAmmunition > pantera.allowanceOfAmmunition && T34.armor > pantera.armor ||
                T34.allowanceOfAmmunition > pantera.allowanceOfAmmunition && T34.maneuverability > pantera.maneuverability ||
                T34.armor > pantera.armor && T34.maneuverability > pantera.maneuverability)
            {
                return T34.name;
            }
            else if (T34.allowanceOfAmmunition < pantera.allowanceOfAmmunition && T34.armor < pantera.armor ||
                     T34.allowanceOfAmmunition < pantera.allowanceOfAmmunition && T34.maneuverability < pantera.maneuverability ||
                     T34.armor < pantera.armor && T34.maneuverability < pantera.maneuverability)
            {
                return pantera.name;
            }
            else
            {
                return "Ничья";
            }
        }
    }
}
