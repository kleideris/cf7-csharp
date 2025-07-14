namespace PrimesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a non-negative integer to list all prime numbers up to that value:");
            int number = int.Parse(Console.ReadLine()!);

            for (int i = 0; i <= number; i++)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine($"{i,3} is a prime number.");
                }
            }
        }

        public static bool IsPrime(int n)
        {
            bool prime = true;

            if (n < 2)
            {
                return false; // 0 and 1 are not prime numbers
            }

            for (int divider = 2; divider <= Math.Sqrt(n); divider++)
            {
                if (n % divider == 0)
                {
                    prime = false;
                    break;
                }
            }
            return prime;
        }
    }
}
