namespace Exercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple(3, true);

            while (apple.AmountLeft > 0)
            {
                apple.TakeBite();
                Console.WriteLine($"Apple Remaining: {apple.AmountLeft}");
            }
        }
    }
}
