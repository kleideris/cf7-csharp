namespace ReadApp
{
    /// <summary>
    /// Read two integers from std input and prints their sum.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int result = 0;

            Console.WriteLine("Please insert two integers");
            num1 = int.Parse(Console.ReadLine()!);
            num2 = int.Parse(Console.ReadLine()!);

            result = num1 + num2;
            Console.WriteLine($"The sum of {num1} and {num2} is {result}");

        }
    }
}
