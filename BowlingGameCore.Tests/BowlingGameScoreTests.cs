namespace BowlingGameCore.Tests
{
    public class BowlingGameScoreests
    {
        [Fact]
        public void RollsAllZeroReturnsZero()
        {
            // Arrange
            Game game = new Game();
            game.Rolls(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 });

            // Act
            var curerntScrore = game.Score();


            // Assert 
            Assert.Equal(0, curerntScrore);
        }
    }
}