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

            board[0] = "X";
            board[4] = "X";
            board[8] = "X";

        }


        public void displayBoard() 
        {
            Console.WriteLine(board[0] + "|" + board[1] + "|" + board[2]);
            Console.WriteLine(board[3] + "|" + board[4] + "|" + board[5]);
            Console.WriteLine(board[6] + "|" + board[7] + "|" + board[8]);
        }

        public bool addCounter(int player, int position)
        {
            board[position] =

        }

        public int checkwin()
        {
            // 0 - no Win
            // 1- Player 1 wins
            // 2 - Player 2 wins
            // 3 - Draw

            if(board[0]=="X" && board[4]=="X" && board[8] == "X")
            {
                Console.WriteLine("player 1 wins");
            }
            if (board[2] == "X" && board[4] == "X" && board[6] == "X")
            {
                Console.WriteLine("player 1 wins");
            }
            if (board[0] == "X" && board[3] == "X" && board[6] == "X")
            {
                Console.WriteLine("player 1 wins");
            }
            if (board[1] == "X" && board[4] == "X" && board[7] == "X")
            {
                Console.WriteLine("player 1 wins");
            }
            if (board[2] == "X" && board[5] == "X" && board[8] == "X")
            {
                Console.WriteLine("player 1 wins");
            }
            if (board[0] == "X" && board[1] == "X" && board[2] == "X")
            {
                Console.WriteLine("player 1 wins");
            }
            if (board[3] == "X" && board[4] == "X" && board[5] == "X")
            {
                Console.WriteLine("player 1 wins");
            }
            if (board[6] == "X" && board[7] == "X" && board[8] == "X")
            {
                Console.WriteLine("player 1 wins");
            }



            if (board[0] == "O" && board[4] == "O" && board[8] == "O")
            {
                Console.WriteLine("player 2 wins");
            }
            if (board[2] == "O" && board[4] == "O" && board[6] == "O")
            {
                Console.WriteLine("player 2 wins");
            }
            if (board[0] == "O" && board[3] == "O" && board[6] == "O")
            {
                Console.WriteLine("player 2 wins");
            }
            if (board[1] == "O" && board[4] == "O" && board[7] == "O")
            {
                Console.WriteLine("player 2 wins");
            }
            if (board[2] == "O" && board[5] == "O" && board[8] == "O")
            {
                Console.WriteLine("player 2 wins");
            }
            if (board[0] == "O" && board[1] == "O" && board[2] == "O")
            {
                Console.WriteLine("player 2 wins");
            }
            if (board[3] == "O" && board[4] == "O" && board[5] == "O")
            {
                Console.WriteLine("player 2 wins");
            }
            if (board[6] == "O" && board[7] == "O" && board[8] == "O")
            {
                Console.WriteLine("player 2 wins");
            }

        }


    }
}
