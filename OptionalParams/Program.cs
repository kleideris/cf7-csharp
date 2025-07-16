namespace OptionalParams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = GetDateTime();
            Console.WriteLine($"{dateTime:D}");
            Console.WriteLine($"{dateTime:F}");
        }

        public static DateTime GetDateTime(int year=2024, int month=11, int day=1, int hour=0, int min=0, int sec=0)
        {
            return new DateTime(year, month, day, hour, min, sec, DateTimeKind.Utc);
        }
    }
}
