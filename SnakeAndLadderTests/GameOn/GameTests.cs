using SnakeAndLadder.GameOn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderTests.GameOn
{
    public class GameTests
    {
        [SetUp]
        public void SetUp()
        {

        }

        [Test]
        public void PlayerIsAbleToRollDiceWhenPrompted()
        {
            //arrage
            var player = new Player() { Position = 0 };
            var game = new Game(player);

            //act
            int diceValue = game.PlayerRollDice();

            //assert
            Assert.That(diceValue, Is.InRange(1, 6), $"Value {diceValue} is not between 1 and 6");
        }

        [Test]
        [TestCase(72)]
        [TestCase(73)]
        [TestCase(80)]
        public void PlayerWinsIfPositionIsGreaterThanOrEqualTo72(int playerPosition)
        {
            // Arrange
            var player = new Player() { Position = playerPosition };
            var game = new Game(player);
            var numberOfTiles = 72;

            // Act
            bool isPlayerWon = game.CheckIfPlayerWon(player, numberOfTiles);

            // Assert
            Assert.That (isPlayerWon,
                $"Expected player to win but failed. Player position is {player.Position}, NumberOfTiles is {numberOfTiles}");
        }

        [Test]
        [TestCase(71)]
        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(50)]
        public void PlayerDoesNotWinIfPositionIsLessThan72(int playerPosition)
        {
            // Arrange
            var player = new Player() { Position = playerPosition };
            var game = new Game(player);
            var numberOfTiles = 72;

            // Act
            bool isPlayerWon = game.CheckIfPlayerWon(player, numberOfTiles);

            // Assert
            Assert.That(isPlayerWon,
                $"Expected player not to win but failed. Player position is {player.Position}, NumberOfTiles is {numberOfTiles}");
        }
    }
}
