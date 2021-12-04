namespace Connect4Game;

public class Connect4
{
    private readonly int[,] grid = new int[6, 7];
    private readonly Player playerOne = Player.Factory.PlayerOne();
    private readonly Player playerTwo = Player.Factory.PlayerTwo();
    private readonly int[] rows = { 5, 5, 5, 5, 5, 5, 5 };

    private PlayerNumber turn = PlayerNumber.One;

    public string Play(int column)
    {
        if (playerOne.IsWinner || playerTwo.IsWinner)
        {
            return "Game over";
        }

        var row = rows[column]--;

        if (row < 0) { return "Column full"; }

        Player player;

        if (turn == PlayerNumber.One)
        {
            turn = PlayerNumber.Two;
            player = playerOne;
        }
        else
        {
            turn = PlayerNumber.One;
            player = playerTwo;
        }

        return CheckWinner(player, row, column);
    }

    private string CheckWinner(Player player, int row, int column)
    {
        var number = (int)player.Number;
        grid[row, column] = number;

        player.IsWinner = ++player.Movements >= 4 &&
            (CheckColumnWin(number, row, column) ||
             CheckRowWin(number, row) ||
             CheckDownwardDiagonalWin(number, row, column) ||
             CheckUpwardDiagonalWin(number, row, column));

        return player.IsWinner
            ? $"Player {number} won"
            : $"It's player {(number == 1 ? 2 : 1)} turn";
    }

    private bool CheckColumnWin(int player, int x, int y)
    {
        if (x > 2) { return false; }

        return grid[x, y] == player &&
            grid[x + 1, y] == player &&
            grid[x + 2, y] == player &&
            grid[x + 3, y] == player;
    }

    private bool CheckRowWin(int player, int x)
    {
        var discsInARow = 0;

        for (var i = 0; i < 7; i++)
        {
            discsInARow = grid[x, i] == player ? ++discsInARow : 0;

            if (discsInARow == 4) { return true; }
        }

        return false;
    }

    private bool CheckDownwardDiagonalWin(int player, int x, int y)
    {
        if (x >= y)
        {
            var row = x - y;

            if (row > 2) { return false; }

            var columnLimit = 6 - row;
            var discsInARow = 0;

            for (var i = 0; i < columnLimit; i++)
            {
                discsInARow = grid[row + i, i] == player ? ++discsInARow : 0;

                if (discsInARow == 4) { return true; }
            }
        }
        else
        {
            var column = y - x;

            if (column > 3) { return false; }

            var rowLimit = 7 - column;
            var discsInARow = 0;

            for (var i = 0; i < rowLimit; i++)
            {
                discsInARow = grid[i, column + i] == player ? ++discsInARow : 0;

                if (discsInARow == 4) { return true; }
            }
        }

        return false;
    }

    private bool CheckUpwardDiagonalWin(int player, int x, int y)
    {
        var row = x + y;
        var column = y - (5 - x);

        switch (row)
        {
            case >= 3 and <= 5:
            {
                var discsInARow = 0;

                for (var i = row; i >= 0; i--)
                {
                    discsInARow = grid[i, row - i] == player ? ++discsInARow : 0;

                    if (discsInARow == 4) { return true; }
                }

                return false;
            }

            case > 5 when column <= 3:
            {
                var rowLimit = 5;
                var discsInARow = 0;

                for (var i = column; i <= 6; i++)
                {
                    discsInARow = grid[rowLimit--, i] == player ? ++discsInARow : 0;

                    if (discsInARow == 4) { return true; }
                }

                return false;
            }

            default:
                return false;
        }
    }
}
