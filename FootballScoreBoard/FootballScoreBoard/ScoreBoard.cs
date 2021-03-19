using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballScoreBoard
{
    public class ScoreBoard
    {
        // List of all matches.
        public List<Match> Matches = new List<Match>();

        // Add new match to the sroce broad.
        public void AddMatch(Match match) 
        {
           
        }

        // Finish match.
        public void FinishMatch(Match match)
        {
            
        }

        // Update match score.
        public void UpdateScore(Match match, short homeTeamScore, short awayTeamScore)
        {
            
        }

        // Get a summary of games by total score (sorted).
        public List<Match> GetSummary()
        {
            return null;
        }
    }
}
