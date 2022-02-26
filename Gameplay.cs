using System;
namespace mis321_pa2_bhhicks221
{
    public class Gameplay
    { 
        // EXTRA: coin flip to determine who will go first
        public static void CoinFlip(string name1, string name2)
        {
            Console.WriteLine("But first, we will flip a coin to determine who will have first attack");
            int num = Random();
            if ( num == 1)
            {
                Console.WriteLine($"The coin flipped to heads. {name1} will go first!");
            }
            else if (num == 2)
            {
                Console.WriteLine($"The coin flipped to tails. {name2} will go first!");
            }
        }
        public static int Random()
        {
            Random ran = new Random();
            int num = ran.Next(0,2);
            Console.WriteLine(num);
            return num;
        }
    }
}