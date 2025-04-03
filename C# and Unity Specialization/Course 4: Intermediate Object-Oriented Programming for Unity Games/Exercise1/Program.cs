namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input Validation
            {
                try
                {
                    // Get user score input
                    Console.Write("Enter a score: ");
                    int integerScore = int.Parse(Console.ReadLine());
                }

                catch (FormatException fe)
                {
                    Console.WriteLine("Input must be a number");
                }

                catch (OverflowException oe)
                {
                    Console.WriteLine(" 2^-31 < Your Input < 2^31");
                }

                finally
                {
                    Console.WriteLine("Input validation complete");
                }
            }
        }
    }
}

