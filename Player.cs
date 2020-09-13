using System;
using System.Collections.Generic;
using System.Text;

namespace BoardGame
{
    public class Player
    {


        public static void Players()
        {
            string playerName1 = "";
            Console.WriteLine("Hvad er navnet på spiller 1?");
            playerName1 = Console.ReadLine();
            Console.Clear();

            string playerName2 = "";
            Console.WriteLine("Hvad er navnet på spiller 2?");
            playerName2 = Console.ReadLine();
            Console.Clear();
        }




        //    this.name = name;
        //    this.letter = letter;
        //}
        //public string GetName()
        //{
        //    return this.name;
        //}
        //public string GetLetter()
        //{
        //    return this.letter;
        //}
    }
}
