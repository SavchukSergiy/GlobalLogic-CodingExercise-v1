using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FootballScoreBoard.UnitTests
{
    [TestClass]
    public class ScoreBroadTest
    {
        [TestMethod]
        public void AddMatch_Match_AddToList()
        {
            // Arrange
            var board = new ScoreBoard();
            var homeTeam = new HomeTeam { Name = "team1", Country = "Ukraine", Ñoach = "Cool man", TeamScore = 0 };
            var awayTeam = new AwayTeam { Name = "team2", Country = "USA", Ñoach = "Cool man2", TeamScore = 0 };

            var match = new Match(1, homeTeam, awayTeam);

            // Act

            board.AddMatch(match);

            // Assert
            Assert.IsNotNull(board.GetCurrentMatches());
        }
    }
}
