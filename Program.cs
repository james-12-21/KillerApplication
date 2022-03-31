using System;

namespace KillerApp
{
    class Program
    {

        static void Main(string[] args)
        {
            var ballsOnTable = new List<Ball>() {
                    new Ball(1, "Yellow", false)    { BallId = 1 , BallColour = "Yellow" , BallPotted = true }
                ,   new Ball(2, "Blue", false)      { BallId = 2 , BallColour = "Blue", BallPotted = false}
                ,   new Ball(3, "Red", false)       { BallId = 3 , BallColour = "Red" , BallPotted = false}
                ,   new Ball(4, "Purple", false)    { BallId = 4 , BallColour = "Purple", BallPotted = false}
                ,   new Ball(5, "Orange", false)    { BallId = 5 , BallColour = "Orange", BallPotted = false}
                ,   new Ball(6, "Green", false)     { BallId = 6 , BallColour = "Green", BallPotted = false}
                ,   new Ball(7, "Brown", false)     { BallId = 7 , BallColour = "Brown", BallPotted = false}
                ,   new Ball(8, "Black", false)     { BallId = 8 , BallColour = "Black", BallPotted = false}
                ,   new Ball(9, "Yellow", false)    { BallId = 9 , BallColour = "Yellow", BallPotted = false}
                ,   new Ball(10, "Blue", false)     { BallId = 10 , BallColour = "Blue", BallPotted = false}
                ,   new Ball(11, "Red", false)      { BallId = 11 , BallColour = "Red", BallPotted = false}
                ,   new Ball(12, "Purple", false)   { BallId = 12 , BallColour = "Purple", BallPotted = false}
                ,   new Ball(13, "Orange", false)   { BallId = 13 , BallColour = "Orange", BallPotted = false}
                ,   new Ball(14, "Green", false)    { BallId = 14 , BallColour = "Green", BallPotted = false}
                ,   new Ball(15, "Brown", false)    { BallId = 15 , BallColour = "Brown", BallPotted = false}
            };

            Console.WriteLine("Enter ball number: ");
            int ballId = Convert.ToInt32(Console.ReadLine());
            BallPotted(ballId, ballsOnTable);

            static void BallPotted(int ballId, List<Ball> ballsOnTable)
            {
                if(ballsOnTable.Count == 0)
                {
                    Console.WriteLine("Error: variable ballsOnTable is empty");
                }
                else if (ballsOnTable.Count > 15)
                {
                    Console.WriteLine("Error: variable ballsOnTable has too many balls in it");
                }
                else if (ballsOnTable[ballId - 1].BallPotted)
                {
                    Console.WriteLine($"Ball {ballId} has already been potted");
                }
                else
                {
                    ballsOnTable[ballId - 1].BallPotted = true;
                }
            }
            
        }

   
    }
}