using Connect4Game;
using NUnit.Framework;

namespace Connect4Tests
{
    public class Connect4Tests
    {
        private Connect4 game;

        [SetUp]
        public void Setup()
        {
            game = new();
        }

        [Test]
        public void Play_PlayerOneJustPlayed_ReturnItIsPlayerTwoTurn()
        {
            var result = game.Play(0);


            Assert.That(result, Is.EqualTo("It's player 2 turn"));
        }

        [Test]
        public void Play_PlayerTwoJustPlayed_ReturnItIsPlayerOneTurn()
        {
            game.Play(0);
            var result = game.Play(0);

            Assert.That(result, Is.EqualTo("It's player 1 turn"));
        }

        [Test]
        public void Play_ThereAreAlreadySixDiscsInTheSelectedColumn_ReturnColumnIsFull()
        {
            game.Play(0);
            game.Play(0);
            game.Play(0);
            game.Play(0);
            game.Play(0);
            game.Play(0);
            var result = game.Play(0);

            Assert.That(result, Is.EqualTo("Column full"));
        }
    }
}