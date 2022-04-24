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

        public int GetBallId(char ballPotted)
        {
            if(ballPotted == 'n')
            {
                return 15;
            }
            else
            {
                Console.WriteLine("Enter the number of the ball potted ");
                int ballId = Convert.ToInt32(Console.ReadLine());
                return ballId;
            }
        }

        public static void ShotMissed(List<Player> player, Ball ballId, int activePlayerIndex)
        {
            player[activePlayerIndex].PlayerLives--;
            player[activePlayerIndex].PlayerTurn = false;
            player[activePlayerIndex + 1].PlayerTurn = true;
        }

        public static void VanillaBallPotted(List<Player> player, Ball ballId, char ballPotted, int activePlayerIndex)
        {

            if (ballPotted == 'n')
            {
                ShotMissed(player, ballId, activePlayerIndex - 1);
            }
            else
            {
                player[activePlayerIndex - 1].PlayerTurn = false;
                player[activePlayerIndex].PlayerTurn = true;
            }

        }
        public static void OneBallPotted(List<Player> player, Ball ballId, char ballPotted, int activePlayerIndex)
        {

            if (ballPotted == 'n')
            {
                ShotMissed(player, ballId, activePlayerIndex - 1);
            }
            else
            {
                player[activePlayerIndex - 1].PlayerTurn = false;
                player[activePlayerIndex].PlayerTurn = true;
            }

        }
        public static void EightBallPotted(List<Player> player, Ball ballId, char ballPotted, int activePlayerIndex)
        {

            if (ballPotted == 'n')
            {
                ShotMissed(player, ballId, activePlayerIndex - 1);
            }
            else
            {
                player[activePlayerIndex - 1].PlayerTurn = false;
                player.Reverse();
                player[activePlayerIndex].PlayerTurn = true;
            }
            

        }
        public static void NineBallPotted(List<Player> player, Ball ballId, char ballPotted, int activePlayerIndex)
        { 
            if (ballPotted == 'n')
            {
                ShotMissed(player, ballId, activePlayerIndex - 1);
            }
            else
            {
                player[activePlayerIndex - 1].PlayerTurn = false;
                player[(activePlayerIndex + 1)].PlayerTurn = true;
            }
            
        }
    }
}
