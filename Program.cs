using System;

namespace KillerApp
{
    class Program
    {

        static void Main(string[] args)
        {
            var ballsOnTable = new List<Ball>() {
                    new Ball(1, "Yellow", 'n')    { BallId = 1 , BallColour = "Yellow" , BallPotted = 'n' }
                ,   new Ball(2, "Blue", 'n')      { BallId = 2 , BallColour = "Blue", BallPotted = 'n'}
                ,   new Ball(3, "Red", 'n')       { BallId = 3 , BallColour = "Red" , BallPotted = 'n'}
                ,   new Ball(4, "Purple", 'n')    { BallId = 4 , BallColour = "Purple", BallPotted = 'n'}
                ,   new Ball(5, "Orange", 'n')    { BallId = 5 , BallColour = "Orange", BallPotted = 'n'}
                ,   new Ball(6, "Green", 'n')     { BallId = 6 , BallColour = "Green", BallPotted = 'n'}
                ,   new Ball(7, "Brown", 'n')     { BallId = 7 , BallColour = "Brown", BallPotted = 'n'}
                ,   new Ball(8, "Black", 'n')     { BallId = 8 , BallColour = "Black", BallPotted = 'n'}
                ,   new Ball(9, "Yellow", 'n')    { BallId = 9 , BallColour = "Yellow", BallPotted = 'n'}
                ,   new Ball(10, "Blue", 'n')     { BallId = 10 , BallColour = "Blue", BallPotted = 'n'}
                ,   new Ball(11, "Red", 'n')      { BallId = 11 , BallColour = "Red", BallPotted = 'n'}
                ,   new Ball(12, "Purple", 'n')   { BallId = 12 , BallColour = "Purple", BallPotted = 'n'}
                ,   new Ball(13, "Orange", 'n')   { BallId = 13 , BallColour = "Orange", BallPotted = 'n'}
                ,   new Ball(14, "Green", 'n')    { BallId = 14 , BallColour = "Green", BallPotted = 'n'}
                ,   new Ball(15, "Brown", 'n')    { BallId = 15 , BallColour = "Brown", BallPotted = 'n'}
            };

            var selectedPlayers = new List<Player>()
            {
                    new Player(1,"James B", 4)  {PlayerId = 1, PlayerName = "James B"   , PlayerLives = 4}
                ,   new Player(2,"Pete", 4)     {PlayerId = 2, PlayerName = "Pete"      , PlayerLives = 4}
                ,   new Player(3,"Caz", 4)      {PlayerId = 3, PlayerName = "Caz"       , PlayerLives = 4}
                ,   new Player(4,"Matthew", 4)  {PlayerId = 4, PlayerName = "Matthew"   , PlayerLives = 4}
                ,   new Player(5,"Kieran", 4)   {PlayerId = 5, PlayerName = "Kieran"    , PlayerLives = 4}
                ,   new Player(6,"James D", 4)  {PlayerId = 6, PlayerName = "James D"   , PlayerLives = 4}
            };
            var player = new Player();
            var ball = new Ball();

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

            
            for (int j = 0; j < selectedPlayers.Count; j++)
            {
                selectedPlayers[j].PlayerTurn = true;
                Console.WriteLine(selectedPlayers[j].PlayerName);
                Console.WriteLine();
                Console.WriteLine(selectedPlayers[j].PlayerLives);
                Console.WriteLine();
                Console.WriteLine(selectedPlayers[j + 1].PlayerName);
                Console.WriteLine();
                Console.WriteLine(selectedPlayers[j + 1].PlayerLives);
                int playerId = Player.NextPlayerTurn(selectedPlayers[j]);
                if(player.CheckPlayerIsAlive(selectedPlayers[j].PlayerId, selectedPlayers[j]))
                {
                    int ballId = ball.GetBallId();
                    ball.VanillaBallPotted(selectedPlayers[playerId], ballsOnTable[ballId], ballsOnTable[ballId].BallPotted, selectedPlayers[j].PlayerId);
                }
            }
            
                
        }

   
    }
}