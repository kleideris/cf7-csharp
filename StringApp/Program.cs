namespace StringApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "AUEB";
            string s2 = "AUEB"; // String Interning (me new den kanei interning paei se allh thesi sth mnhmh)
            string passwd1 = "pass";
            string passwd2 = "PASS";

            // Equality
            Console.WriteLine($"{s1.Equals(s2)}");
            Console.WriteLine($"{s1 == s2}");

            Console.WriteLine($"{ReferenceEquals(s1, s2)}");    // checks if their refference areN equal

            // < <= > >=
            Console.WriteLine($"{String.Compare(s1, s2)}");
            Console.WriteLine($"{s1.CompareTo((s2))}");

            // concat
            string hello = "Hello";
            string aueb = $"{s1}";
            string helloAueb = hello + aueb;

            // ToUpper(), ToLower()
            bool areEqual = passwd1.ToUpper().Equals(passwd2.ToUpper());

            // indexOf, Substring
            string str = "C# Programming Language";
            int index = str.IndexOf("#");   // 1
            int index2 = str.IndexOf("a", 15);
            string subStr = str.Substring(3);  //Programming Language
            string subStr2 = str.Substring(3, 11);  // Programming

            // Trim
            string s = "     Smtng  ";
            char[] chars = new char[] { ' ', '$', '#' };    // i can use an array to trim the chars that it includes from a string.
            string trimmed = s.Trim(chars);                       
        }

        public static bool isPallindrome(string s)
        {

            bool pallindrome = true;

            for (int i = 0, j = s.Length; i < j; i++, j--)
            {
                if (s[i] != s[j])
                {
                    pallindrome = false;
                    break;
                }
            }
            return pallindrome;
        }
    }
}
