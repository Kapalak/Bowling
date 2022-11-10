namespace BowlingGameCore.Tests
{
    public class BowlingGameRollsTests
    {
        [Fact]
        public void GameRollsTwentyZeroPinsCloseTheGame()
        {
            // Arrange
            var game = new Game();

            // Act
            game.Rolls(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                   0, 0, 0, 0, 0, 0, 0, 0, 0, 0  });

            // Assert
            Assert.Equal(true, game.IsClosed);
        }


        [Fact]
        public void GameRollsZeroPinsWithStrikeCloseTheGame()
        {
            // Arrange
            var game = new Game();

            // Act
            game.Rolls(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                   0, 0, 0, 0, 0, 0, 0, 0, 0, 10, 0 });

            // Assert
            Assert.Equal(true, game.IsClosed);
        }


        [Fact]
        public void GameRollsZeroPinsWithSpareCloseTheGame()
        {
            // Arrange
            var game = new Game();

            // Act
            game.Rolls(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                   0, 0, 0, 0, 0, 0, 0, 0, 5, 5, 0 });

            // Assert
            Assert.Equal(true, game.IsClosed);
        }
    }
}