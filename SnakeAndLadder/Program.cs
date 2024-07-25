using Raylib_cs;
using SnakeAndLadder.GameOn;


//ladder position
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

//snake position
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


var playerRenju = new Player() { Position = 0 };

var board = new Board() { NumberOfRows = 8,NumberOfColumns = 9};

var game = new Game(playerRenju);

Raylib.InitWindow(800, 480, "SnakeAndLadder");

while (!Raylib.WindowShouldClose())
{
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.White);

    Raylib.DrawText("Hello, Player!", 12, 12, 20, Color.Black);
    Raylib.DrawText("Lets roll Dice!", 12, 12, 20, Color.Blue);

    while (true)
    {
        var gameEntryDiceOutput = game.PlayerRollDice();


        if (gameEntryDiceOutput == 6)
        {
           Raylib.DrawText("You rolled 6! Game Begins", 12, 12, 20, Color.Pink);

            while (true)
            {
                var playerTurnDiceOutput = game.PlayerRollDice();
                game.PlayerMove(playerRenju, playerTurnDiceOutput, snakes, ladders);
                board.PrintBoard(playerRenju.Position);

                if (game.CheckIfPlayerWon(playerRenju, board.NumberOfTiles))
                {
                    Console.WriteLine("you reached position 72!! you won. Game Over");
                    Environment.Exit(0);
                }
            }
        }
        else
        {
            Console.WriteLine($"You rolled {gameEntryDiceOutput}! Game not open. Roll Dice again.");
        }
    }

    Raylib.EndDrawing();
}


