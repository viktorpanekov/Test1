using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_Football_team
{
    public class FootballPlayer :Person
    {
        private int number;
        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The number of a football player cannot be null or negative,please enter a correct one! ");
                }
                number = value;
            }
        }
        private double height;
        public double Height 
        {
            get
            {
                return height;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The height of a football player cannot be null or negative,please enter a correct one! ");
                }
                height = value;
            }
        }
        public bool IsInjured { get; set; }

        public void ScoreGoal()
        {
            Console.WriteLine($"{Name} scored a goal!");
        }
    }
}
