namespace RightTriangleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double EPSILON = 0.000005;
            //const double a = 0.0;
            //const double b = 0.0;
            //const double c = 0.0;
            bool isRight = false;

            Console.WriteLine("Please enter the lengths of the triangle sides a, b and c");

            Console.WriteLine("Insert a: ");
            if (!Double.TryParse(Console.ReadLine(), out double a))
            {
                Console.WriteLine("Format Error. a must be double.");
            }

            Console.WriteLine("Insert b:");
            if (!Double.TryParse(Console.ReadLine(), out double b))
            {
                Console.WriteLine("Format Error. b must be double.");
            }

            Console.WriteLine("Insert c:");
            if (!Double.TryParse(Console.ReadLine(), out double c))
            {
                Console.WriteLine("Format Error. c must be double.");
            }

            isRight = Math.Abs(a * a + b * b - c * c) < EPSILON ||
                        Math.Abs(a * a + c * c - b * b) < EPSILON ||
                        Math.Abs(b * b + c * c - a * a) < EPSILON;

            Console.WriteLine("The triangle is {0}right.", (isRight) ? "" : "not ");
        }
    }
}
