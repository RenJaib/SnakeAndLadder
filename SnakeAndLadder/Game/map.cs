namespace SnakeAndLadder.Game
{
    public static class map
    {
        public static IEnumerable<Tile> InitializeMap()
        {
            var map = new List<Tile>();
            for (var i = 0; i < 72; i++)
            {
                if (i == 10)
                {
                    map.Add(new Tile() { PositionToTakeTo = 3, TileType = TileType.Snake });
                    continue;
                }

                if (i == 6)
                {
                    map.Add(new Tile() { PositionToTakeTo = 16, TileType = TileType.Ladder });
                    continue;
                }

                map.Add(new Tile() { PositionToTakeTo= i+1, TileType = TileType.Blank });
            }

            return map;
        }
    }
}