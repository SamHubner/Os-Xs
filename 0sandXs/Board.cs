using System;
using System.Collections.Generic;
using System.Text;

namespace _0sandXs
{
    
    
    class Board
    {
        // private string[,] or string[]

         string[] board = new string[9];
         string[] c = { "O", "X" };


        public Board()
        {
            
            for(int x = 0; x<9; x = x + 1)
            {
                board[x] = " ";
            }

            board[0] = "O";
            board[4] = "O";
            board[8] = "O";

        }


        public void displayBoard() 
        {
            Console.WriteLine(board[0] + "|" + board[1] + "|" + board[2]);
            Console.WriteLine(board[3] + "|" + board[4] + "|" + board[5]);
            Console.WriteLine(board[6] + "|" + board[7] + "|" + board[8]);
        }

         public bool addCounter(int player, int position)
         {
            if (player == 0) board[position] = "X"; else board[position] = "O";
         }

        public int checkwin()
        {
            int result = 4;
            int[,] winningLines = { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 }, { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 }, { 0, 4, 8 }, { 2, 4, 6 } };
            for (int x = 0; x<2; x++)
            {
                for (int i = 0; i < winningLines.Length; i++)
                {
                    if (board[winningLines[i,0]] == c[x] && board[winningLines[i,1]] == c[x] && board[winningLines[i,2]] == c[x])
                    {
                        result = x;
                    }

                }

            }
            // 0 - no Win
            // 1- Player 1 wins
            // 2 - Player 2 wins
            // 3 - Draw
               
            return result;

        }


    }
}
