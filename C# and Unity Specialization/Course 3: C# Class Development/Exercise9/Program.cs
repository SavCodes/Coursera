namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get the user input
            // Format: <pyramid slot number>,<block letter>,<whether or not the block should be lit>
            Console.Write("<pyramid slot number>,<block letter>,<whether or not the block should be lit>");

            // Store User Input
            string userInput = Console.ReadLine();

            // Save comma locations
            int firstCommaLocation = userInput.IndexOf(',');
            int secondCommaLoction = firstCommaLocation + 2;

            // Save slot number
            int slotNumber = int.Parse(userInput.Substring(0, firstCommaLocation));
            Console.WriteLine($"Slot Number: {slotNumber}");

            // Save block letter
            char blockLetter = userInput[firstCommaLocation + 1];
            Console.WriteLine($"Block Letter: {blockLetter}");  

            // Save bool input
            int boolLength = userInput.Length - secondCommaLoction - 1;
            bool isLit = bool.Parse(userInput.Substring(secondCommaLoction + 1, boolLength));
            Console.WriteLine($"Is lit: {isLit}");


            

        }
    }
}
