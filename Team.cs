using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_Football_team
{
    public class Team
    {
        private const int MinimumPlayers = 11;
        private const int MaximumPlayers = 22;

        public string Name { get; set; }
        public Coach Coach { get; set; }
        public FootballPlayer[] Players { get; set; }

        public double GetAverageAge()
        {
            int totalAge = 0;
            foreach (FootballPlayer player in Players)
            {
                totalAge += player.Age;
            }
            return (double)totalAge / Players.Length;
        }

        public void PrintPlayerDetails()
        {
            Console.WriteLine($"Players of {Name} team:");
            foreach (FootballPlayer player in Players)
            {
                Console.WriteLine($"{player.Name} - {player.Number}");
            }
        }
    }

}
