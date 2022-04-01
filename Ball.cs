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
        public bool BallPotted { get; set; }

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

    }
}
