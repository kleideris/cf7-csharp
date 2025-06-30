namespace IgnoreNegatives
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int negativeCount = 0;

            try
            {
                do
                {
                    Console.WriteLine("Please insert a number (integer)");
                    num = int.Parse(Console.ReadLine()!);
                    if (num > 0) continue;
                    if (num == 0) break;
                    negativeCount++;
                } while (true);

                Console.WriteLine("Negative Count: " + negativeCount);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);                
            }
        }
    }
}
