using System;
using System.Collections.Generic;
class Program
{


    static void Main()
    {
        string[] bots = { "Lagrange", "Fourier", "Fibonacci" };
        Random rand = new Random();
        int winner;
        double firstBots = rand.NextDouble() * Math.Pow(10, 25);
        double secondBots = rand.NextDouble() * Math.Pow(10, 25);
        double thirdBots = rand.NextDouble() * Math.Pow(10, 25);

        if ((firstBots > secondBots) && (firstBots < thirdBots) || (firstBots < secondBots) && (firstBots > thirdBots))

            winner = 1;

        else if ((secondBots > firstBots) && (secondBots < thirdBots) || (secondBots < firstBots) && (secondBots > thirdBots))

            winner = 2;

        else if ((thirdBots > firstBots) && (thirdBots < secondBots) || (thirdBots < firstBots) && (thirdBots > secondBots))

            winner = 3;

        else

            winner = 0;
        switch (winner)
        {
            case 1:
                Console.WriteLine("{0}   {1}   {2} \t\t   {3}", firstBots, secondBots,
                           thirdBots, bots[winner - 1]);
                break;
            case 2:
                Console.WriteLine("{0}   {1}   {2} \t\t   {3}", firstBots, secondBots,
                           thirdBots, bots[winner - 1]);
                break;
            case 3:
                Console.WriteLine("{0}   {1}   {2} \t\t   {3}", firstBots, secondBots,
                           thirdBots, bots[winner - 1]);
                break;
            default:
                Console.WriteLine("tie");
                break;
        }

    }
}