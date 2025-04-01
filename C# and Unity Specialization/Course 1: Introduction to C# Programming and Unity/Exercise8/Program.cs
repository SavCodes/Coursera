using System;

namespace Exercise8
{
    /// <summary>
    /// Exercise 8 solution
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Demonstrates rolling and using two dice
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // initialize random number generator
            RandomNumberGenerator.Initialize();

            // create two dice
            Die die1 = new Die(6);
            Die die2 = new Die(6);

            // tell the dice to roll themselves
            die1.Roll();
            die2.Roll();

            // print the top sides and the sum of the dice
            Console.WriteLine(die1.TopSide);
            Console.WriteLine(die2.TopSide);
        }
    }
}
