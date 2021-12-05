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

        [Test]
        public void Play_PlayerOneWonVertically_ReturnPlayerOneWon()
        {
            game.Play(0); // 1
            game.Play(1); // 2
            game.Play(0); // 1
            game.Play(1); // 2
            game.Play(0); // 1
            game.Play(1); // 2
            var result = game.Play(0); // 1

            Assert.That(result, Is.EqualTo("Player 1 won"));
        }

        [Test]
        public void Play_PlayerTwoWonVertically_ReturnPlayerTwoWon()
        {
            game.Play(0); // 1
            game.Play(1); // 2
            game.Play(0); // 1
            game.Play(1); // 2
            game.Play(0); // 1
            game.Play(1); // 2
            game.Play(3); // 1
            var result = game.Play(1); // 2

            Assert.That(result, Is.EqualTo("Player 2 won"));
        }

        [Test]
        public void Play_PlayerOneWonHorizontally_ReturnPlayerOneWon()
        {
            game.Play(0); // 1
            game.Play(0); // 2
            game.Play(1); // 1
            game.Play(1); // 2
            game.Play(2); // 1
            game.Play(2); // 2
            var result = game.Play(3); // 1

            Assert.That(result, Is.EqualTo("Player 1 won"));
        }

        [Test]
        public void Play_PlayerTwoWonHorizontally_ReturnPlayerTwoWon()
        {
            game.Play(0); // 1
            game.Play(1); // 2
            game.Play(1); // 1
            game.Play(2); // 2
            game.Play(2); // 1
            game.Play(3); // 2
            game.Play(3); // 1
            var result = game.Play(4); // 2

            Assert.That(result, Is.EqualTo("Player 2 won"));
        }

        [Test]
        public void Play_PlayerOneWonAtSomeBottomDownwardDiagonalDiscs_ReturnPlayerOneWon()
        {
            game.Play(6); // 1
            game.Play(0); // 2
            game.Play(0); // 1
            game.Play(0); // 2
            game.Play(0); // 1
            game.Play(1); // 2
            game.Play(1); // 1
            game.Play(2); // 2
            game.Play(1); // 1
            game.Play(4); // 2
            game.Play(2); // 1
            game.Play(4); // 2
            var result = game.Play(3); // 1

            Assert.That(result, Is.EqualTo("Player 1 won"));
        }

        [Test]
        public void Play_PlayerTwoWonAtSomeBottomDownwardDiagonalDiscs_ReturnPlayerTwoWon()
        {
            game.Play(0); // 1
            game.Play(0); // 2
            game.Play(0); // 1
            game.Play(0); // 2
            game.Play(1); // 1
            game.Play(1); // 2
            game.Play(2); // 1
            game.Play(1); // 2
            game.Play(4); // 1
            game.Play(2); // 2
            game.Play(4); // 1
            var result = game.Play(3); // 2

            Assert.That(result, Is.EqualTo("Player 2 won"));
        }

        [Test]
        public void Play_PlayerOneWonAtSomeTopDownwardDiagonalDiscs_ReturnPlayerOneWon()
        {
            game.Play(2); // 1
            game.Play(2); // 2
            game.Play(2); // 1
            game.Play(2); // 2
            game.Play(2); // 1
            game.Play(3); // 2
            game.Play(4); // 1
            game.Play(5); // 2
            game.Play(5); // 1
            game.Play(4); // 2
            game.Play(4); // 1
            game.Play(3); // 2
            game.Play(3); // 1
            game.Play(0); // 2
            var result = game.Play(3); // 1

            Assert.That(result, Is.EqualTo("Player 1 won"));
        }

        [Test]
        public void Play_PlayerTwoWonAtSomeTopDownwardDiagonalDiscs_ReturnPlayerTwoWon()
        {
            game.Play(6); // 1
            game.Play(2); // 2
            game.Play(2); // 1
            game.Play(2); // 2
            game.Play(2); // 1
            game.Play(2); // 2
            game.Play(3); // 1
            game.Play(4); // 2
            game.Play(5); // 1
            game.Play(5); // 2
            game.Play(4); // 1
            game.Play(4); // 2
            game.Play(3); // 1
            game.Play(3); // 2
            game.Play(0); // 1
            var result = game.Play(3); // 2

            Assert.That(result, Is.EqualTo("Player 2 won"));
        }
    }
}
