using System.Globalization;

namespace EuroToDollarApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float euro = 0;
            float dollar = 0;

            Console.WriteLine("Please insert the value of Euros:");
            euro = int.Parse(Console.ReadLine()!);

            dollar = ConvertEuroToDollars(euro);

            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            Console.WriteLine($"{euro} Euro = {dollar:C}$");
        }

        public static float ConvertEuroToDollars(float money)
        {
            const float ConversionRate = 1.16F;
            return money *= ConversionRate;
        }     
    }
}
