using System;
using System.Collections.Generic;
using System.Text;

namespace _0sandXs
{

    
    class Board
    {
        // private string[,] or string[]

        public Board()
        {
            // Add " " to each position board
        }


        public void displayBoard() 
        {
            Console.WriteLine("|" + "|");
            Console.WriteLine("|" + "|");
            Console.WriteLine("|" + "|");
        }

        public bool addCounter(int player, int position)
        {

        }

        public int checkwin()
        {
            // 0 - no Win
            // 1- Player 1 wins
            // 2 - Player 2 wins
            // 3 - Draw

        }

    }
}
