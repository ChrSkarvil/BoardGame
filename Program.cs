using System;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace BoardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Player Player1 = new Player("Hans", "X");
            Player Player2 = new Player("Torben", "B");

            Game.InitializeVariable();
            Game.Intro();
            while (Game.HasWon() == false)
            {
                Game.AskData(Player1);
                if (Game.HasWon() == true)
                    break;
                Game.AskData(Player2);
            }
        }
    }
}
