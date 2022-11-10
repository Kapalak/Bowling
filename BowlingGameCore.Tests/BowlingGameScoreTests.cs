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

        [Fact]
        public void RollsAllstrikeReturnsThreeHundred()
        {
            // Arrange
            Game game = new Game();
            game.Rolls(new int[] { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 });

            // Act
            var curerntScrore = game.Score();


            // Assert 
            Assert.Equal(300, curerntScrore);
        }
        [Fact]
        public void RollsNostrikeReturns_50()
        {
            // Arrange
            Game game = new Game();
            game.Rolls(new int[] { 0,5,5,0,0,5,5,0,0,5,5,0,0,5,5,0,0,5,5,0});


            // Act
            var curerntScrore = game.Score();


            // Assert 
            Assert.Equal(50, curerntScrore);
        }
        [Fact]
        public void RollsSparesReturns_150()
        {
            // Arrange
            Game game = new Game();
            game.Rolls(new int[] { 5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5});


            // Act
            var curerntScrore = game.Score();


            // Assert 
            Assert.Equal(150, curerntScrore);
        }
    }
}