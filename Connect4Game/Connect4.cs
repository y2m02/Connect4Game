﻿namespace Connect4Game;

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

        var row = rows[column];

        if (row < 0)
        {
            return "Column full";
        }

        if (turn == PlayerNumber.One)
        {
            turn = PlayerNumber.Two;
            grid[rows[column]--, column] = (int)playerOne.Number;

            playerOne.IsWinner = ++playerOne.Movements >= 4 && IsWinner(playerOne.Number, row, column);

            return playerOne.IsWinner ? "Player 1 won" : "It's player 2 turn";
        }

        turn = PlayerNumber.One;
        grid[rows[column]--, column] = (int)playerTwo.Number;

        playerTwo.IsWinner = ++playerTwo.Movements >= 4 && IsWinner(playerTwo.Number, row, column);

        return playerTwo.IsWinner ? "Player 2 won" : "It's player 1 turn";
    }

    private bool IsWinner(PlayerNumber player, int x, int y)
    {
        var number = (int)player;

        return CalculateColumns(number, x, y) ||
            CalculateRows(number, x) ||
            CalculateDiagonal1(number, x, y) ||
            CalculateDiagonal2(number, x, y);
    }

    private bool CalculateRows(int player, int x)
    {
        var discsInARow = 0;

        for (var i = 0; i < 7; i++)
        {
            discsInARow = grid[x, i] == player ? ++discsInARow : 0;

            if (discsInARow == 4) { return true; }
        }

        return false;
    }

    private bool CalculateColumns(int player, int x, int y)
    {
        if (x > 2) { return false; }

        return grid[x, y] == player &&
            grid[x + 1, y] == player &&
            grid[x + 2, y] == player &&
            grid[x + 3, y] == player;
    }

    private bool CalculateDiagonal1(int player, int x, int y)
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

    private bool CalculateDiagonal2(int player, int x, int y)
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
