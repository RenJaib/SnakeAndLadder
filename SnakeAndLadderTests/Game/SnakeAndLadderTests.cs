using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnakeAndLadder.Game;


namespace SnakeAndLadderTests.Game
{
    public class SnakeAndLadderTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void PlayerGetsStartMessageWhenGameIsLaunched()
        {
            //arrange
            var game = new SnakeAndLadderGame();

            //act
            var actual = game.GameStart();

            //assert
            Assert.AreEqual("Hello, Player!! Welcome!! Please Roll your dice", actual, "StartMessage is incorrect");
        }

        [Test]
        public void PlayerIsAbleToRollDiceWhenPrompted()
        {
            //arrage
            var game = new SnakeAndLadderGame();

            //act
            int diceValue = game.RollDice();

            //assert
            Assert.That(diceValue, Is.InRange(1, 6), $"Value {diceValue} is not between 1 and 6");
        }

        [Test]
        public void RollDiceResultIsDisplayedToPlayer()
        {
            //arrage
            var game = new SnakeAndLadderGame();
            var diceOutput = game.RollDice();

            //act
            string message = game.DisplayDiceOutputToPlayer(diceOutput);

            //assert
            Assert.AreEqual(message, $"you rolled {diceOutput}");
        }

        [Test]
        public void MapExistsWhenGameStarts()
        {
            //arrage
            var game = new SnakeAndLadderGame();
            var loadMap = game.LoadMap();

            //act

            //assert 
            Assert.IsNotNull(loadMap, "Expected map to be not null");
        }

        [Test]
        public void WhenGameInitializedMapIsReadyWithSnakesAndSnakesInTheCorrectPositions()
        {
            //arrage
            var game = new SnakeAndLadderGame();
            var expectedSnakePositionToTake = 3;

            //act
            var loadMap = game.LoadMap();
            var actualSnakePosition = loadMap.ElementAt(10).PositionToTakeTo;

            //assert 
            Assert.AreEqual(expectedSnakePositionToTake, actualSnakePosition, $"Expected postition at 10 to be {expectedSnakePositionToTake} but is {actualSnakePosition} ");
        }

        [Test]
        public void WhenGameInitializedMapIsReadyWithLaddersAndLaddersInTheCorrectPositions()
        { 
            //arrage
            var game = new SnakeAndLadderGame();
            var expectedLadderPositionToTake = 16;

            //act
            var loadMap = game.LoadMap();
            var actualLadderPosition = loadMap.ElementAt(6).PositionToTakeTo;

            //assert 
            Assert.AreEqual(expectedLadderPositionToTake, actualLadderPosition, $"Expected postition at 10 to be {expectedLadderPositionToTake} but is {actualLadderPosition}");
        }
    }
}
