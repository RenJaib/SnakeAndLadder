namespace SnakeAndLadder.Game
{
    public class SnakeAndLadderGame
    {
        public string GameStart()
        {
            return "Hello, Player!! Welcome!! Please Roll your dice";
        }

        public int RollDice()
        {
            Random random = new Random();
            return random.Next(1, 7);
        }


        public string DisplayDiceOutputToPlayer(int diceOutput)
        {
            return $"you rolled {diceOutput}";
        }

        public List<Tile> LoadMap()
        {
            return map.InitializeMap().ToList();
        }
    }
}
