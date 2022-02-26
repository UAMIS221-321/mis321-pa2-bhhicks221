using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace mis321_pa2_bhhicks221
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            Console.Clear();
            Console.WriteLine(Menu.Welcome);
            Console.WriteLine(Menu.Player1Name);
            string name = Console.ReadLine();
            int input = Menu.CharacterOne(name);
            Menu.PlayerOneChoice(input, name);
        }
            // if ((playerOne.Equals(typeof(JackSparrow))) && playerTwo.Equals(typeof(WillTurner)))
            // {
            //     Console.WriteLine("{0} is an integer data type.", value)
            // }
            // else if ((playerOne.Equals(typeof(WillTurner))) && playerTwo.Equals(typeof(DavyJones)))
            // {

            // }
            // else if ((playerOne.Equals(typeof(DavyJones))) && playerTwo.Equals(typeof(JackSparrow)))
            // {

            // }
            
    }
}
