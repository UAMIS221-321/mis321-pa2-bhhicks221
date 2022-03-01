using System;
namespace mis321_pa2_bhhicks221
{
    public class Calculate
    {
        public static bool Determine(string type1, string type2)
        {
            if ((type1.ToUpper() == "JACK SPARROW" && type2.ToUpper() == "WILL TURNER") || (type1.ToUpper() == "WILL TURNER" && type2.ToUpper() == "DAVY JONES") || (type1.ToUpper() == "DAVY JONES" && type2.ToUpper() == "JACK SPARROW"))
            {
                Console.WriteLine($"{type1} beats {type2} and receives an attack bonus!");
                return true;
            }
            else
            {
                return false;
            }
        }
        public static int Bonus(int attack, int defense, int health, string type2)
        {
            double damage;
            damage = (double)(attack - defense) * (1.2);
            int dam = (int)Math.Round(damage);
            if (dam < 0)
            {
                double att = (double)attack;
                double def = (double)defense;
                double damge = (double)(att / def) * att;
                int uh = (int)Math.Round(damge);
                health = (health - uh);
                Console.WriteLine($"{type2}'s defense bested the attacker! Only a fraction of damage was dealt.");
                Console.WriteLine($"{type2}'s health is now {health}.\n");
                return health;
            }
            else
            {
                health = health - dam;
                Console.WriteLine($"{type2}'s health is now {health}.\n");
                return health;
            }
        }
        public static int NoBonus(int attack, int defense, int health, string type2)
        {
            int damage;
            damage = (attack - defense);
            if (damage < 0)
            {
                double att = (double)attack;
                double def = (double)defense;
                double damge = (double)(att / def) * att;
                int uh = (int)Math.Round(damge);
                health = (health - uh);
                Console.WriteLine($"{type2}'s defense bested the attacker! Only a fraction of damage was dealt.");
                Console.WriteLine($"{type2}'s health is now {health}.\n");
                return health;
            }
            else
            {
                health = health - damage;
                Console.WriteLine($"{type2}'s health is now {health}.\n");
                return health;
            }
        }
    }
}