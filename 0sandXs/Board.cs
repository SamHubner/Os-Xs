using System;
using System.Collections.Generic;
using System.Text;

namespace _0sandXs
{

    
    class Board
    {
        // private string[,] or string[]

         string[] board = new string[9];



        public Board()
        {
            // Add " " to each position board
            
            for(int x = 0; x<9; x = x + 1)
            {
                board[x] = " ";
            }
        }


        public void displayBoard() 
        {
            Console.WriteLine(board[0] + "|" + board[1] + "|" + board[2]);
            Console.WriteLine(board[3] + "|" + board[4] + "|" + board[5]);
            Console.WriteLine(board[6] + "|" + board[7] + "|" + board[8]);
        }

     //   public bool addCounter(int player, int position)
       // {

       // }

     //   public int checkwin()
      //  {
            // 0 - no Win
            // 1- Player 1 wins
            // 2 - Player 2 wins
            // 3 - Draw

        //}

    }
}
