using System;

public class View
{
    public void DisplayBoard(char[,] board)
    {
        Console.Clear();

        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                Console.Write(board[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("1 2 3 4 5 6 7");
    }

    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }
}