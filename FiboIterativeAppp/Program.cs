using System.Security.Cryptography.X509Certificates;

namespace FiboIterativeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {          
            Console.WriteLine("Enter the number of terms in the Fibonacci sequence:");
            int n = int.Parse(Console.ReadLine()!);
                        
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine($"{i,3}th:\t{Fibo(i)}");

            }
        }

        public static int Fibo(int n)
        {
            if (n <= 1)
                return n;

            int a = 0;
            int b = 1;
            int c = 1;

            for (int i = 1; i < n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return (n != 0) ? c : 0;
        }
    }
}
