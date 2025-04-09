namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Menu Option Display
            Console.WriteLine("**************");
            Console.WriteLine("Menu:");
            Console.WriteLine("1 - New Game");
            Console.WriteLine("2 - Load Game");
            Console.WriteLine("3 - Options");
            Console.WriteLine("4 - Quit");
            Console.WriteLine("**************");

            int userInput = int.Parse(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    Console.WriteLine("Creating New Game");
                    break;

                case 2:
                    Console.WriteLine("Loading Game");
                    break;

                case 3:
                    Console.WriteLine("Loading Options");
                    break;

                case 4:
                    Console.WriteLine("Quitting Game");
                    break;

                default:
                    Console.WriteLine("Enter a valid option");
                    break;
            }
            
        }
    }
}
