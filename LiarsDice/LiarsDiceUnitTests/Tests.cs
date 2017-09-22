using LiarsDice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace LiarsDiceUnitTests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void NewGame()
        {
            LiarsDiceGame game = new LiarsDiceGame(7);
            Assert.AreEqual(7, game.Players.Count());
            Assert.IsNotNull(game.Players.ElementAt(0).Dice);
            Assert.IsNotNull(game.Players.ElementAt(0).Dice.ElementAt(0));

            game.Players.ElementAt(0).RollDice();
            Console.WriteLine(game.Players.ElementAt(0).Dice.ElementAt(0).DieFace);
            //Assert.IsTrue((int)game.Players.ElementAt(0).Dice.ElementAt(0).DieFace >= 1);
        }
    }
}