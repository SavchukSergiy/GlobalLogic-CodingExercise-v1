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
        public List<Match> CurrentMatches = new List<Match>();

        // List of all finished matches with total score.
        public List<Match> FinishedMatches = new List<Match>();

        // Add new match to the sroce broad.
        public void AddMatch(Match match) 
        {
            if (match != null)
                CurrentMatches.Add(match);
        }

        // Finish match.
        public void FinishMatch(Match match)
        {
            if (match != null)
            {
                FinishedMatches.Add(match);
                CurrentMatches.Remove(match);
            }
        }

        // Finish match.
        public void FinishMatch(int id)
        {
            var match = CurrentMatches.Find(item => item.Id == id);
            CurrentMatches.Remove(match);
            FinishedMatches.Add(match);

            //foreach (var item in CurrentMatches)
            //{
            //    if (item.Id == id)
            //    {
            //        CurrentMatches.Remove(item);
            //        FinishedMatches.Add(item);
            //    }
            //}
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
