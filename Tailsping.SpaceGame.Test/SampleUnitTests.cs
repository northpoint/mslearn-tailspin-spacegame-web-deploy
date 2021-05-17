using NUnit.Framework;
using System;

namespace Tailsping.SpaceGame.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldGameFunctionWithoutPlayers()
        {
            Assert.Pass("Should the game function without players in in");
        }

        [Test]
        public void ShouldPlayerWinIfCheating()
        {
            var rnd = new Random();

            var rndVal = rnd.Next(1, 100);

            Assert.IsTrue(rndVal > 50, "Flip a coin if a cheating player should win");
        }

        [Test]
        public void CanSupport10Players()
        {
            Assert.Pass("Should the game support 10 players at the same time");
        }
    }
}