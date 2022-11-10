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
            Assert.True(game.IsClosed);
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
            Assert.True(game.IsClosed);
        }


        [Fact]
        public void GameRollsElevenStrikeCloseTheGame()
        {
            // Arrange
            var game = new Game();

            // Act
            game.Rolls(new int[] { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 });

            // Assert
            Assert.True(game.IsClosed);
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
            Assert.True(game.IsClosed);
        }


        [Fact]
        public void GameRollsTooMuchPinsThrowErrors()
        {
            // Arrange
            var game = new Game();

            // act & assert
            Assert.Throws<Exception>(
                () => game.Rolls(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                   0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }));
        }


        [Fact]
        public void GameRollsPinsMoreThanAvailableThrowErrors()
        {
            // Arrange
            var game = new Game();

            // act & assert
            Assert.Throws<Exception>(
                () => game.Rolls(new int[] { 20 }));
        }
    }
}