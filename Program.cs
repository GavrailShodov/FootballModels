using FootballModels;

        Striker player1 = new Striker { Name = "Player 1", Number = 10, Age = 25, Height = 180 };
        Striker player2 = new Striker { Name = "Player 2", Number = 7, Age = 27, Height = 175 };
        Striker player3 = new Striker { Name = "Player 3", Number = 6, Age = 30, Height = 175 };
        Midfield player4 = new Midfield { Name = "Player 4", Number = 8, Age = 25, Height = 175 };
        Midfield player5 = new Midfield { Name = "Player 5", Number = 4, Age = 26, Height = 175 };
        Midfield player6 = new Midfield { Name = "Player 6", Number = 3, Age = 36, Height = 175 };
        Midfield player7 = new Midfield { Name = "Player 7", Number = 2, Age = 22, Height = 175 };
        Defender player8 = new Defender { Name = "Player 8", Number = 11, Age = 20, Height = 175 };
        Defender player9 = new Defender { Name = "Player 9", Number = 22, Age = 21, Height = 175 };
        Defender player10 = new Defender { Name = "Player10", Number = 13, Age = 23, Height = 175 };
        Goalkeeper goalkeeper = new Goalkeeper { Name = "Goalkeeper", Number = 1, Age = 30, Height = 190 };
        
        Coach coach = new Coach { Name = "Coach", Age = 45 };
        Referee referee = new Referee { Name = "Referee", Age = 35 };

        Referee Asistant1 = new Referee { Name = "Referee", Age = 35 };
        Referee Asistant2 = new Referee { Name = "Referee", Age = 35 };

        
        Team team1 = new Team
        {
            Coach = coach,
            Players = new List<FootballPlayer>{ player1, player2, player3, player4, player5, player6, player7, player8, player9, player10,goalkeeper }
        };
        Team team2 = new Team
        {
            Coach = coach,
            Players = new List<FootballPlayer>{ player1, player2, player3, player4, player5, player6, player7, player8, player9, player10,goalkeeper }
        };  

        Game game = new Game
        {
            Team1 = team1,
            Team2 = team2,
            Referee = referee,
            AsistantReferees = new Referee[] {Asistant1,Asistant2},
            Goals = new string[] { "10th minute - Player 1", "25th minute - Player 2" },
            Result = "2-1",
            Winner = "Team 1"
        };
        

        Console.WriteLine("Game Result: " + game.Result);
        Console.WriteLine("Winner: " + game.Winner);
        Console.WriteLine("Average Age of Team 1: " + team1.AvarageAge);
    