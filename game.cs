using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mission4
{
    internal class Game
    {
        public static void DisplayTicTacToeBoard(char[] board)
        {
            Console.WriteLine("Tic Tac Toe Board:");
            for (int i = 0; i < board.Length; i += 3)
            {
                Console.WriteLine(" {0} | {1} | {2} ", board[i], board[i + 1], board[i + 2]);
                if (i < board.Length - 3) // To prevent printing the separator after the last line
                {
                    Console.WriteLine("---+---+---");
                }
            }
        }

        // Contain a method that receives the game board array as input
        // and returns if there is a winner and who it was
        public static bool CheckWinner(char[] board)
        {
            // Check for a winner
            if ((board[0] == board[1] && board[1] == board[2] && board[0] != ' ') ||
                (board[3] == board[4] && board[4] == board[5] && board[3] != ' ') ||
                (board[6] == board[7] && board[7] == board[8] && board[6] != ' ') ||
                (board[0] == board[3] && board[3] == board[6] && board[0] != ' ') ||
                (board[1] == board[4] && board[4] == board[7] && board[1] != ' ') ||
                (board[2] == board[5] && board[5] == board[8] && board[2] != ' ') ||
                (board[0] == board[4] && board[4] == board[8] && board[0] != ' ') ||
                (board[2] == board[4] && board[4] == board[6] && board[2] != ' '))
            {
                if (board[0] == 'X' || board[3] == 'X' || board[6] == 'X' ||
                    board[1] == 'X' || board[4] == 'X' || board[7] == 'X' ||
                    board[2] == 'X' || board[5] == 'X' || board[8] == 'X')
                {
                    Console.WriteLine("Player 1 Wins!");
                }
                else
                {
                    Console.WriteLine("Player 2 Wins!");
                }
                return true;
            }
            if (board[0] != 'X' || board[1] != 'X' || board[2] != 'X' || board[3] != 'X' || board[4] != 'X' ||
                board[5] != 'X' || board[6] != 'X' || board[7] != 'X' || board[8] != 'X' || board[1] != 'O' ||
                board[2] != 'O' || board[3] != 'O' || board[4] != 'O' || board[5] != 'O' || board[6] != 'O' ||
                board[7] != 'O' || board[8] != 'O' || board[0] != 'O')
            {
                return false;
            }
            Console.WriteLine("It's a tie!");
            return true;
        }
    }
}
