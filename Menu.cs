using System;
namespace mis321_pa2_bhhicks221
{
    public class Menu
    {
        public static string Character1 {get; set;} = "\nPlayer 1, please choose from the following characters to play with:\n1.) Jack Sparrow\n2.) Davy Jones\n3.) Will Turner\n";
        public static string Welcome {get; set;} = "\nWelcome to The Battle of Calypso's Maelstrom!\nIn this game, you and another player will battle to the death, going to head to head with the best warriors on the raging seas.\n";
        public static string Character2 {get; set;} = "\nPlayer 2, please choose from the following characters to play with:\n1.) Jack Sparrow\n2.) Davy Jones\n3.) Will Turner\n";
        public static string Invalid {get; set;} = "\nSorry, the input you have entered is invalid.\n";
        public static string Player1Name {get; set;} = "Player 1, please enter your name:\n";
        public static string Player2Name{get; set;} = "\nPlayer 2, please enter your name:\n";

        // public Menu()
        // {
        //     Player1Name = "Player 1, please enter your name:\n";
        //     Player2Name = "\nPlayer 2, please enter your name:\n";
        //     Character1 = "\nPlayer 1, please choose from the following characters to play with:\n1.) Jack Sparrow\n2.) Davy Jones\n3.) Will Turner\n";
        //     Welcome = "\nWelcome to The Battle of Calypso's Maelstrom!\nIn this game, you and another player will battle to the death, going to head to head with the best warrios on the raging seas.\n";
        //     Character2 = "\nPlayer 2, please choose from the following characters to play with:\n1.) Jack Sparrow\n2.) Davy Jones\n3.) Will Turner\n";
        //     Invalid = "\nSorry, the input you have entered is invalid.\n";
        // }
        public static int CharacterOne(string name)
        {
            Console.WriteLine($"\n{name}, please choose from the following characters to play with:\n1.) Jack Sparrow\n2.) Davy Jones\n3.) Will Turner\n");
            int input = int.Parse(Console.ReadLine());
            while (input != 1 && input != 2 && input != 3)
            {
                Console.Clear();
                Console.WriteLine(Invalid);
                Console.WriteLine($"\n{name}, please choose from the following characters to play with:\n1.) Jack Sparrow\n2.) Davy Jones\n3.) Will Turner\n");
                input = int.Parse(Console.ReadLine());
            }
            return input;
        }
        public static void PlayerOneChoice(int input, string name)
        {
            switch (input)
            {
                case 1:
                {
                    JackSparrow playerOne = new JackSparrow();
                    playerOne.Name = name;
                    PlayerOneJackSparrow(playerOne);
                }
                    break;
                case 2:
                {
                    DavyJones playerOne = new DavyJones();
                    playerOne.Name = name;
                    PlayerOneDavyJones(playerOne);
                }
                    break;
                case 3:
                {
                    // WillTurner playerOne = new WillTurner(name);
                    WillTurner playerOne = new WillTurner();
                    playerOne.Name = name;
                    PlayerOneWillTurner(playerOne);
                }
                    break;
            }
        }
        public static void PlayerOneJackSparrow(JackSparrow playerOne)
            {
                Console.WriteLine(Player2Name);
                string name = Console.ReadLine();
                int input = CharacterTwo(name);
                switch (input)
                {
                    case 1:
                    {
                        JackSparrow playerTwo = new JackSparrow();
                        playerTwo.Name = name;
                        Console.WriteLine($"{playerOne.Name}, you will be playing with {playerOne.Title}.");
                        Console.WriteLine($"Name: {playerOne.Name} Title: {playerOne.Title} MaxPower: {playerOne.MaxPower} Health: {playerOne.Health} AttackStrength: {playerOne.AttackStrength} DefensiveStrength: {playerOne.DefensivePower}\n");
                        Console.WriteLine($"{playerTwo.Name}, you will be playing with {playerTwo.Title}.");
                        Console.WriteLine($"Name: {playerTwo.Name} Title: {playerTwo.Title} MaxPower: {playerTwo.MaxPower} Health: {playerTwo.Health} AttackStrength: {playerTwo.AttackStrength} DefensiveStrength: {playerTwo.DefensivePower}");

                        Gameplay.CoinFlip1(playerOne, playerTwo);
                    }
                        break;
                    case 2:
                    {
                        DavyJones playerTwo = new DavyJones();
                        playerTwo.Name = name;
                        Console.WriteLine($"{playerOne.Name}, you will be playing with {playerOne.Title}.");
                        Console.WriteLine($"Name: {playerOne.Name} Title: {playerOne.Title} MaxPower: {playerOne.MaxPower} Health: {playerOne.Health} AttackStrength: {playerOne.AttackStrength} DefensiveStrength: {playerOne.DefensivePower}\n");
                        Console.WriteLine($"{playerTwo.Name}, you will be playing with {playerTwo.Title}.");
                        Console.WriteLine($"Name: {playerTwo.Name} Title: {playerTwo.Title} MaxPower: {playerTwo.MaxPower} Health: {playerTwo.Health} AttackStrength: {playerTwo.AttackStrength} DefensiveStrength: {playerTwo.DefensivePower}");

                        Gameplay.CoinFlip(playerOne, playerTwo);
                    }
                        break;
                    case 3:
                    {
                        WillTurner playerTwo = new WillTurner();
                        playerTwo.Name = name;
                        Console.Clear();
                        Console.WriteLine($"{playerOne.Name}, you will be playing with {playerOne.Title}.");
                        Console.WriteLine($"Name: {playerOne.Name} Title: {playerOne.Title} MaxPower: {playerOne.MaxPower} Health: {playerOne.Health} AttackStrength: {playerOne.AttackStrength} DefensiveStrength: {playerOne.DefensivePower}\n");
                        Console.WriteLine($"{playerTwo.Name}, you will be playing with {playerTwo.Title}.");
                        Console.WriteLine($"Name: {playerTwo.Name} Title: {playerTwo.Title} MaxPower: {playerTwo.MaxPower} Health: {playerTwo.Health} AttackStrength: {playerTwo.AttackStrength} DefensiveStrength: {playerTwo.DefensivePower}");

                        Gameplay.CoinFlip2(playerOne, playerTwo);
                    }
                        break;
                }
            }

