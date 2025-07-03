using System.Text;

namespace EuroToDollarApp
{
    /// <summary>
    /// Reads from standard input an int that represents an amount of euros and converts it to dollars.
    /// Its assumed that the parity rate is 1 Euro = 1.17 USD.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            const int CENTS_PER_DOLLAR = 100;
            decimal dollars;
            decimal cents;

            Console.WriteLine("Please insert the amount in Euros.");
            if (!decimal.TryParse(Console.ReadLine(), out decimal inputEuros)) {
                Console.WriteLine("Error in input");
            }

            dollars = ConvertEuroToDollars(inputEuros);
            cents = dollars * CENTS_PER_DOLLAR;


            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine($"\u20AC {inputEuros:N2} = \u0024 {dollars:N2} or {cents, 5:N2} \u0024 cents");
        }

        public static decimal ConvertEuroToDollars(decimal inputEuros)
        {
            const decimal RATE = 1.17m;   
            
            return inputEuros * RATE;
        }     
    }
}
