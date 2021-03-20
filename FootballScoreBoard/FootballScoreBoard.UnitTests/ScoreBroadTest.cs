using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FootballScoreBoard.UnitTests
{
    [TestClass]
    public class ScoreBroadTest
    {
        ScoreBoard Board;
        TeamInMatch HomeT;
        TeamInMatch AwayT;
        Match NewMatch;
        private void createStartData()
        {
            Board = new ScoreBoard();
            HomeT = new TeamInMatch { Name = "team1", Country = "Ukraine", Ñoach = "Cool man", TeamScore = 0 };
            AwayT = new TeamInMatch { Name = "team2", Country = "USA", Ñoach = "Cool man2", TeamScore = 0 };

            NewMatch = new Match(1, HomeT, AwayT);
            Board.AddMatch(NewMatch);

        }

        [TestMethod]
        public void AddMatch_Match_AddToList()
        {
            // Arrange
            createStartData();

            // Act
            //Board.AddMatch(NewMatch);

            // Assert
            Assert.IsNotNull(Board.GetCurrentMatches());
        }


        [TestMethod]
        public void UpdateMatch_Match_Update()
        {
            // Arrange
            createStartData();

            // Act
            var currentM = Board.GetCurrentMatches();
            var match = currentM.Find(item => item.Id == 1);
            short oldHomeTeamScore = match.HomeTeam.TeamScore;

            Board.UpdateScore(1, 5, 2);

            short newHomeTeamScore = match.HomeTeam.TeamScore;

            // Assert
            Assert.AreNotEqual(oldHomeTeamScore, newHomeTeamScore);
        }

        [TestMethod]
        public void FinishMatch_Match_Finish()
        {
            // Arrange
            createStartData();

            // Act
            Board.FinishMatch(1);

            // Assert
            var currentM = Board.GetCurrentMatches();
            
            Assert.IsNull(currentM.Find(item => item.Id == 1));
        }
    }
}
