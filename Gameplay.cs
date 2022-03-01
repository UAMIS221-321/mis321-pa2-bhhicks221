using System;
namespace mis321_pa2_bhhicks221
{
    public class Gameplay
    { 
        // EXTRA: coin flip to determine who will go first
        public static void CoinFlip(JackSparrow playerOne, DavyJones playerTwo)
        {
            Console.WriteLine("The two players will dual it out until one has no health left!");
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
        public static void CoinFlip1(JackSparrow playerOne, JackSparrow playerTwo)
        {
            Console.WriteLine("The two players will dual it out until one has no health left!");
            Console.WriteLine("\nBut first, we will flip a coin to determine who will have first attack:");
            int num = Random();
            if ( num == 1)
            {
                Console.WriteLine($"The coin flipped to heads. {playerOne.Title} ({playerOne.Name}) will attack first!\n");
                Game3(playerOne, playerTwo);
            }
            else if (num == 2)
            {
                Console.WriteLine($"The coin flipped to tails. {playerTwo.Title} ({playerTwo.Name}) will attack first!\n");
                Game3(playerTwo, playerOne);
            }
        }
        public static void CoinFlip2(JackSparrow playerOne, WillTurner playerTwo)
        {
            Console.WriteLine("The two players will dual it out until one has no health left!");
            Console.WriteLine("\nBut first, we will flip a coin to determine who will have first attack:");
            int num = Random();
            if ( num == 1)
            {
                Console.WriteLine($"The coin flipped to heads. {playerOne.Title} will attack first!\n");
                Game4(playerOne, playerTwo);
            }
            else if (num == 2)
            {
                Console.WriteLine($"The coin flipped to tails. {playerTwo.Title} will attack first!\n");
                Game6(playerTwo, playerOne);
            }
        }

        public static void CoinFlip3(DavyJones playerOne, DavyJones playerTwo)
        {
            Console.WriteLine("The two players will dual it out until one has no health left!");
            Console.WriteLine("\nBut first, we will flip a coin to determine who will have first attack:");
            int num = Random();
            if ( num == 1)
            {
                Console.WriteLine($"The coin flipped to heads. {playerOne.Title} ({playerOne.Name}) will attack first!\n");
                Game5(playerOne, playerTwo);
            }
            else if (num == 2)
            {
                Console.WriteLine($"The coin flipped to tails. {playerTwo.Title} ({playerTwo.Name}) will attack first!\n");
                Game5(playerTwo, playerOne);
            }
        }

        public static void CoinFlip4(DavyJones playerOne, WillTurner playerTwo)
        {
            Console.WriteLine("The two players will dual it out until one has no health left!");
            Console.WriteLine("\nBut first, we will flip a coin to determine who will have first attack:");
            int num = Random();
            if ( num == 1)
            {
                Console.WriteLine($"The coin flipped to heads. {playerOne.Title} will attack first!\n");
                Game7(playerOne, playerTwo);
            }
            else if (num == 2)
            {
                Console.WriteLine($"The coin flipped to tails. {playerTwo.Title} will attack first!\n");
                Game8(playerTwo, playerOne);
            }
        }

        public static void CoinFlip5(WillTurner playerOne, WillTurner playerTwo)
        {
            Console.WriteLine("The two players will dual it out until one has no health left!");
            Console.WriteLine("\nBut first, we will flip a coin to determine who will have first attack:");
            int num = Random();
            if ( num == 1)
            {
                Console.WriteLine($"The coin flipped to heads. {playerOne.Title} ({playerOne.Name}) will attack first!\n");
                Game9(playerOne, playerTwo);
            }
            else if (num == 2)
            {
                Console.WriteLine($"The coin flipped to tails. {playerTwo.Title} ({playerTwo.Name}) will attack first!\n");
                Game9(playerTwo, playerOne);
            }
        }
        public static int Random()
        {
            Random ran = new Random();
            int num = ran.Next(1,3);
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
                playerTwo.Health = Calculate.Bonus(playerOne.AttackStrength, playerTwo.DefensivePower, playerTwo.Health, playerTwo.Title);
            }
            else 
            {
                playerTwo.Health = Calculate.NoBonus(playerOne.AttackStrength, playerTwo.DefensivePower, playerTwo.Health, playerTwo.Title);
            }

            while (playerOne.Health > 0 && playerTwo.Health > 0)
            {
                playerTwo.attackBehavior.Attack();
                bonus = Calculate.Determine(playerTwo.Title, playerOne.Title);
                if (bonus == true)
                {
                    playerOne.Health = Calculate.Bonus(playerTwo.AttackStrength, playerOne.DefensivePower, playerOne.Health, playerOne.Title);
                }
                else 
                {
                    playerOne.Health = Calculate.NoBonus(playerTwo.AttackStrength, playerOne.DefensivePower, playerOne.Health, playerOne.Title);
                }

                playerOne.attackBehavior.Attack();
                bonus = Calculate.Determine(playerOne.Title, playerTwo.Title);
                if (bonus == true)
                {
                    playerTwo.Health = Calculate.Bonus(playerOne.AttackStrength, playerTwo.DefensivePower, playerTwo.Health, playerTwo.Title);
                }
                else 
                {
                    playerTwo.Health = Calculate.NoBonus(playerOne.AttackStrength, playerTwo.DefensivePower, playerTwo.Health, playerTwo.Title);
                }
            }

            if (playerTwo.Health < 0)
            {
                Console.WriteLine($"\n{playerTwo.Title}'s health reached below zero. Congratulations, {playerOne.Name}, you have won the Battle of Calypso!\n");
            }
            else 
            {
                Console.WriteLine($"\n{playerOne.Title}'s health reached below zero. Congratulations, {playerTwo.Name}, you have won the Battle of Calypso!\n");
            }
        }
        public static void Game2(DavyJones playerOne, JackSparrow playerTwo)
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
                playerTwo.Health = Calculate.Bonus(playerOne.AttackStrength, playerTwo.DefensivePower, playerTwo.Health, playerTwo.Title);
            }
            else 
            {
                playerTwo.Health = Calculate.NoBonus(playerOne.AttackStrength, playerTwo.DefensivePower, playerTwo.Health, playerTwo.Title);
            }

