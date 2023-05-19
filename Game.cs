using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_Football_team
{
    public class Game
    {
        private Team team1;
        private Team team2;
        private Referee referee;
        private Person[] assistantReferees;
        private Goal[] goals;
        private string result;
        private Team winner;

        public Team Team1
        {
            get { return team1; }
            set { team1 = value ?? throw new ArgumentNullException(nameof(Team1), "Team1 cannot be null."); }
        }

        public Team Team2
        {
            get { return team2; }
            set { team2 = value ?? throw new ArgumentNullException(nameof(Team2), "Team2 cannot be null."); }
        }

        public Referee Referee
        {
            get { return referee; }
            set { referee = value ?? throw new ArgumentNullException(nameof(Referee), "Referee cannot be null."); }
        }

        public Person[] AssistantReferees
        {
            get { return assistantReferees; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException(nameof(AssistantReferees), "AssistantReferees array cannot be null.");

                if (value.Length != 2)
                    throw new ArgumentException("Exactly two assistant referees are required.");

                assistantReferees = value;
            }
        }

        public Goal[] Goals
        {
            get { return goals; }
            set { goals = value ?? throw new ArgumentNullException(nameof(Goals), "Goals array cannot be null."); }
        }

        public string Result
        {
            get { return result; }
            set { result = value ?? throw new ArgumentNullException(nameof(Result), "Result cannot be null."); }
        }

        public Team Winner
        {
            get { return winner; }
            set { winner = value ?? throw new ArgumentNullException(nameof(Winner), "Winner cannot be null."); }
        }

        public void PrintResult()
        {
            Console.WriteLine("Result: " + Result);
        }

        public void PrintGoalScorers()
        {
            Console.WriteLine("Goal Scorers:");
            foreach (Goal goal in Goals)
            {
                Console.WriteLine(goal);
            }
        }
    }
}
