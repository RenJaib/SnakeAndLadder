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
        public int RollDice()
        {
            Random random = new Random();
            return random.Next(1, 7);
        }

        public int PlayerMove(Player player, int noOfTilesToMove, List<Snake> snakeList, List<Ladder> ladderList)
        {
            Console.WriteLine($"/n rolled {noOfTilesToMove}");
            _player.Position = player.Position + noOfTilesToMove;
            

            if (ladderList.Any(x => x.Position == player.Position))
            {
                Console.WriteLine("/n you climbed a ladder");
                _player.Position = ladderList.FirstOrDefault(x => x.Position == player.Position).TargetPosition;
                Console.WriteLine($"/n you are now at position {_player.Position}");

                return _player.Position;
            }

            if (snakeList.Any(x => x.Position == player.Position))
            {
                Console.WriteLine("/n you are eaten by snake");
                _player.Position = snakeList.FirstOrDefault(x => x.Position == player.Position).TargetPosition;
                Console.WriteLine($"/n you are now at position {_player.Position}");

                return _player.Position;
            }

            Console.WriteLine($"/n you are now at position {_player.Position}");

            return _player.Position;
        }
         
    }
}
