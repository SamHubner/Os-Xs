﻿using System;
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
        }


        public void displayBoard() 
        {
            Console.WriteLine(board[0] + "|" + board[1] + "|" + board[2]);
            Console.WriteLine(board[3] + "|" + board[4] + "|" + board[5]);
            Console.WriteLine(board[6] + "|" + board[7] + "|" + board[8]);
        }

         public string[] addCounter(int player, int position)
         {
            if (player == 0) board[position] = "O"; else board[position] = "X";
            displayBoard();
            checkWin();
            
            return board;
         }

        public int checkWin()
        {
            int result = 4;
            int[,] winningLines = { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 }, { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 }, { 0, 4, 8 }, { 2, 4, 6 } };
            for (int x = 0; x<2; x=x+1)
            {
                for (int i = 0; i < winningLines.Length/3; i=i+1)
                {
                    if (board[winningLines[i,0]] == c[x] && board[winningLines[i,1]] == c[x] && board[winningLines[i,2]] == c[x])
                    {
                        result = x;
                        Console.WriteLine("player " + x + " wins");
                    }
                    else
                    {
                        result = 4;
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
