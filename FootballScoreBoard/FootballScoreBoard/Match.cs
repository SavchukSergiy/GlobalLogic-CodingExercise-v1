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

        public Match(HomeTeam homeTeam, AwayTeam awayTeam)
        {
            HomeTeam = homeTeam;
            AwayTeam = awayTeam;
        }
    }
}
