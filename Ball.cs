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
            Console.WriteLine("Enter the number of the ball potted ");
            int ballId = Convert.ToInt32(Console.ReadLine());
            return ballId;
        }

        public void VanillaBallPotted(List<Player> player, Ball ballId, char ballPotted, int activePlayerIndex)
        {
            
            try
            {
                if (ballPotted == 'n')
                {
                    player[activePlayerIndex].PlayerLives--;
                    player[activePlayerIndex].PlayerTurn = false;
                    player[activePlayerIndex + 1].PlayerTurn = true;
                }
                else
                {
                    player[activePlayerIndex].PlayerTurn = false;
                    player[activePlayerIndex + 1].PlayerTurn = true;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        public void OneBallPotted(List<Player> player, Ball ballId, char ballPotted, int activePlayerIndex)
        {

            try
            {
                if (ballPotted == 'n')
                {
                    player[activePlayerIndex].PlayerLives--;
                    player[activePlayerIndex].PlayerTurn = false;
                    player[activePlayerIndex + 1].PlayerTurn = true;
                }
                else
                {
                    player[activePlayerIndex].PlayerTurn = false;
                    player[activePlayerIndex + 1].PlayerTurn = true;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        public void EightBallPotted(List<Player> player, Ball ballId, char ballPotted, int activePlayerIndex)
        {

            try
            {
                if (ballPotted == 'n')
                {
                    player[activePlayerIndex].PlayerLives--;
                    player[activePlayerIndex].PlayerTurn = false;
                    player[activePlayerIndex + 1].PlayerTurn = true;
                }
                else
                {
                    player[activePlayerIndex].PlayerTurn = false;
                    player.Reverse();
                    player[activePlayerIndex + 1].PlayerTurn = true;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        public void NineBallPotted(List<Player> player, Ball ballId, char ballPotted, int activePlayerIndex)
        {

            try
            {
                if (ballPotted == 'n')
                {
                    player[activePlayerIndex].PlayerLives--;
                    player[activePlayerIndex].PlayerTurn = false;
                    player[activePlayerIndex + 1].PlayerTurn = true;
                }
                else
                {
                    player[activePlayerIndex].PlayerTurn = false;
                    player[(activePlayerIndex + 1)].PlayerTurn = true;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
