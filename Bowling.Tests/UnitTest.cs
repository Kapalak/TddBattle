namespace Bowling.Tests
{
    public class UnitTest
    {

        [Fact]
        public void GameScoreThrowsNotImplementedException()
        {
            // Arrange
            var game = new Game();
            game.Roll(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 });
            var expectedScore = 0;

            // Act & Assert
            var ex = Assert.Throws<NotImplementedException>(() => game.Score());
        }
    }
}