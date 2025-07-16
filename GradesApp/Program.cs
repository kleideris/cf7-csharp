namespace GradesApp
{
    /// <summary>
    /// Takes as input the "total marks" and "courses count" then calculates the average and also presents
    /// characterizations of the average such as (Άριστα, Πολύ καλά, etc)
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int average;

            Console.WriteLine("Please enter 'total marks' and 'courses count'");

            if (!int.TryParse(Console.ReadLine(), out int totalMarks))
            {
                Console.WriteLine("Error. Format missmatch.");
            }

            if (totalMarks < 0)
            {
                Console.WriteLine("Total marks can not be neagative number.");
                Environment.Exit(1);
            }

            if(!int.TryParse(Console.ReadLine(), out int coursesCount))
            {
                Console.WriteLine("Error. Format missmatch.");
            }

            if (totalMarks < 0)
            {
                Console.WriteLine("Courses count can not be neagative number.");
                Environment.Exit(1);
            }

            average = totalMarks / coursesCount;

            if (average > 10)
            {
                Console.WriteLine("Average cannot exceed 10");
            }

            switch (average)
            {
                case >= 8:
                    Console.WriteLine($"Excellent: {average}");
                    break;
                case >= 6:
                    Console.WriteLine($"Very Good: {average}");
                    break;
                case >= 5:
                    Console.WriteLine($"Good: {average}");
                    break;
                default:
                    Console.WriteLine($"Failure: {average}");
                    break;
            }
        }
    }
}
