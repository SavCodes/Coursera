using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment2
{
    /// <summary>
    /// Provides a variety of numeric methods
    /// </summary>
    public class Matherator
    {
        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        public Matherator()
        {
        }

        #endregion

        #region Methods

        /// <summary>
        /// Prints the numbers from 1 to 10
        /// </summary>
        public void PrintOneToTen()
        {
            Console.Write("1 2 3 4 5 6 7 8 9 10 ");
            Console.WriteLine();
        }

        /// <summary>
        /// Prints the numbers from m to n
        /// </summary>
        /// <param name="m">m</param>
        /// <param name="n">n</param>
        public void PrintMToN(int m, int n)
        {
            for (int i = m; i <= n; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Returns the tenth even number, with 2 as the first even number
        /// </summary>
        /// <returns>tenth even number</returns>
        public int GetTenthEvenNumber()
        {
            return 2 * 10;
        }

        /// <summary>
        /// Returns the nth even number, with 2 as the first even number
        /// </summary>
        /// <param name="n">n</param>
        /// <returns>nth even number</returns>
        public int GetNthEvenNumber(int n)
        {
            return 2 * n;
        }

        #endregion
    }
}
