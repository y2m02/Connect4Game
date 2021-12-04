using Connect4Game;

Console.WriteLine("Columns");
var game = new Connect4();
Console.WriteLine(game.Play(0)); // 1
Console.WriteLine(game.Play(1)); // 2
Console.WriteLine(game.Play(0)); // 1
Console.WriteLine(game.Play(1)); // 2
Console.WriteLine(game.Play(0)); // 1
Console.WriteLine(game.Play(1)); // 2
Console.WriteLine(game.Play(0)); // 1
Console.WriteLine(game.Play(1)); // 2
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Rows");
game = new();
Console.WriteLine(game.Play(0)); // 1
Console.WriteLine(game.Play(1)); // 2
Console.WriteLine(game.Play(1)); // 1
Console.WriteLine(game.Play(2)); // 2
Console.WriteLine(game.Play(2)); // 1
Console.WriteLine(game.Play(3)); // 2
Console.WriteLine(game.Play(3)); // 1
Console.WriteLine(game.Play(4)); // 2
Console.WriteLine(game.Play(4)); // 1
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Diagonal 1-1");
game = new();
Console.WriteLine(game.Play(0)); // 1
Console.WriteLine(game.Play(0)); // 2
Console.WriteLine(game.Play(0)); // 1
Console.WriteLine(game.Play(0)); // 2
Console.WriteLine(game.Play(1)); // 1
Console.WriteLine(game.Play(1)); // 2
Console.WriteLine(game.Play(2)); // 1
Console.WriteLine(game.Play(1)); // 2
Console.WriteLine(game.Play(4)); // 1
Console.WriteLine(game.Play(2)); // 2
Console.WriteLine(game.Play(4)); // 1
Console.WriteLine(game.Play(3)); // 2
Console.WriteLine(game.Play(3)); // 1
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Diagonal 1-2");
game = new();
Console.WriteLine(game.Play(2)); // 1
Console.WriteLine(game.Play(2)); // 2
Console.WriteLine(game.Play(2)); // 1
Console.WriteLine(game.Play(2)); // 2
Console.WriteLine(game.Play(2)); // 1
Console.WriteLine(game.Play(3)); // 2
Console.WriteLine(game.Play(4)); // 1
Console.WriteLine(game.Play(5)); // 2
Console.WriteLine(game.Play(5)); // 1
Console.WriteLine(game.Play(4)); // 2
Console.WriteLine(game.Play(4)); // 1
Console.WriteLine(game.Play(3)); // 2
Console.WriteLine(game.Play(3)); // 1
Console.WriteLine(game.Play(0)); // 2
Console.WriteLine(game.Play(3)); // 1
Console.WriteLine(game.Play(3)); // 2
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Diagonal 2-1");
game = new();
Console.WriteLine(game.Play(2)); // 1
Console.WriteLine(game.Play(2)); // 2
Console.WriteLine(game.Play(2)); // 1
Console.WriteLine(game.Play(3)); // 2
Console.WriteLine(game.Play(3)); // 1
Console.WriteLine(game.Play(0)); // 2
Console.WriteLine(game.Play(3)); // 1
Console.WriteLine(game.Play(2)); // 2
Console.WriteLine(game.Play(3)); // 1
Console.WriteLine(game.Play(4)); // 2
Console.WriteLine(game.Play(6)); // 1
Console.WriteLine(game.Play(4)); // 2
Console.WriteLine(game.Play(0)); // 1
Console.WriteLine(game.Play(4)); // 2
Console.WriteLine(game.Play(4)); // 1
Console.WriteLine(game.Play(2)); // 2
Console.WriteLine(game.Play(4)); // 1
Console.WriteLine(game.Play(5)); // 2
Console.WriteLine(game.Play(5)); // 1
Console.WriteLine(game.Play(5)); // 2
Console.WriteLine(game.Play(5)); // 1
Console.WriteLine(game.Play(5)); // 2
Console.WriteLine(game.Play(5)); // 1
Console.WriteLine(game.Play(4)); // 2
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Diagonal 2-2");
game = new();
Console.WriteLine(game.Play(3)); // 1
Console.WriteLine(game.Play(3)); // 2
Console.WriteLine(game.Play(3)); // 1
Console.WriteLine(game.Play(4)); // 2
Console.WriteLine(game.Play(4)); // 1
Console.WriteLine(game.Play(5)); // 2
Console.WriteLine(game.Play(5)); // 1
Console.WriteLine(game.Play(4)); // 2
Console.WriteLine(game.Play(5)); // 1
Console.WriteLine(game.Play(5)); // 2
Console.WriteLine(game.Play(6)); // 1
Console.WriteLine(game.Play(6)); // 2
Console.WriteLine(game.Play(6)); // 1
Console.WriteLine(game.Play(0)); // 2
Console.WriteLine(game.Play(6)); // 1
Console.WriteLine(game.Play(6)); // 2
