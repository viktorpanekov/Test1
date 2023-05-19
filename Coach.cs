using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_Football_team
{
    public class Coach : Person 
    {
        public string Nationality { get; set; }

        public void TrainTeam(Team team)
        {
            Console.WriteLine($"{Name} is training {team.Name} team.");
        }
    }
}
