namespace SwapApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            Swap(a, b);
            Console.WriteLine($"a: {a}, b: {b}");

            Swap(ref a, ref b);
            Console.WriteLine($"a: {a}, b: {b}");

            string? s = "Hello";
            ChangeStr(s);
            Console.WriteLine(s);

            s = null;  //we can also use null forgiving operator on null itself like so s = null!
            ChangeStr(out s);
            Console.WriteLine(s);
        }

        public static void Swap(int a, int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }

        public static void Swap(ref int a, ref int b)
        {
            //int tmp = a;
            //a = b;
            //b = tmp;
            (a, b) = (b, a);    // tuples
        }

        public static void ChangeStr(string str)
        {
            str = "AUEB";
        }
        public static void ChangeStr(out string? str)
        {
            str = "AUEB";
        }


        //Demonstrates better when we ref doesnt work and we need out:

        /*
        void AssignValue(ref int number)
        {
            number = 42;
        }

        void Main()
        {
            int value; // ❗ Error: Use of unassigned local variable 'value'
            AssignValue(ref value); // ❌ This causes a compile error
        }

        void AssignValue(out int number)
        {
            number = 42;
        }

        void Main()
        {
            int value; // ✅ No need to initialize!
            AssignValue(out value); // ✅ Works perfectly
        }
        */
    }
}
