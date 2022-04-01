using System;

namespace KillerApp
{
    class Program
    {

        static void Main(string[] args)
        {
            var ballsOnTable = new List<Ball>() {
                    new Ball(1, "Yellow", false)    { BallId = 1 , BallColour = "Yellow" , BallPotted = false }
                ,   new Ball(2, "Blue", false)      { BallId = 2 , BallColour = "Blue", BallPotted = false}
                ,   new Ball(3, "Red", false)       { BallId = 3 , BallColour = "Red" , BallPotted = false}
                ,   new Ball(4, "Purple", false)    { BallId = 4 , BallColour = "Purple", BallPotted = false}
                ,   new Ball(5, "Orange", false)    { BallId = 5 , BallColour = "Orange", BallPotted = false}
                ,   new Ball(6, "Green", false)     { BallId = 6 , BallColour = "Green", BallPotted = false}
                ,   new Ball(7, "Brown", false)     { BallId = 7 , BallColour = "Brown", BallPotted = false}
                ,   new Ball(8, "Black", false)     { BallId = 8 , BallColour = "Black", BallPotted = false}
                ,   new Ball(9, "Yellow", false)    { BallId = 9 , BallColour = "Yellow", BallPotted = false}
                ,   new Ball(10, "Blue", false)     { BallId = 10 , BallColour = "Blue", BallPotted = false}
                ,   new Ball(11, "Red", false)      { BallId = 11 , BallColour = "Red", BallPotted = false}
                ,   new Ball(12, "Purple", false)   { BallId = 12 , BallColour = "Purple", BallPotted = false}
                ,   new Ball(13, "Orange", false)   { BallId = 13 , BallColour = "Orange", BallPotted = false}
                ,   new Ball(14, "Green", false)    { BallId = 14 , BallColour = "Green", BallPotted = false}
                ,   new Ball(15, "Brown", false)    { BallId = 15 , BallColour = "Brown", BallPotted = false}
            };

            var selectedPlayers = new List<Player>()
            {
                    new Player(1,"James B", 4) {PlayerId = 1, PlayerName = "James B", PlayerLives = 4}
                ,   new Player(2,"Pete", 4) {PlayerId = 2, PlayerName = "Pete", PlayerLives = 4}
                ,   new Player(3,"Caz", 4) {PlayerId = 3, PlayerName = "Caz", PlayerLives = 4}
                ,   new Player(4,"Matthew", 4) {PlayerId = 4, PlayerName = "Matthew", PlayerLives = 4}
                ,   new Player(5,"Kieran", 4) {PlayerId = 5, PlayerName = "Kieran", PlayerLives = 4}
                ,   new Player(6,"James D", 4) {PlayerId = 6, PlayerName = "James D", PlayerLives = 4}
            };

            int alivePlayers = 0;

            if (selectedPlayers.Count <= 0)
            {
                Console.WriteLine("There are no players selected!!! Please enter a minimum of 6 players");
            }
            else if (selectedPlayers.Count > 0 && selectedPlayers.Count < 6)
            {
                Console.WriteLine("There are not enough players for a valid game!!!");
                Console.WriteLine("Try another game like see-saw, 9-ball or Accumulation Stations");
            }
            else
            {
                for (int i = 0; i < selectedPlayers.Count; i++)
                {
                    if (selectedPlayers[i].PlayerLives > 0)
                    {
                        alivePlayers++;
                    }

                }

            }

            while (alivePlayers > 1)
            {
                int playerTurnCounter = 0;
                Console.Write($"{selectedPlayers[playerTurnCounter].PlayerName} " +
                    $"has {selectedPlayers[playerTurnCounter].PlayerLives} lives remaining. "
                    + $"{selectedPlayers[playerTurnCounter].PlayerName} to play");
                Console.WriteLine("Press y if ball potted, any other key for a missed shot");
                string ballPottedChecker = Console.ReadLine();
                NextShot(ballPottedChecker, selectedPlayers, playerTurnCounter);
                Console.WriteLine("Enter number of the ball potted: "); 
                int ballId = Convert.ToInt32(Console.ReadLine());
                BallPotted(ballId, ballsOnTable);

                static void NextShot(string ballPottedChecker, List<Player> selectedPlayers, int playerTurnCounter)
                {
                    if (ballPottedChecker == "y")
                    {
                        playerTurnCounter++;
                        return;
                    }
                    else
                    {
                        selectedPlayers[playerTurnCounter].PlayerLives--;
                    }
                }
            
                static void BallPotted(int ballId, List<Ball> ballsOnTable)
                {
                    if (ballsOnTable.Count == 0)
                    {
                        Console.WriteLine("Error: variable ballsOnTable is empty");
                    }
                    else if (ballsOnTable.Count > 15)
                    {
                        Console.WriteLine("Error: variable ballsOnTable has too many balls in it");
                    }
                    else if (ballsOnTable[ballId - 1].BallPotted)
                    {
                        Console.WriteLine($"Ball {ballId} has already been potted");
                    }
                    else if(ballId < 1 || ballId > 15)
                    {
                        Console.WriteLine("Please enter a valid ball number");
                    }
                    else
                    {
                        ballsOnTable[ballId - 1].BallPotted = true;
                    }
                }
            }
                
        }

   
    }
}