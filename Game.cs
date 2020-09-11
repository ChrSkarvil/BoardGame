using System;
using System.Collections.Generic;
using System.Text;

namespace BoardGame
{
    public class Game
    {
        //Laver arrays med board størrelse
       static String[] board = new String[2];
       static String[] board2 = new String[3];
       static String[] board3 = new String[4];

        //Putter tal ind i boardet.
        public static void InitializeVariable()
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

        //Skriver dataen ind på boardet.
        public static void AskData(int player)
        {
            //int hit = 0;
            Random r = new Random();
            Console.WriteLine("Player: " + );
            //hit = r.Next(1, 7);
            Console.WriteLine("choose selection");
            DrawBoard();
            int selection = Convert.ToInt32(Console.ReadLine());
            //board[hit] = player;
            board[selection] = player;
        }

        public static void DrawBoard()
        {
            //Tegner boardet linje for linje
            for (int i = 0; i < 2; i += 2) //Tegn spillepladen
                Console.WriteLine(board[i + 0] + "|" + board[i + 0] + "|" + board[i + 1]);

            for (int i = 0; i < 2; i += 2) //Tegn spillepladen
                Console.WriteLine(board2[i + 0] + "|" + board2[i + 0] + "|" + board2[i + 1] + "|" + board2[i + 2]);

            for (int i = 0; i < 2; i += 2) //Tegn spillepladen
                Console.WriteLine(board3[i + 0] + "|" + board3[i + 0] + "|" + board3[i + 1] + "|" + board3[i + 2] + "|" + board3[i + 3]);

        }

        //Udskriver vinderen
       public static Boolean HasWon()
        {
            return false;
        }

        //Introduktion til spillet
        public static void Intro()
        {
            Console.Title = ("Brætspil");


            Console.WriteLine("Tryk på en knap for at starte spillet");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
