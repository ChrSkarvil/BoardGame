using System;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace BoardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Player.Players();

            Game.InitializeVariable();
            Game.Intro();
            Game.Placement();
        }
    }
}
