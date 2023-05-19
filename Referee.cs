using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_Football_team
{
    public class Referee : Person 
    {
        public int YellowCardsGiven { get; set; }
        public int RedCardsGiven { get; set; }

        public void GiveYellowCard(FootballPlayer player)
        {
            Console.WriteLine($"{Name} gives a yellow card to {player.Name}.");
            YellowCardsGiven++;
        }

        public void GiveRedCard(FootballPlayer player)
        {
            Console.WriteLine($"{Name} gives a red card to {player.Name}.");
            RedCardsGiven++;
        }
    }
}
