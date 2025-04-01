namespace Exercise4
{
    internal class Program
    {
        /// <summary>
        /// Find the distance between two points
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Write("First Location: ");
            int locationOne = int.Parse(Console.ReadLine());

            Console.Write("Second Location: ");
            int locationTwo = int.Parse(Console.ReadLine());

            int distance = locationTwo - locationOne;

            Console.WriteLine(distance);
        }
    }
}
