using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        /*
         * DSA Activity 5.3 - [Macaraeg, Lorena]
         * Program Description: Simple Game using Stack
         */

        Random random = new Random();

        Stack<int> playerA = new Stack<int>();
        Stack<int> playerB = new Stack<int>();

        // Generate 10 random numbers
        for (int i = 0; i < 10; i++)
        {
            int number = random.Next(0, 10);
            playerA.Push(number);
            playerB.Push(number);
        }

        // Display original lists
        Console.WriteLine("Player A: " +
            string.Join(" ", playerA.Reverse()));

        Console.WriteLine("Player B: " +
            string.Join(" ", playerB.Reverse()));

        int scoreA = 0;
        int scoreB = 0;

        // Play the game
        while (playerA.Count > 0 && playerB.Count > 0)
        {
            int a = playerA.Peek();
            int b = playerB.Peek();

            if (a > b)
            {
                playerB.Pop();
                scoreA++;
            }
            else if (a < b)
            {
                playerA.Pop();
                scoreB++;
            }
            else
            {
                playerA.Pop();
                playerB.Pop();
            }
        }

        // Display resulting lists
        Console.WriteLine("\nPlayer A remaining: " +
            string.Join(" ", playerA.Reverse()));

        Console.WriteLine("Player B remaining: " +
            string.Join(" ", playerB.Reverse()));

        // Determine winner
        if (scoreA > scoreB)
            Console.WriteLine("\nPlayer A Win");
        else if (scoreB > scoreA)
            Console.WriteLine("\nPlayer B Win");
        else
            Console.WriteLine("\nDraw");

        Console.WriteLine("Thank you for using the program");
    }
}
