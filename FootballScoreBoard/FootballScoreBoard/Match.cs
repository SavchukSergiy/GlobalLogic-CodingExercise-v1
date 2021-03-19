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

        public bool IsFinished { get; set; }

        public int TotalScore = 0;

        public Match(HomeTeam homeTeam, AwayTeam awayTeam)
        {
            HomeTeam = homeTeam;
            AwayTeam = awayTeam;
        }

        // Get match score
        public string GetScore()
        {
            string score = HomeTeam.TeamScore.ToString() + " : " + AwayTeam.TeamScore.ToString();

            return score;
        }
    }
}
