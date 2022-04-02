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

            for (int j = 0; j < selectedPlayers.Count; j++)
            {
                selectedPlayers[j].PlayerTurn = true;
                int playerId = Player.NextPlayerTurn(selectedPlayers[j]);
                if(player.CheckPlayerIsAlive(selectedPlayers[j].PlayerId, selectedPlayers[j]))
                {
                    int ballId = ball.GetBallId();
                    ball.VanillaBallPotted(selectedPlayers[j], ballsOnTable[ballId], ballsOnTable[ballId].BallPotted, selectedPlayers[j].PlayerId);
                }
            }


        }

   
    }
}