            public static void PlayerOneDavyJones(DavyJones playerOne)
            {
                Console.WriteLine(Player2Name);
                string name = Console.ReadLine();
                int input = CharacterTwo(name);
                switch (input)
                {
                    case 1:
                    {
                        JackSparrow playerTwo = new JackSparrow();
                        playerTwo.Name = name;
                        Console.WriteLine($"{playerOne.Name}, you will be playing with {playerOne.Title}.");
                        Console.WriteLine($"Name: {playerOne.Name} Title: {playerOne.Title} MaxPower: {playerOne.MaxPower} Health: {playerOne.Health} AttackStrength: {playerOne.AttackStrength} DefensiveStrength: {playerOne.DefensivePower}\n");
                        Console.WriteLine($"{playerTwo.Name}, you will be playing with {playerTwo.Title}.");
                        Console.WriteLine($"Name: {playerTwo.Name} Title: {playerTwo.Title} MaxPower: {playerTwo.MaxPower} Health: {playerTwo.Health} AttackStrength: {playerTwo.AttackStrength} DefensiveStrength: {playerTwo.DefensivePower}");

                        Gameplay.CoinFlip(playerTwo, playerOne);
                    }
                        break;
                    case 2:
                    {
                        DavyJones playerTwo = new DavyJones();
                        playerTwo.Name = name;
                        Console.WriteLine($"{playerOne.Name}, you will be playing with {playerOne.Title}.");
                        Console.WriteLine($"Name: {playerOne.Name} Title: {playerOne.Title} MaxPower: {playerOne.MaxPower} Health: {playerOne.Health} AttackStrength: {playerOne.AttackStrength} DefensiveStrength: {playerOne.DefensivePower}\n");
                        Console.WriteLine($"{playerTwo.Name}, you will be playing with {playerTwo.Title}.");
                        Console.WriteLine($"Name: {playerTwo.Name} Title: {playerTwo.Title} MaxPower: {playerTwo.MaxPower} Health: {playerTwo.Health} AttackStrength: {playerTwo.AttackStrength} DefensiveStrength: {playerTwo.DefensivePower}");

                        Gameplay.CoinFlip3(playerOne, playerTwo);
                    }
                        break;
                    case 3:
                    {
                        WillTurner playerTwo = new WillTurner();
                        playerTwo.Name = name;
                        Console.WriteLine($"{playerOne.Name}, you will be playing with {playerOne.Title}.");
                        Console.WriteLine($"Name: {playerOne.Name} Title: {playerOne.Title} MaxPower: {playerOne.MaxPower} Health: {playerOne.Health} AttackStrength: {playerOne.AttackStrength} DefensiveStrength: {playerOne.DefensivePower}\n");
                        Console.WriteLine($"{playerTwo.Name}, you will be playing with {playerTwo.Title}.");
                        Console.WriteLine($"Name: {playerTwo.Name} Title: {playerTwo.Title} MaxPower: {playerTwo.MaxPower} Health: {playerTwo.Health} AttackStrength: {playerTwo.AttackStrength} DefensiveStrength: {playerTwo.DefensivePower}");

                        Gameplay.CoinFlip4(playerOne, playerTwo);
                    }
                        break;
                }
            }

