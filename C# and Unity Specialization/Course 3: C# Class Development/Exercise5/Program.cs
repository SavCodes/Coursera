
namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Apple standardApple = new Apple();
            Apple largeOrganicApple = new Apple(5, true);

            Console.WriteLine("Standard Apple");
            Console.WriteLine("---------------");
            Console.WriteLine($"Amount Left: {standardApple.AmountLeft}");
            Console.WriteLine($"Organic: {standardApple.IsOrganic}");
            Console.WriteLine();

            Console.WriteLine("Organic Apple");
            Console.WriteLine("---------------");
            Console.WriteLine($"Amount Left: {largeOrganicApple.AmountLeft}");
            Console.WriteLine($"Organic: {largeOrganicApple.IsOrganic}");
            Console.WriteLine();
        }
    }
}
