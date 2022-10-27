namespace Bowling.Tests
{
    public class UnitTest
    {
        [Fact]
        public void WhenRollZeroOnlyReturnsZero()
        {
            // Arrange
            var game = new Game();
            game.Roll(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 });
            var expectedScore = 0;

            // Act
            var actualScore = game.Score();

            // Assert
            Assert.Equal(expectedScore, actualScore);
        }

        [Fact]
        public void WhenRollStrikeOnlyReturnsThreeHundred()
        {
            // Arrange
            var game = new Game();
            game.Roll(new int[] { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 });
            var expectedScore = 300;

            // Act
            var actualScore = game.Score();

            // Assert
            Assert.Equal(expectedScore, actualScore);
        }

        [Fact]
        public void WhenRollSpareOnlyReturnsDontKnow()
        {
            // Arrange
            var game = new Game();
            game.Roll(new int[] { 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 });
            var expectedScore = 150;

            // Act
            var actualScore = game.Score();

            // Assert
            Assert.Equal(expectedScore, actualScore);
        }

        [Fact]
        public void WhenRollZeroAndSpareInTheEndReturnsDontKnow()
        {
            // Arrange
            var game = new Game();
            game.Roll(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 10, 10 });
            var expectedScore = 300;

            // Act
            var actualScore = game.Score();

            // Assert
            Assert.Equal(expectedScore, actualScore);
        }
        [Fact]
        public void WhenRollSpareAndZerosOnlyReturnsZero()
        {
            var enAe = new System.Globalization.CultureInfo("en-AE");
            // Arrange
            var game = new Game();
            game.Roll(new int[] { 5, 5, 3, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 });
            var expectedScore = 20;

            // Act
            var actualScore = game.Score();

            // Assert
            Assert.Equal(expectedScore, actualScore);
        }
    }
}