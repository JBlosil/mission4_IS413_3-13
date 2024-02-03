using mission4;

char[] board = ['1', '2', '3', '4', '5', '6', '7', '8', '9'];

Console.WriteLine("Welcome to Tic-Tac-Toe!");

int choice;
// Call the function to display the Tic Tac Toe board
Game.DisplayTicTacToeBoard(board);
bool win = false;

// Ask each player in turn for their choice and update the game board array
for (int i = 0; i <= 8; i++)
{
    if (i % 2 == 0 && win == false)
    {
        Console.WriteLine("Player 1, where would you like to go?");
        choice = int.Parse(Console.ReadLine()) - 1;
        board[choice] = 'X';
        Game.DisplayTicTacToeBoard(board);
        if (Game.CheckWinner(board) == true)
        {
            win = true;
        }
        else if (i == 8 && Game.CheckWinner(board) == false)
        {
            win = true;
            Console.WriteLine("It's a tie!");
        }
        else
        {
            win = false;
        }
    }
    else if (i % 2 != 0 && win == false)
    {
        Console.WriteLine("Player 2, where would you like to go?");
        choice = int.Parse(Console.ReadLine()) - 1;
        board[choice] = 'O';
        Game.DisplayTicTacToeBoard(board);
        if (Game.CheckWinner(board) == true)
        {
            win = true;
        }
        else
        {
            win = false;
        }
    }
}