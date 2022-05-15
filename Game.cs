using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerApp
{
    public class Game
    {
        internal int NumberOfPlayersAlive { get; private set; }
        internal int NumberOfBallsOnTheTable { get; private set; }
        internal bool WasShotAFruit { get; private set; }
        internal bool WasShotALifeBack { get; private set; }
        internal int NumberOfShotsToTake { get; private set; }
        public Game() 
        {

        }

        public int CountOfPlayersAlive(List<Player> players)
        {
            int numberOfPlayersAlive = 0;
            for(int i = 0; i < players.Count; i++)
            {
                if(players[i].PlayerLives == 0)
                {

                }
                else
                {
                    numberOfPlayersAlive++;
                }
            }
            return numberOfPlayersAlive;
        }
        public bool ActiveGameChecker(List<Player> players, Game game)
        {
            if(game.CountOfPlayersAlive(players) > 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int CountOfBallsOnTable(List<Ball> balls)
        {
            int numberOfBallsPotted = 0;
            for (int i = 0;i < balls.Count;i++)
            {
                if(balls[i].BallPotted == false)
                {
                    
                }
                else
                {
                    numberOfBallsPotted++;
                }
            }
            return numberOfBallsPotted;
        }
        public void NewFrame(Game game, List<Ball> balls, List<Player> players, Player player)
        {
            if(game.CountOfBallsOnTable(balls) >= 2)
            {
                
                game.NumberOfShotsToTake = 1;
            }
            else
            {
                Console.WriteLine("A new frame is about to start");
                for (int i = 0; i < balls.Count ; i++)
                {
                    balls[i].BallPotted = false;
                }
                game.NumberOfShotsToTake = 2;
            }
        }
        public bool NextPlayerTurn(List<Player> players, int playerIndex)
        {
            if(players[playerIndex].NumberOfBallsToPot == 0)
            {
                players[playerIndex].PlayerTurn = false;
                return true;
            }    
            else
            {
                return false;
            }
        }

        public void EndOfTurn(List<Player> players, int playerIndex)
        {
            players[playerIndex].PlayerTurn = false;
            players[playerIndex + 1].PlayerTurn = true;
        }

        public int PlayerIndexManager(List<Player> players, int playerIndex)
        {
            if(playerIndex == players.Count - 1)
            {
                return -1;
            }
            else
            {
                return playerIndex;
            }
        }

        public void PlayerTurn(List<Player> players, List<Player> result, Player player, List<Ball> balls, Ball ball, Game game)
        {
            for (int playerIndex = 0; playerIndex < players.Count; playerIndex++)
            {
                while (players[playerIndex].NumberOfBallsToPot > 0)
                {
                    players[playerIndex].PlayerTurn = true;
                    Console.WriteLine($"Now {players[playerIndex].PlayerName}'s turn");
                    enterBallId: Console.WriteLine("If a ball is potted, please enter the number. Any other key for a missed shot");
                    int ballPottedResponse = Convert.ToInt32(Console.ReadLine()) - 1;
                    if (ball.IsBallPotted(balls, ballPottedResponse))
                    {
                        Console.WriteLine($"Ball: {ballPottedResponse} has already been potted, please enter in a valid ball");
                        goto enterBallId;
                    }
                    else if (ballPottedResponse < 0 || ballPottedResponse > 15)
                    {
                        players[playerIndex].PlayerLives--;
                        if (player.CheckPlayerIsAlive(players, playerIndex))
                        {
                            EndOfTurn(players, playerIndex);
                        }
                    }
                    else if (ballPottedResponse == 1)
                    {
                        ball.OneBallPotted(players, balls, ball, game, ballPottedResponse, playerIndex);
                    }
                    else if (ballPottedResponse == 2)
                    {
                        ball.VanillaBallPotted(players, balls, ball, game, ballPottedResponse, playerIndex);
                    }
                    else if (ballPottedResponse == 8)
                    {
                        ball.EightBallPotted(players, balls, ball, game, ballPottedResponse, playerIndex);
                    }
                    else if (ballPottedResponse == 9)
                    {
                        ball.NineBallPotted(players, balls, ball, game, ballPottedResponse, playerIndex);
                    }
                    else
                    {
                        ball.VanillaBallPotted(players, balls, ball, game, ballPottedResponse, playerIndex);
                    }
                }
                players[playerIndex + 1].NumberOfBallsToPot = 1;
            }
        }
    }
}
