using System;

namespace mis321_pa2_bhhicks221
{
    public class Character
    {
        public string Name{get; set;}
        public int MaxPower {get; set;}
        public int Health {get; set;}
        public int AttackStrength {get; set;}
        public int DefensivePower{get; set;}
        public IAttack attackBehavior {get; set;}
        public IDefend defendBehavior {get; set;}

        public Character()
        {
            MaxPower = SetMaxPower();
            Health = 100;
            AttackStrength = SetAttackStrength();
            DefensivePower = SetDefensivePower();
        }
        public static int SetMaxPower()
        {
            Random rand = new Random();
            int num = rand.Next(1, 100);
            return num;
        }
        public int SetAttackStrength()
        {
            Random rand = new Random();
            int num = rand.Next(1, MaxPower);
            return num;
        }
        public int SetDefensivePower()
        {
            Random rand = new Random();
            int num = rand.Next(1, MaxPower);
            return num;
        }
    }
}