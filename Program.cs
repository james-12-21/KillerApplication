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
                ,   new Ball(16, "White", 'n')    { BallId = 16 , BallColour = "White", BallPotted = 'n'}
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
            var game = new Game();
            var result = new List<Player>();

            selectedPlayers[0].PlayerTurn = true;
            for (int j = 0; j < selectedPlayers.Count; j++)
            {
                Console.WriteLine(selectedPlayers[j].PlayerName);
                Console.WriteLine(selectedPlayers[j].PlayerLives);
                Player.NextPlayerTurn(selectedPlayers[j]);
                if (selectedPlayers[j].PlayerTurn)
                {
                    if (player.CheckPlayerIsAlive(selectedPlayers[j].PlayerId, selectedPlayers[j]))
                    {
                        Console.WriteLine("Press 'y' if a ball is successfully potted, 'n' for a missed shot");
                        char ballPotted = Convert.ToChar(Console.ReadLine());
                        int ballId = ball.GetBallId(ballPotted);

                        
                        
                        if (ballId == 1)
                        {
                            Ball.OneBallPotted(selectedPlayers, ballsOnTable[ballId], ballPotted, selectedPlayers[j].PlayerId);
                        }
                        else if (ballId == 2)
                        {
                            Ball.VanillaBallPotted(selectedPlayers, ballsOnTable[ballId], ballPotted, selectedPlayers[j].PlayerId);
                        }
                        else if (ballId == 8)
                        {
                            Ball.EightBallPotted(selectedPlayers, ballsOnTable[ballId], ballPotted, selectedPlayers[j].PlayerId);
                        }
                        else if (ballId == 9)
                        {
                            Ball.NineBallPotted(selectedPlayers, ballsOnTable[ballId], ballPotted, selectedPlayers[j].PlayerId);
                        }
                        else if (ballId == 13)
                        {
                            Ball.VanillaBallPotted(selectedPlayers, ballsOnTable[ballId], ballPotted, selectedPlayers[j].PlayerId);
                        }
                        else if (ballId == 16)
                        {
                            Ball.VanillaBallPotted(selectedPlayers, ballsOnTable[ballId], ballPotted, selectedPlayers[j].PlayerId);
                        }
                        else if (0 < ballId && ballId < 16 && ballId != 1 && ballId != 2 && ballId != 8 && ballId != 9 && ballId != 13)
                        {
                            Ball.VanillaBallPotted(selectedPlayers, ballsOnTable[ballId], ballPotted, selectedPlayers[j].PlayerId);
                        }
                        


                    }
                }
                else
                {

                }

                if (selectedPlayers[j].PlayerLives == 0)
                {
                    result.Add(selectedPlayers[j]);
                    selectedPlayers.RemoveAt(j);
                    j--;
                }

                game.BallsOnTable(ballsOnTable);
                
                if (game.ActiveGameChecker(selectedPlayers))
                {
                    if (j == selectedPlayers.Count - 1)
                    {
                        j = -1;
                    }
                    else
                    {

                    }
                }
                else
                {
                    if(j == 0 && selectedPlayers.Count == 1)
                    {
                        
                    }
                    else if (j == selectedPlayers.Count - 1)
                    { 
                        j--;
                    }
                    else
                    {
                        j++;
                    }

                    result.Add(selectedPlayers[j]);

                    for (int n = 0; n < result.Count; n++)
                    {
                        Console.WriteLine($"{result[n].PlayerName} finished {result.Count - n}");
                    }

                    goto GameOver;
                }
                
            }

        GameOver: Console.WriteLine($"The game has ended! {result[result.Count - 1].PlayerName} wins!");

        
        }
    }
}