using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_Football_team
{
    public class Goalkeeper : FootballPlayer
    {
        public int GoalsSaved { get; set; }

        public void SaveGoal()
        {
            Console.WriteLine($"{Name} saved a goal!");
            GoalsSaved++;
        }
    }
}
