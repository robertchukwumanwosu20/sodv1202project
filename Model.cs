public class Model
{
    private char[,] board = new char[6, 7];

    public void InitializeBoard()
    {
        for (int i = 0; i < 6; i++)
            for (int j = 0; j < 7; j++)
                board[i, j] = '.';
    }

    public char[,] GetBoard()
    {
        return board;
    }

    public bool DropPiece(int column, char symbol)
    {
        if (column < 0 || column >= 7)
            return false;

        for (int i = 5; i >= 0; i--)
        {
            if (board[i, column] == '.')
            {
                board[i, column] = symbol;
                return true;
            }
        }
        return false;
    }

    public bool IsBoardFull()
    {
        for (int j = 0; j < 7; j++)
        {
            if (board[0, j] == '.')
                return false;
        }
        return true;
    }

    public bool CheckWin(char symbol)
    {
        // horizontal
        for (int i = 0; i < 6; i++)
            for (int j = 0; j < 4; j++)
                if (board[i, j] == symbol &&
                    board[i, j + 1] == symbol &&
                    board[i, j + 2] == symbol &&
                    board[i, j + 3] == symbol)
                    return true;

        // vertical
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 7; j++)
                if (board[i, j] == symbol &&
                    board[i + 1, j] == symbol &&
                    board[i + 2, j] == symbol &&
                    board[i + 3, j] == symbol)
                    return true;

        // diagonal /
        for (int i = 3; i < 6; i++)
            for (int j = 0; j < 4; j++)
                if (board[i, j] == symbol &&
                    board[i - 1, j + 1] == symbol &&
                    board[i - 2, j + 2] == symbol &&
                    board[i - 3, j + 3] == symbol)
                    return true;

        // diagonal \
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 4; j++)
                if (board[i, j] == symbol &&
                    board[i + 1, j + 1] == symbol &&
                    board[i + 2, j + 2] == symbol &&
                    board[i + 3, j + 3] == symbol)
                    return true;

        return false;
    }
}