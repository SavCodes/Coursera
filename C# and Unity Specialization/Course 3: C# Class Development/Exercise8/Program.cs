namespace Exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get user birth month
            Console.Write("Enter your birth month: ");
            string birthMonth = Console.ReadLine();

            // Get user birth day
            Console.Write("Enter your birth day: ");
            int birthDay = int.Parse(Console.ReadLine());

            // Return birt day
            Console.WriteLine($"Your Full Birth Day is {birthMonth}, {birthDay}");

            // Birthday reminder
            Console.WriteLine($"You will receive a reminder on {birthMonth}, {birthDay} for a 20% discount");
        }
    }
}
