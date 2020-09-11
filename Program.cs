using System;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace BoardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Game.initializevariable();
            Game.Intro();
            while (Game.HasWon() == false)
            {
                Game.AskData("X");
                if (Game.HasWon() == true)
                    break;
                Game.AskData("O");
            }
        }
    }
}
