namespace Connect4Game;

public class Player
{
    private Player(PlayerNumber number) => Number = number;

    public PlayerNumber Number { get; }
    public int Movements { get; set; }
    public bool IsWinner { get; set; }

    public static class Factory
    {
        public static Player PlayerOne() => new(PlayerNumber.One);
        public static Player PlayerTwo() => new(PlayerNumber.Two);
    }
}