            public static void PlayerOneWillTurner(WillTurner playerOne)
            {
                Console.WriteLine(Player2Name);
                string name = Console.ReadLine();
                int input = CharacterTwo(name);
                // int input = int.Parse(Console.ReadLine());
                // while (input != 1 && input != 2 && input != 3)
                // {
                //     Console.WriteLine(menu.Invalid);
                //     menu.CharacterOne(name);
                //     input = int.Parse(Console.ReadLine());
                // }
                switch (input)
                {
                    case 1:
                    {
                        JackSparrow playerTwo = new JackSparrow();
                        playerTwo.Name = name;
                        Console.WriteLine($"{playerOne.Name}, you will be playing with {playerOne.Title}.");
                        Console.WriteLine($"Name: {playerOne.Name} Title: {playerOne.Title} MaxPower: {playerOne.MaxPower} Health: {playerOne.Health} AttackStrength: {playerOne.AttackStrength} DefensiveStrength: {playerOne.DefensivePower}\n");
                        Console.WriteLine($"{playerTwo.Name}, you will be playing with {playerTwo.Title}.");
                        Console.WriteLine($"Name: {playerTwo.Name} Title: {playerTwo.Title} MaxPower: {playerTwo.MaxPower} Health: {playerTwo.Health} AttackStrength: {playerTwo.AttackStrength} DefensiveStrength: {playerTwo.DefensivePower}");

                        Gameplay.CoinFlip2(playerTwo, playerOne);
                    }
                        break;
                    case 2:
                    {
                        DavyJones playerTwo = new DavyJones();
                        playerTwo.Name = name;
                        Console.WriteLine($"{playerOne.Name}, you will be playing with {playerOne.Title}.");
                        Console.WriteLine($"Name: {playerOne.Name} Title: {playerOne.Title} MaxPower: {playerOne.MaxPower} Health: {playerOne.Health} AttackStrength: {playerOne.AttackStrength} DefensiveStrength: {playerOne.DefensivePower}\n");
                        Console.WriteLine($"{playerTwo.Name}, you will be playing with {playerTwo.Title}.");
                        Console.WriteLine($"Name: {playerTwo.Name} Title: {playerTwo.Title} MaxPower: {playerTwo.MaxPower} Health: {playerTwo.Health} AttackStrength: {playerTwo.AttackStrength} DefensiveStrength: {playerTwo.DefensivePower}");

                        Gameplay.CoinFlip4(playerTwo, playerOne);
                    }
                        break;
                    case 3:
                    {
                        WillTurner playerTwo = new WillTurner();
                        playerTwo.Name = name;
                        Console.WriteLine($"{playerOne.Name}, you will be playing with {playerOne.Title}.");
                        Console.WriteLine($"Name: {playerOne.Name} Title: {playerOne.Title} MaxPower: {playerOne.MaxPower} Health: {playerOne.Health} AttackStrength: {playerOne.AttackStrength} DefensiveStrength: {playerOne.DefensivePower}\n");
                        Console.WriteLine($"{playerTwo.Name}, you will be playing with {playerTwo.Title}.");
                        Console.WriteLine($"Name: {playerTwo.Name} Title: {playerTwo.Title} MaxPower: {playerTwo.MaxPower} Health: {playerTwo.Health} AttackStrength: {playerTwo.AttackStrength} DefensiveStrength: {playerTwo.DefensivePower}");

                        Gameplay.CoinFlip5(playerOne, playerTwo);
                    }
                        break;
                }
            }

        public static int CharacterTwo(string name)
        {
            Console.WriteLine($"\n{name}, please choose from the following characters to play with:\n1.) Jack Sparrow\n2.) Davy Jones\n3.) Will Turner\n");
            int input = int.Parse(Console.ReadLine());
            while (input != 1 && input != 2 && input != 3)
            {
                Console.Clear();
                Console.WriteLine(Invalid);
                Console.WriteLine($"\n{name}, please choose from the following characters to play with:\n1.) Jack Sparrow\n2.) Davy Jones\n3.) Will Turner\n");
                input = int.Parse(Console.ReadLine());
            }
            return input;
        }
    }
}