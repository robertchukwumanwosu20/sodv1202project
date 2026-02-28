public class Model
{
    private char[,] board = new char[6, 7];

    public void InitializeBoard()
    {
     
    }

    public bool DropPiece(int column, char symbol)
    {
        return true;
    }

    public bool CheckWin(char symbol)
    {
        return false;
    }
}