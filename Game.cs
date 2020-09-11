using System;
using System.Collections.Generic;
using System.Text;

namespace BoardGame
{
    public class Game
    {

       static int ODice = 0;
       static int XDice = 0;
       static String[] board = new String[2];
       static String[] board2 = new String[3];
       static String[] board3 = new String[4];

        public static void initializevariable()
        {
            for (int i = 0; i < 2; i++)
            {
                board[i] = i.ToString();
            }
            for (int i = 0; i < 3; i++)
            {
                board2[i] = i.ToString();
            }
            for (int i = 0; i < 4; i++)
            {
                board3[i] = i.ToString();
            }
        }

        public static void AskData(string player)
        {
            Random r = new Random();
            Console.WriteLine("Player: " + player);
            XDice = r.Next(1, 7);
            Console.WriteLine($"Du slog {XDice}");
            DrawBoard();
            //int selection = Convert.ToInt32(Console.ReadLine());
            //board[hit] = player;
            //board[selection] = player;
        }

        public static void DrawBoard()
        {
            for (int i = 0; i < 2; i += 2) //Tegn spillepladen
                Console.WriteLine(board[i + 0] + "|" + board[i + 0] + "|" + board[i + 1]);

            for (int i = 0; i < 2; i += 2) //Tegn spillepladen
                Console.WriteLine(board2[i + 0] + "|" + board2[i + 0] + "|" + board2[i + 1] + "|" + board2[i + 2]);

            for (int i = 0; i < 2; i += 2) //Tegn spillepladen
                Console.WriteLine(board3[i + 0] + "|" + board3[i + 0] + "|" + board3[i + 1] + "|" + board3[i + 2] + "|" + board3[i + 3]);

        }

       public static Boolean HasWon()
        {
            return false;
        }

        public static void Intro()
        {
            Console.Title = ("Brætspil");


            Console.WriteLine("Tryk på en knap for at starte spillet");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
