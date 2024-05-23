namespace SnakeAndLadder.Game
{
    public class Tile
    {
        public int PositionToTakeTo { get; set; }
        public TileType TileType { get; set; }
    }

    public enum TileType
    {
        Snake,
        Ladder,
        Blank
    }
}