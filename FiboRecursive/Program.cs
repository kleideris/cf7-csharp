namespace FiboRecursive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of terms in the Fibonacci sequence:");
            int n = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{i,3}th: {Fibo(i):N0}");

            }
        }

        public static int Fibo (int n)
        {
            if (n <= 1)
                return n;
            return Fibo(n - 1) + Fibo(n - 2);
        }
    }
}
