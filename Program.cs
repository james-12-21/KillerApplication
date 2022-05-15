using System;

namespace KillerApp
{
    class Program
    {

        static void Main(string[] args)
        {
            var ballsOnTable = new List<Ball>() {
                    new Ball()    { BallId = 1 ,  BallColour = "Yellow"    , BallPotted = false}
                ,   new Ball()    { BallId = 2 ,  BallColour = "Blue"      , BallPotted = false}
                ,   new Ball()    { BallId = 3 ,  BallColour = "Red"       , BallPotted = false}
                ,   new Ball()    { BallId = 4 ,  BallColour = "Purple"    , BallPotted = false}
                ,   new Ball()    { BallId = 5 ,  BallColour = "Orange"    , BallPotted = false}
                ,   new Ball()    { BallId = 6 ,  BallColour = "Green"     , BallPotted = false}
                ,   new Ball()    { BallId = 7 ,  BallColour = "Brown"     , BallPotted = false}
                ,   new Ball()    { BallId = 8 ,  BallColour = "Black"     , BallPotted = false}
                ,   new Ball()    { BallId = 9 ,  BallColour = "Yellow"    , BallPotted = false}
                ,   new Ball()   { BallId = 10 , BallColour = "Blue"      , BallPotted = false}
                ,   new Ball()   { BallId = 11 , BallColour = "Red"       , BallPotted = false}
                ,   new Ball()   { BallId = 12 , BallColour = "Purple"    , BallPotted = false}
                ,   new Ball()   { BallId = 13 , BallColour = "Orange"    , BallPotted = false}
                ,   new Ball()   { BallId = 14 , BallColour = "Green"     , BallPotted = false}
                ,   new Ball()   { BallId = 15 , BallColour = "Brown"     , BallPotted = false}
                ,   new Ball()   { BallId = 16 , BallColour = "White"     , BallPotted = false}
            };

            var selectedPlayers = new List<Player>()
            {
                    new Player()  {PlayerId = 1, PlayerName = "James B"   , PlayerLives = 4}
                ,   new Player()  {PlayerId = 2, PlayerName = "Pete"      , PlayerLives = 4}
                ,   new Player()  {PlayerId = 3, PlayerName = "Caz"       , PlayerLives = 4}
                ,   new Player()  {PlayerId = 4, PlayerName = "Matthew"   , PlayerLives = 4}
                ,   new Player()  {PlayerId = 5, PlayerName = "Kieran"    , PlayerLives = 4}
                ,   new Player()  {PlayerId = 6, PlayerName = "James D"   , PlayerLives = 4}
            };
            var player = new Player();
            var ball = new Ball();
            var game = new Game();
            var result = new List<Player>();

            selectedPlayers[0].NumberOfBallsToPot = 1;

            game.PlayerTurn(selectedPlayers, result, player, ballsOnTable, ball, game);
        
        }
    }
}