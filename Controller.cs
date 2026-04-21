using System;

public class Controller
{
    private Model model;
    private View view;
    private Player player1;
    private Player player2;

    public void StartGame()
    {
        model = new Model();
        view = new View();

        player1 = new HumanPlayer("Player 1", 'X');
        player2 = new HumanPlayer("Player 2", 'O');

        bool playAgain = true;

        while (playAgain)
        {
            model.InitializeBoard();
            Player currentPlayer = player1;
            bool gameOver = false;

            while (!gameOver)
            {
                view.DisplayBoard(model.GetBoard());

                // ✅ FIXED PART STARTS HERE
                int column;
                bool success = false;

                while (!success)
                {
                    column = currentPlayer.GetMove();
                    success = model.DropPiece(column, currentPlayer.Symbol);

                    if (!success)
                    {
                        view.ShowMessage("Column full. Try another column.");
                    }
                }
                // ✅ FIXED PART ENDS HERE

                if (model.CheckWin(currentPlayer.Symbol))
                {
                    view.DisplayBoard(model.GetBoard());
                    view.ShowMessage(currentPlayer.Name + " wins!");
                    gameOver = true;
                }
                else if (model.IsBoardFull())
                {
                    view.DisplayBoard(model.GetBoard());
                    view.ShowMessage("Draw game.");
                    gameOver = true;
                }
                else
                {
                    currentPlayer = currentPlayer == player1 ? player2 : player1;
                }
            }

            view.ShowMessage("Play again? (y/n)");
            string input = Console.ReadLine();
            playAgain = input.ToLower() == "y";
        }
    }
}