using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerApp
{
    public class Ball
    {
        public int BallId { get; set; }
        public string BallColour { get; set; }
        public char BallPotted { get; set; }

        public Ball()
        {

        }
        public Ball(int ballId, char ballPotted)
        {
            this.BallId = ballId;
            this.BallColour = "White";
            this.BallPotted = ballPotted;
        }

        public Ball(int ballId, string ballColour, char ballPotted)
        {
            this.BallId = ballId;
            this.BallColour = ballColour;
            this.BallPotted= ballPotted;
        }

        public int GetBallId()
        {
            Console.WriteLine("Enter the number of the ball potted");
            int ballId = Convert.ToInt32(Console.ReadLine());
            return ballId;
        }

        public bool VanillaBallPotted(Player player, Ball ballId, char ballPotted, int playerId)
        {
            Console.WriteLine("Press 'y' if a ball is successfully potted, 'n' for a missed shot");
            ballPotted = Convert.ToChar(Console.ReadLine());
            try
            {
                if (ballPotted == 'n')
                {
                    player.PlayerLives--;
                    player.PlayerTurn = false;
                    return false;
                }
                else
                {
                    Console.WriteLine("Enter the number of the ball potted ");
                    Console.ReadLine();
                    player.PlayerTurn = false;
                    return true;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
