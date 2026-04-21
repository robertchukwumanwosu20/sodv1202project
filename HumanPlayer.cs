using System;

public class HumanPlayer : Player
{
    public HumanPlayer(string name, char symbol) : base(name, symbol) { }

    public override int GetMove()
    {
        Console.Write(Name + " enter column (1-7): ");
        int column;

        while (!int.TryParse(Console.ReadLine(), out column) || column < 1 || column > 7)
        {
            Console.Write("Invalid input. Enter a number 1-7: ");
        }

        return column - 1;
    }
}