using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_Football_team
{
    public class Goal
    {
        public int Minute { get; set; }
        public FootballPlayer Player { get; set; }

        public override string ToString()
        {
            return $"Goal scored by {Player.Name} at {Minute} minute";
        }
    }
}
