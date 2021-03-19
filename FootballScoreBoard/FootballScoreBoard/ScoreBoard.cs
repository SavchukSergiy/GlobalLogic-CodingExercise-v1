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
        private List<Match> CurrentMatches = new List<Match>();

        // List of all finished matches with total score.
        private List<Match> FinishedMatches = new List<Match>();


        // Add new match to the sroce broad.
        public void AddMatch(Match match) 
        {
            if (match != null)
                CurrentMatches.Add(match);
        }


        // Finish match by Id.
        public void FinishMatch(int id)
        {
            // Find match in list by id.
            var match = CurrentMatches.Find(item => item.Id == id);

            if (match != null)
            {
                match.CalculateTotalScore();
                FinishedMatches.Add(match);
                CurrentMatches.Remove(match);
            }
        }


        // Update match score.
        public void UpdateScore(int matchId, short homeTeamScore, short awayTeamScore)
        {  
                foreach (var item in CurrentMatches)
                {
                    if (item.Id == matchId)
                    {
                        item.HomeTeam.TeamScore = homeTeamScore;
                        item.AwayTeam.TeamScore = awayTeamScore;
                    }
                }  
        }

        // Get a current matches.
        public List<Match> GetCurrentMatches()
        {
            return CurrentMatches;
        }

        // Get a summary of games by total score.
        public List<Match> GetSummary()
        {
            var summery = from m in FinishedMatches
                             orderby m.TotalScore descending
                             select m;

            return summery.ToList();
        }
    }
}
