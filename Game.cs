using System;
using System.Collections.Generic;
using System.Text;

namespace BoardGame
{
    public class Game
    {
        //Laver arrays med board størrelse
       static Boolean Player1Six = false;
       static Boolean Player2Six = false;
       static int[] Player1Dice = new int[2];
       static int[] Player2Dice = new int[2];
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

        public static void Dice()
        {
            Random r = new Random();
            for (int i = 0; i < 2; i++)
            {
                Player1Dice[i] = r.Next(1, 7);


            }


        }

        //Skriver dataen ind på boardet.
        public static void Placement()
        {
            Console.WriteLine("Du har slået");
            DrawBoard();
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
