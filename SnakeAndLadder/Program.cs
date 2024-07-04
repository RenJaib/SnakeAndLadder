using SnakeAndLadder.GameOn;

Console.WriteLine("Hello, Player!");


var player1 = new Player() { Position = 0 };

var board = new Board() { NumberOfTiles = 72 };

var ladders = new List<Ladder>()
{
    new Ladder() { Position = 3, TargetPosition = 21 },
    new Ladder() { Position = 10, TargetPosition = 32 },
    new Ladder() { Position = 19, TargetPosition = 47 },
    new Ladder() { Position = 26, TargetPosition = 57 },
    new Ladder() { Position = 35, TargetPosition = 63 },
    new Ladder() { Position = 41, TargetPosition = 66 },
    new Ladder() { Position = 44, TargetPosition = 71 },
    new Ladder() { Position = 50, TargetPosition = 69 },
    new Ladder() { Position = 60, TargetPosition = 38 },
    new Ladder() { Position = 68, TargetPosition = 49 },
};

var snakes = new List<Snake>()
{
    new Snake() { Position = 14, TargetPosition = 4 },
    new Snake() { Position = 23, TargetPosition = 8 },
    new Snake() { Position = 37, TargetPosition = 18 },
    new Snake() { Position = 48, TargetPosition = 29 },
    new Snake() { Position = 52, TargetPosition = 33 },
    new Snake() { Position = 59, TargetPosition = 42 },
    new Snake() { Position = 61, TargetPosition = 45 },
    new Snake() { Position = 64, TargetPosition = 51 },
    new Snake() { Position = 67, TargetPosition = 55 },
    new Snake() { Position = 70, TargetPosition = 58 },
};

var game = new Game(player1);

Console.WriteLine("\n Lets roll Dice");

while (true)
{
    Console.WriteLine("\n Press any key to roll Dice");
    Console.ReadKey();
    var diceOutput = game.RollDice();

    if (diceOutput == 6)
    {
        Console.WriteLine("\n You rolled 6! Game Begins");

        while (true)
        {

            Console.WriteLine("\n Roll Dice again. Press any key");
            Console.ReadKey();
            var diceOutput2 = game.RollDice();
            game.PlayerMove(player1, diceOutput2, snakes, ladders);
            if (player1.Position >= 72)
            {
                Console.WriteLine("\n you reached position 72!! you won. Game Over");
                Environment.Exit(0);
            }
        }
    }
    else
    {
        Console.WriteLine($"\n You rolled {diceOutput}! Game not open. Roll Dice again.");
    }
}