            while (playerOne.Health > 0 && playerTwo.Health > 0)
            {
                playerTwo.attackBehavior.Attack();
                bonus = Calculate.Determine(playerTwo.Title, playerOne.Title);
                if (bonus == true)
                {
                    playerOne.Health = Calculate.Bonus(playerTwo.AttackStrength, playerOne.DefensivePower, playerOne.Health, playerOne.Title);
                }
                else 
                {
                    playerOne.Health = Calculate.NoBonus(playerTwo.AttackStrength, playerOne.DefensivePower, playerOne.Health, playerOne.Title);
                }

                playerOne.attackBehavior.Attack();
                bonus = Calculate.Determine(playerOne.Title, playerTwo.Title);
                if (bonus == true)
                {
                    playerTwo.Health = Calculate.Bonus(playerOne.AttackStrength, playerTwo.DefensivePower, playerTwo.Health, playerTwo.Title);
                }
                else 
                {
                    playerTwo.Health = Calculate.NoBonus(playerOne.AttackStrength, playerTwo.DefensivePower, playerTwo.Health, playerTwo.Title);
                }
            }

            if (playerTwo.Health < 0)
            {
                Console.WriteLine($"\n{playerTwo.Title}'s health reached below zero. Congratulations, {playerOne.Name}, you have won the Battle of Calypso!\n");
            }
            else 
            {
                Console.WriteLine($"\n{playerOne.Title}'s health reached below zero. Congratulations, {playerTwo.Name}, you have won the Battle of Calypso!\n");
            }
        }

        public static void Game3(JackSparrow playerOne, JackSparrow playerTwo)
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
                playerTwo.Health = Calculate.Bonus(playerOne.AttackStrength, playerTwo.DefensivePower, playerTwo.Health, playerTwo.Title);
            }
            else 
            {
                playerTwo.Health = Calculate.NoBonus(playerOne.AttackStrength, playerTwo.DefensivePower, playerTwo.Health, playerTwo.Title);
            }

            while (playerOne.Health > 0 && playerTwo.Health > 0)
            {
                playerTwo.attackBehavior.Attack();
                bonus = Calculate.Determine(playerTwo.Title, playerOne.Title);
                if (bonus == true)
                {
                    playerOne.Health = Calculate.Bonus(playerTwo.AttackStrength, playerOne.DefensivePower, playerOne.Health, playerOne.Title);
                }
                else 
                {
                    playerOne.Health = Calculate.NoBonus(playerTwo.AttackStrength, playerOne.DefensivePower, playerOne.Health, playerOne.Title);
                }

                playerOne.attackBehavior.Attack();
                bonus = Calculate.Determine(playerOne.Title, playerTwo.Title);
                if (bonus == true)
                {
                    playerTwo.Health = Calculate.Bonus(playerOne.AttackStrength, playerTwo.DefensivePower, playerTwo.Health, playerTwo.Title);
                }
                else 
                {
                    playerTwo.Health = Calculate.NoBonus(playerOne.AttackStrength, playerTwo.DefensivePower, playerTwo.Health, playerTwo.Title);
                }
            }

            if (playerTwo.Health < 0)
            {
                Console.WriteLine($"\n{playerTwo.Title}'s health reached below zero. Congratulations, {playerOne.Name}, you have won the Battle of Calypso!\n");
            }
            else 
            {
                Console.WriteLine($"\n{playerOne.Title}'s health reached below zero. Congratulations, {playerTwo.Name}, you have won the Battle of Calypso!\n");
            }
        }

        public static void Game4(JackSparrow playerOne, WillTurner playerTwo)
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
                playerTwo.Health = Calculate.Bonus(playerOne.AttackStrength, playerTwo.DefensivePower, playerTwo.Health, playerTwo.Title);
            }
            else 
            {
                playerTwo.Health = Calculate.NoBonus(playerOne.AttackStrength, playerTwo.DefensivePower, playerTwo.Health, playerTwo.Title);
            }

            while (playerOne.Health > 0 && playerTwo.Health > 0)
            {
                playerTwo.attackBehavior.Attack();
                bonus = Calculate.Determine(playerTwo.Title, playerOne.Title);
                if (bonus == true)
                {
                    playerOne.Health = Calculate.Bonus(playerTwo.AttackStrength, playerOne.DefensivePower, playerOne.Health, playerOne.Title);
                }
                else 
                {
                    playerOne.Health = Calculate.NoBonus(playerTwo.AttackStrength, playerOne.DefensivePower, playerOne.Health, playerOne.Title);
                }

                playerOne.attackBehavior.Attack();
                bonus = Calculate.Determine(playerOne.Title, playerTwo.Title);
                if (bonus == true)
                {
                    playerTwo.Health = Calculate.Bonus(playerOne.AttackStrength, playerTwo.DefensivePower, playerTwo.Health, playerTwo.Title);
                }
                else 
                {
                    playerTwo.Health = Calculate.NoBonus(playerOne.AttackStrength, playerTwo.DefensivePower, playerTwo.Health, playerTwo.Title);
                }
            }

            if (playerTwo.Health < 0)
            {
                Console.WriteLine($"\n{playerTwo.Title}'s health reached below zero. Congratulations, {playerOne.Name}, you have won the Battle of Calypso!\n");
            }
            else 
            {
                Console.WriteLine($"\n{playerOne.Title}'s health reached below zero. Congratulations, {playerTwo.Name}, you have won the Battle of Calypso!\n");
            }
        }

        public static void Game5(DavyJones playerOne, DavyJones playerTwo)
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
                playerTwo.Health = Calculate.Bonus(playerOne.AttackStrength, playerTwo.DefensivePower, playerTwo.Health, playerTwo.Title);
            }
            else 
            {
                playerTwo.Health = Calculate.NoBonus(playerOne.AttackStrength, playerTwo.DefensivePower, playerTwo.Health, playerTwo.Title);
            }

            while (playerOne.Health > 0 && playerTwo.Health > 0)
            {
                playerTwo.attackBehavior.Attack();
                bonus = Calculate.Determine(playerTwo.Title, playerOne.Title);
                if (bonus == true)
                {
                    playerOne.Health = Calculate.Bonus(playerTwo.AttackStrength, playerOne.DefensivePower, playerOne.Health, playerOne.Title);
                }
                else 
                {
                    playerOne.Health = Calculate.NoBonus(playerTwo.AttackStrength, playerOne.DefensivePower, playerOne.Health, playerOne.Title);
                }

                playerOne.attackBehavior.Attack();
                bonus = Calculate.Determine(playerOne.Title, playerTwo.Title);
                if (bonus == true)
                {
                    playerTwo.Health = Calculate.Bonus(playerOne.AttackStrength, playerTwo.DefensivePower, playerTwo.Health, playerTwo.Title);
                }
                else 
                {
                    playerTwo.Health = Calculate.NoBonus(playerOne.AttackStrength, playerTwo.DefensivePower, playerTwo.Health, playerTwo.Title);
                }
            }

            if (playerTwo.Health < 0)
            {
                Console.WriteLine($"\n{playerTwo.Title}'s health reached below zero. Congratulations, {playerOne.Name}, you have won the Battle of Calypso!\n");
            }
            else 
            {
                Console.WriteLine($"\n{playerOne.Title}'s health reached below zero. Congratulations, {playerTwo.Name}, you have won the Battle of Calypso!\n");
            }
        }

        public static void Game6(WillTurner playerOne, JackSparrow playerTwo)
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
                playerTwo.Health = Calculate.Bonus(playerOne.AttackStrength, playerTwo.DefensivePower, playerTwo.Health, playerTwo.Title);
            }
            else 
            {
                playerTwo.Health = Calculate.NoBonus(playerOne.AttackStrength, playerTwo.DefensivePower, playerTwo.Health, playerTwo.Title);
            }

            while (playerOne.Health > 0 && playerTwo.Health > 0)
            {
                playerTwo.attackBehavior.Attack();
                bonus = Calculate.Determine(playerTwo.Title, playerOne.Title);
                if (bonus == true)
                {
                    playerOne.Health = Calculate.Bonus(playerTwo.AttackStrength, playerOne.DefensivePower, playerOne.Health, playerOne.Title);
                }
                else 
                {
                    playerOne.Health = Calculate.NoBonus(playerTwo.AttackStrength, playerOne.DefensivePower, playerOne.Health, playerOne.Title);
                }

                playerOne.attackBehavior.Attack();
                bonus = Calculate.Determine(playerOne.Title, playerTwo.Title);
                if (bonus == true)
                {
                    playerTwo.Health = Calculate.Bonus(playerOne.AttackStrength, playerTwo.DefensivePower, playerTwo.Health, playerTwo.Title);
                }
                else 
                {
                    playerTwo.Health = Calculate.NoBonus(playerOne.AttackStrength, playerTwo.DefensivePower, playerTwo.Health, playerTwo.Title);
                }
            }

            if (playerTwo.Health < 0)
            {
                Console.WriteLine($"\n{playerTwo.Title}'s health reached below zero. Congratulations, {playerOne.Name}, you have won the Battle of Calypso!\n");
            }
            else 
            {
                Console.WriteLine($"\n{playerOne.Title}'s health reached below zero. Congratulations, {playerTwo.Name}, you have won the Battle of Calypso!\n");
            }
        }


        public static void Game7(DavyJones playerOne, WillTurner playerTwo)
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
                playerTwo.Health = Calculate.Bonus(playerOne.AttackStrength, playerTwo.DefensivePower, playerTwo.Health, playerTwo.Title);
            }
            else 
            {
                playerTwo.Health = Calculate.NoBonus(playerOne.AttackStrength, playerTwo.DefensivePower, playerTwo.Health, playerTwo.Title);
            }

            while (playerOne.Health > 0 && playerTwo.Health > 0)
            {
                playerTwo.attackBehavior.Attack();
                bonus = Calculate.Determine(playerTwo.Title, playerOne.Title);
                if (bonus == true)
                {
                    playerOne.Health = Calculate.Bonus(playerTwo.AttackStrength, playerOne.DefensivePower, playerOne.Health, playerOne.Title);
                }
                else 
                {
                    playerOne.Health = Calculate.NoBonus(playerTwo.AttackStrength, playerOne.DefensivePower, playerOne.Health, playerOne.Title);
                }

                playerOne.attackBehavior.Attack();
                bonus = Calculate.Determine(playerOne.Title, playerTwo.Title);
                if (bonus == true)
                {
                    playerTwo.Health = Calculate.Bonus(playerOne.AttackStrength, playerTwo.DefensivePower, playerTwo.Health, playerTwo.Title);
                }
                else 
                {
                    playerTwo.Health = Calculate.NoBonus(playerOne.AttackStrength, playerTwo.DefensivePower, playerTwo.Health, playerTwo.Title);
                }
            }

            if (playerTwo.Health < 0)
            {
                Console.WriteLine($"\n{playerTwo.Title}'s health reached below zero. Congratulations, {playerOne.Name}, you have won the Battle of Calypso!\n");
            }
            else 
            {
                Console.WriteLine($"\n{playerOne.Title}'s health reached below zero. Congratulations, {playerTwo.Name}, you have won the Battle of Calypso!\n");
            }
        }

        public static void Game8(WillTurner playerOne, DavyJones playerTwo)
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
                playerTwo.Health = Calculate.Bonus(playerOne.AttackStrength, playerTwo.DefensivePower, playerTwo.Health, playerTwo.Title);
            }
            else 
            {
                playerTwo.Health = Calculate.NoBonus(playerOne.AttackStrength, playerTwo.DefensivePower, playerTwo.Health, playerTwo.Title);
            }

            while (playerOne.Health > 0 && playerTwo.Health > 0)
            {
                playerTwo.attackBehavior.Attack();
                bonus = Calculate.Determine(playerTwo.Title, playerOne.Title);
                if (bonus == true)
                {
                    playerOne.Health = Calculate.Bonus(playerTwo.AttackStrength, playerOne.DefensivePower, playerOne.Health, playerOne.Title);
                }
                else 
                {
                    playerOne.Health = Calculate.NoBonus(playerTwo.AttackStrength, playerOne.DefensivePower, playerOne.Health, playerOne.Title);
                }

                playerOne.attackBehavior.Attack();
                bonus = Calculate.Determine(playerOne.Title, playerTwo.Title);
                if (bonus == true)
                {
                    playerTwo.Health = Calculate.Bonus(playerOne.AttackStrength, playerTwo.DefensivePower, playerTwo.Health, playerTwo.Title);
                }
                else 
                {
                    playerTwo.Health = Calculate.NoBonus(playerOne.AttackStrength, playerTwo.DefensivePower, playerTwo.Health, playerTwo.Title);
                }
            }

            if (playerTwo.Health < 0)
            {
                Console.WriteLine($"\n{playerTwo.Title}'s health reached below zero. Congratulations, {playerOne.Name}, you have won the Battle of Calypso!\n");
            }
            else 
            {
                Console.WriteLine($"\n{playerOne.Title}'s health reached below zero. Congratulations, {playerTwo.Name}, you have won the Battle of Calypso!\n");
            }
        }


        public static void Game9(WillTurner playerOne, WillTurner playerTwo)
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
                playerTwo.Health = Calculate.Bonus(playerOne.AttackStrength, playerTwo.DefensivePower, playerTwo.Health, playerTwo.Title);
            }
            else 
            {
                playerTwo.Health = Calculate.NoBonus(playerOne.AttackStrength, playerTwo.DefensivePower, playerTwo.Health, playerTwo.Title);
            }

            while (playerOne.Health > 0 && playerTwo.Health > 0)
            {
                playerTwo.attackBehavior.Attack();
                bonus = Calculate.Determine(playerTwo.Title, playerOne.Title);
                if (bonus == true)
                {
                    playerOne.Health = Calculate.Bonus(playerTwo.AttackStrength, playerOne.DefensivePower, playerOne.Health, playerOne.Title);
                }
                else 
                {
                    playerOne.Health = Calculate.NoBonus(playerTwo.AttackStrength, playerOne.DefensivePower, playerOne.Health, playerOne.Title);
                }

                playerOne.attackBehavior.Attack();
                bonus = Calculate.Determine(playerOne.Title, playerTwo.Title);
                if (bonus == true)
                {
                    playerTwo.Health = Calculate.Bonus(playerOne.AttackStrength, playerTwo.DefensivePower, playerTwo.Health, playerTwo.Title);
                }
                else 
                {
                    playerTwo.Health = Calculate.NoBonus(playerOne.AttackStrength, playerTwo.DefensivePower, playerTwo.Health, playerTwo.Title);
                }
            }

            if (playerTwo.Health < 0)
            {
                Console.WriteLine($"\n{playerTwo.Title}'s health reached below zero. Congratulations, {playerOne.Name}, you have won the Battle of Calypso!\n");
            }
            else 
            {
                Console.WriteLine($"\n{playerOne.Title}'s health reached below zero. Congratulations, {playerTwo.Name}, you have won the Battle of Calypso!\n");
            }
        }
    }
}