using System;
namespace mis321_pa2_bhhicks221
{
    public class Gameplay
    { 
        // EXTRA: coin flip to determine who will go first
        public static void CoinFlip(JackSparrow playerOne, DavyJones playerTwo)
        {
            Console.WriteLine("\nBut first, we will flip a coin to determine who will have first attack:");
            int num = Random();
            if ( num == 1)
            {
                Console.WriteLine($"The coin flipped to heads. {playerOne.Title} will attack first!\n");
                Game(playerOne, playerTwo);
            }
            else if (num == 2)
            {
                Console.WriteLine($"The coin flipped to tails. {playerTwo.Title} will attack first!\n");
                Game2(playerTwo, playerOne);
            }
        }
        public static int Random()
        {
            Random ran = new Random();
            int num = ran.Next(0,3);
            Console.WriteLine(num);
            return num;
        }
        public static void Game(JackSparrow playerOne, DavyJones playerTwo)
        {
            Console.WriteLine($"{playerOne.Title}, type 'ready' when you are ready to attack.");
            string ready = Console.ReadLine().ToUpper();
            while (ready != "READY")
            {
                Console.WriteLine($"{playerOne.Title}, type 'ready' when you are ready to attack.");
                ready = Console.ReadLine().ToUpper();
            }

            playerOne.attackBehavior.Attack();
            bool bonus = Calculate.Determine(playerOne.Title, playerTwo.Title);
            if (bonus == true)
            {
                playerTwo.Health = Calculate.Bonus(playerOne.AttackStrength, playerTwo.DefensivePower, playerTwo.Health);
            }
            else 
            {
                playerTwo.Health = Calculate.NoBonus(playerOne.AttackStrength, playerTwo.DefensivePower, playerTwo.Health);
            }

            while (playerOne.Health > 0 && playerTwo.Health > 0)
            {

            }
        }
        public static void Game2(DavyJones playerOne, JackSparrow playerTwo)
        {
            Console.WriteLine($"");
        }
    }
}