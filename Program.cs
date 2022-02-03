using System;

namespace LearningCSharp
{
    class Program
    {
        Player player1 = new Player(1, "James");
        Player player2 = new Player(2, "Pete");
        Player player3 = new Player(3, "Alistair");
        Player player4 = new Player(4, "Kieran");
        Player player5 = new Player(5, "Sean");
        Player player6 = new Player(6, "Matt");

        public Ball yellow = new Ball(1, false, "Yellow", 1);

        public Ball yellowStripe = new Ball(9, false, "Yellow", 1);

        public Ball blue = new Ball(2, false, "Blue", 1);

        public Ball blueStripe = new Ball(10, false, "Blue", 1);

        public Ball red = new Ball(3, false, "Red", 1);

        public Ball redStripe = new Ball(11, false, "Red", 1);

        public Ball purple = new Ball(4, false, "Purple", 1);

        public Ball purpleStripe = new Ball(12, false, "Purple", 1);

        public Ball orange = new Ball(5, false, "Orange", 1);

        public Ball orangeStripe = new Ball(13, false, "Orange", 1);

        public Ball green = new Ball(6, false, "Green", 1);

        public Ball greenStripe = new Ball(14, false, "Green", 1);

        public Ball brown = new Ball(7, false, "Brown", 1);

        public Ball brownStripe = new Ball(15, false, "Brown", 1);

        public Ball black = new Ball(8, false, "Black", 1);

        static void Main(string[] args)
        {
            
            Console.WriteLine();
        }

   
    }
}