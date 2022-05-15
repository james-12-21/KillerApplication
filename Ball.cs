using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerApp
{
    public class Ball
    {
        internal int BallId { get; set; }
        internal string BallColour { get; set; }
        internal bool BallPotted { get; set; }
        public Ball()
        {
            
        }
        public Ball(int ballId)
        {
            this.BallId = ballId;
        }
        public Ball(int ballId, bool ballPotted)
        {
            this.BallId = ballId;
            this.BallColour = "White";
            this.BallPotted = ballPotted;
        }

        public Ball(int ballId, string ballColour, bool ballPotted)
        {
            this.BallId = ballId;
            this.BallColour = ballColour;
            this.BallPotted= ballPotted;
        }

        public bool IsBallPotted(List<Ball> balls, int ballId)
        {
            if (!balls[ballId - 1].BallPotted)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void VanillaBallPotted(List<Player> players, List<Ball> balls, Ball ball, Game game, int ballId, int playerIndex)
        {
            players[playerIndex].NumberOfBallsToPot--;
        }
        public void OneBallPotted(List<Player> players, List<Ball> balls, Ball ball, Game game, int ballId, int playerIndex)
        {

             ballToBeRemoved : Console.WriteLine("Please enter ball to be removed");
             int ballToBeRemoved = Convert.ToInt32(Console.ReadLine()) - 1;
             if(ballToBeRemoved  < 1 || ballToBeRemoved > 15)
             {
                 Console.WriteLine("Please enter a valid ballId");
                 goto ballToBeRemoved;
             }
             else if(ball.IsBallPotted(balls, ballToBeRemoved))
             {
                 goto ballToBeRemoved;
             }
             else
             {
                 balls[ballToBeRemoved - 1].BallPotted = true;
             }
             players[playerIndex].NumberOfBallsToPot--;
        }
        public void TwoBallPotted(List<Player> players, List<Ball> balls, Ball ball, Game game, int ballId, int playerIndex)
        {
            players[playerIndex].NumberOfBallsToPot--;
        }
        public void EightBallPotted(List<Player> players, List<Ball> balls, Ball ball, Game game, int ballId, int playerIndex)
        {

            players.Reverse();
            players[playerIndex].NumberOfBallsToPot--;
        }
        public void NineBallPotted(List<Player> players, List<Ball> balls, Ball ball, Game game, int ballId, int playerIndex)
        {
            players[playerIndex].NumberOfBallsToPot--;
        }
    }
}
