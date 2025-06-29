namespace FiboWithArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of terms in the Fibonacci sequence:");
            int n = int.Parse(Console.ReadLine()!);

            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine($"{i,3}th: {Fibo(i):N0}");

            }
        }

        public static int Fibo(int n)
        {
            if (n == 0) return 0;

            int[] arr = new int[n + 1];
            arr[0] = 0;
            arr[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];               
            }
            return arr[n];
        }
    }
}
