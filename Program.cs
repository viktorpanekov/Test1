using System;

namespace Homework_Football_team
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Goalkeeper goalkeeper1 = new Goalkeeper { Name = "Manuel Nuer", Age = 36, Number = 1, Height = 1.92 };
            Defender defender1 = new Defender { Name = "Upamecano", Age = 26, Number = 3, Height = 1.82 };
            Midfielder midfielder1 = new Midfielder { Name = "Leon Goretzka", Age = 30, Number = 6, Height = 1.81 };
            Striker striker1 = new Striker { Name = "Robert Lewandovski", Age = 33, Number = 9, Height = 1.84 };
            FootballPlayer[] team1Players = { goalkeeper1, defender1,midfielder1,striker1 };

            
            Goalkeeper goalkeeper2 = new Goalkeeper { Name = "David de Gea", Age = 31, Number = 1, Height = 1.90 };
            Defender defender2 = new Defender { Name = "Harry Maguire", Age = 26, Number = 4, Height = 1.89 };
            Midfielder midfielder2 = new Midfielder { Name = "Bruno Fernandes", Age = 27, Number = 8, Height = 1.80 };
            Striker striker2 = new Striker { Name = "Marcus Rashford", Age = 27, Number = 9, Height = 1.75 };
            FootballPlayer[] team2Players = { goalkeeper2,defender2,midfielder2, striker2 };

            
            Team team1 = new Team { Name = "Bayern Munich", Coach = new Coach { Name = "Pep Guardiola", Age = 40, Nationality = "Spanish" }, Players = team1Players };
            Team team2 = new Team { Name = "Manchester United", Coach = new Coach { Name = "Ten Hag", Age = 42, Nationality = "Dutch" }, Players = team2Players };

            
            Game game = new Game
            {
                Team1 = team1,
                Team2 = team2,
                Referee = new Referee { Name = "Michael Oliver", Age = 33 },
                AssistantReferees = new Person[]
                {
                new Person { Name = "Assistant Referee 1", Age = 29 },
                new Person { Name = "Assistant Referee 2", Age = 26 }
                },
                Goals = new Goal[]
                {
                new Goal { Minute = 17, Player = striker1 },
                 new Goal { Minute = 36, Player = midfielder1 },
                new Goal { Minute = 78, Player = striker2 }
                },
                Result = "2-1",
                Winner = team1
            };

            
            game.PrintResult();
            game.PrintGoalScorers();

            
            team1.PrintPlayerDetails();
            double averageAge = team2.GetAverageAge();
            Console.WriteLine($"Average age of players in {team2.Name} team: {averageAge}");

            team1.Coach.TrainTeam(team1);
            team2.Coach.TrainTeam(team2);

            game.Referee.GiveYellowCard(striker1);
            game.Referee.GiveRedCard(defender2);

            goalkeeper1.SaveGoal();
            striker2.ScoreGoal();
        }
    }
}
