using System;
namespace mis321_pa2_bhhicks221
{
    public class Calculate
    {
        public static bool Determine(string type1, string type2)
        {
            if ((type1.ToUpper() == "JACK SPARROW" && type2.ToUpper() == "WILL TURNER") || (type1.ToUpper() == "WILL TURNER" && type2.ToUpper() == "DAVY JONES") || (type1.ToUpper() == "DAVY JONES" && type2.ToUpper() == "JACK SPARROW"))
            {
                return true;
            }
            else
            {
                return false;

            }
        }
        public static int Bonus(int attack, int defense, int health)
        {
            double damage;
            damage = (double)(attack - defense) * (1.2);
            int dam = (int)Math.Round(damage);
            health = health - dam;
            return health;
        }
        public static int NoBonus(int attack, int defense, int health)
        {
            int damage;
            damage = (attack - defense);
            health = health - damage;
            return health;
        }
    }
}