using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Max2x2App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row = 0;
            int column = 0;

            int[,] matrix =
            {
                {1, 2, 3, 4, 5 ,6 },
                {2, 3, 4 ,5 ,6 ,7 },
                {3, 4, 5, 6, 7, 8 },
                {4, 5, 6, 7, 8, 9 }
            };

            int sum;
            int maxSum = int.MinValue;
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    sum = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        row = i;
                        column = j;
                    }
                }
            }
            Console.WriteLine($"Max Sum: {maxSum}, Row: {row}, Column: {column}");
            Console.WriteLine();
            Console.Write($"{matrix[row, column]} {matrix[row, column + 1]}\n");
            Console.Write($"{matrix[row + 1, column]} {matrix[row + 1, column + 1]}\n");
        }
    }
}
