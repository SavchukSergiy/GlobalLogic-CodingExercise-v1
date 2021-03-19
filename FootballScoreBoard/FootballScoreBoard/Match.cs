using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballScoreBoard
{
    public class Match
    {
        HomeTeam HomeTeam { get; set; }
        AwayTeam AwayTeam { get; set; }

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
