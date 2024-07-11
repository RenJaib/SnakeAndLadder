using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder.GameOn
{
    public class Board
    {
        public int NumberOfRows { get; set; }
        public int NumberOfColumns { get; set; }

        public int NumberOfTiles
        {
            get
            {
                return NumberOfColumns * NumberOfRows;
            }
        }

        public void PrintBoard(int playerPosition)
        {
            for (int i = 0; i < NumberOfRows; i++)
            {
                for (int j = 0; j < NumberOfColumns; j++)
                {
                    var currentTile = i * NumberOfColumns + j + 1;
                    if (currentTile == playerPosition)
                        Console.Write(" O ");
                    else
                        Console.Write(" - ");
                }
                Console.WriteLine();
            }
        }
    }
}
