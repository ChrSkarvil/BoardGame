using System;
using System.Collections.Generic;
using System.Text;

namespace BoardGame
{
    public class Player
    {
        private string name;
        private string letter;

        public Player(string name, string letter)
        {
            this.name = name;
            this.letter = letter;
        }
        public string GetName()
        {
            return this.name;
        }
        public string GetLetter()
        {
            return this.letter;
        }
    }
}
