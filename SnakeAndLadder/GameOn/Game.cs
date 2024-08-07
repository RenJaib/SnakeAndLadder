using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder.GameOn
{
    public class Game
    {
        private readonly Player _player;

        public Game(Player player)
        {
            _player = player;
        }

        public int PlayerMove(Player player, int noOfTilesToMove, List<Snake> snakeList, List<Ladder> ladderList)
        {
            Console.WriteLine($"rolled {noOfTilesToMove}");
            _player.Position = player.Position + noOfTilesToMove;
            

            if (ladderList.Any(x => x.Position == player.Position))
            {
                Console.WriteLine("you climbed a ladder");
                _player.Position = ladderList.FirstOrDefault(x => x.Position == player.Position).TargetPosition;
                Console.WriteLine($"you are now at position {_player.Position}");

                return _player.Position;
            }

            if (snakeList.Any(x => x.Position == player.Position))
            {
                Console.WriteLine(" you are eaten by snake");
                _player.Position = snakeList.FirstOrDefault(x => x.Position == player.Position).TargetPosition;
                Console.WriteLine($"you are now at position {_player.Position}");

                return _player.Position;
            }

            Console.WriteLine($"you are now at position {_player.Position}");

            return _player.Position;
        }


        public int PlayerRollDice()
        {
            while(!Raylib.IsKeyPressed(KeyboardKey.Space))
            {
                Raylib.BeginDrawing();
                Raylib.DrawText("Press space key to Roll dice", 12, 52, 20, Color.Blue); ;
                Raylib.EndDrawing();
            }


            Random random = new Random();
            return random.Next(1, 7);

        }

        public bool CheckIfPlayerWon(Player playerRenju, int numberOfTiles)
        {
            return playerRenju.Position >= numberOfTiles;
        }
    }
}
