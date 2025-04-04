namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            StreamReader input = null;

            // Open file with error handling
            {
                Console.WriteLine("Part One: Printing the Entire Input File");
                try
                {
                    input = new StreamReader("TestFile.txt");

                    // Display contents of the file
                    string line = input.ReadLine();
                    while (line != null)
                    {
                        Console.WriteLine(line);
                        line = input.ReadLine();
                    }
                }

                catch (Exception exception)
                {
                    Console.WriteLine(exception.ToString());
                }

                finally
                {
                    // Close the file 
                    if (input != null)
                    {
                        input.Close();
                        Console.WriteLine();
                    }
                }

            }

                Console.WriteLine("Part Two: Printing The Even Lines in the Input File");
                {
                    try
                    {
                        input = new StreamReader("TestFile.txt");

                        int i = 1;

                        string line = input.ReadLine();

                        while ( line != null)
                        {
                            if (i % 2 == 0)  Console.WriteLine(line);
                            line = input.ReadLine();
                            i++;
                        }
                    }

                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }

                    finally
                    {
                        if (input != null)
                        {
                            input.Close();
                        }
                    }
                }
            }




        }
    }
