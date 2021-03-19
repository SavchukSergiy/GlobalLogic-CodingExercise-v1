using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballScoreBoard
{
    public class Match
    {
        public int Id { get; set; }
        public HomeTeam HomeTeam { get; set; }
        public AwayTeam AwayTeam { get; set; }

        public int TotalScore = 0;

        public Match(int id, HomeTeam homeTeam, AwayTeam awayTeam)
        {
            Id = id;
            HomeTeam = homeTeam;
            AwayTeam = awayTeam;
        }

        // Get match score.
        public string GetScoreString()
        {
            string score = HomeTeam.TeamScore.ToString() + " : " + AwayTeam.TeamScore.ToString();

            return score;
        }

        // Calculate total score.
        public void CalculateTotalScore()
        {
            TotalScore = HomeTeam.TeamScore + AwayTeam.TeamScore;
        }
    }
}
