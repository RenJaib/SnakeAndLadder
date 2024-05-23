using SnakeAndLadder.Game;

Console.WriteLine("Hello, Player!");


var game = new SnakeAndLadderGame();
var map = game.LoadMap();
var mapPositionToTake = map.Select(x => x.PositionToTakeTo).ToList();
Console.WriteLine($"Current map tile positionToTake is {string.Join(", ", mapPositionToTake)}");
Console.WriteLine(game.GameStart());

Console.WriteLine(game.DisplayDiceOutputToPlayer(game.RollDice()));