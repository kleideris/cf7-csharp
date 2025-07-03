namespace PrimesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            int number = int.Parse(Console.ReadLine()!);

            if (IsPrime(number))
            {
                Console.WriteLine($"{number} is prime.");
            } else
            {
                Console.WriteLine($"{number} is not prime.");
            }
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
