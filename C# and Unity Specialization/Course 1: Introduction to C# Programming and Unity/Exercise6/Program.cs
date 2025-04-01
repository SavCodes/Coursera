using System;

namespace Exercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an angle in degrees: ");

            double angle = double.Parse(Console.ReadLine());

            double sinAngle = Math.Sin(angle * Math.PI / 180);

            Console.WriteLine(sinAngle);

            double cosAngle = Math.Cos(angle * Math.PI / 180);

            Console.WriteLine(cosAngle);       
        }
    }
}
