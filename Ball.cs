using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp
{
    class Ball
    {
        private int BallNumber;
        private bool BallPotted;
        private string BallColour;
        private int BallModifier;

        public Ball(int ballNumber, bool ballPotted, string ballColour, int ballModifier)
        {
            this.BallNumber = ballNumber;
            this.BallColour = ballColour;
            this.BallModifier = ballModifier;
            this.BallPotted = ballPotted;
        }

        public int number
        {
            get { return BallNumber; }
            set { BallNumber = value; }
        }
        
        public bool potted
        {
            get { return BallPotted; }
            set { BallPotted = value;}
        }
        
        public string colour
        {
            get { return BallColour; }
            set { BallColour = value; }
        }

        public int modifier
        {
            get { return BallModifier; }
            set { BallModifier = value;}
        }


    }

}
