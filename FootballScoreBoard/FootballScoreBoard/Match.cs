using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballScoreBoard
{
    public class Match
    {
        Team HomeTeam { get; set; }
        Team AwayTeam { get; set; }

        short HomeTeamScore { get; set; }
        short AwayTeamScore{get;set;}

        public Match(Team homeTeam, Team awayTeam,  short homeTeamScore = 0, short awayTeamScore = 0)
        {
            HomeTeam = homeTeam;
            AwayTeam = awayTeam;
        }
    }
}
