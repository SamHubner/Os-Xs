using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace _0sandXs
{
    class Player
    {
        private string Character;
        static int number = 0;


        public int person()
        {
            int playerNo = number;
            number = number++;
            return playerNo;
        }


        public string symbol(string ch)
        {
            if(ch == "X" || ch == "O")
            {
            Character = ch;
            }
            else
            {
                Console.WriteLine("invalid character");
            } 

            return Character;
        }
    }
}
