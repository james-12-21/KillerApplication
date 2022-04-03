using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerApp
{
    public class Game
    {
        public Game() 
        {

        }
        public bool ActiveGameChecker(List<Player> players)
        {
            int numberOfPlayersAlive = 0;
            if(players.Count == 2 && players[0].PlayerLives > 0 && players[1].PlayerLives > 0)
            {
                return true;
            }
            else
            {
                for (int i = 0; i < players.Count; i++)
                {
                    if (players[i].PlayerLives > 0)
                    {
                        numberOfPlayersAlive++;
                    }
                }
            }
            if (numberOfPlayersAlive <= 2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void BallsOnTable(List<Ball> balls)
        {
            int numberOfBallsPotted = 0;
            for (int i = 0;i < balls.Count;i++)
            {
                if(balls[i].BallPotted == 'y')
                {
                    numberOfBallsPotted++;
                }
            }

            if(numberOfBallsPotted == 14)
            {
                for(int j = 0; j < balls.Count;j++)
                {
                    balls[j].BallPotted = 'n';
                    Console.WriteLine("New frame!");
                }
            }
            else
            {
                return;
            }

        }

    }
}
