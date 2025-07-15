namespace ArraysOneDim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[2];   //new
            arr1[0] = 1;
            arr1[1] = 2;

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine($"{arr1[i]}");
            }

            int[] arr2 = { 1, 2, 3 };    // unsized initialization

            foreach (int el in arr2)
            {
                Console.WriteLine(el);
            }

            int[] arr3 = new int[] { 1, 2, 3 }; // array initializer (the difference is it can be initialized later like bellow in two phases)
            //int[] arr3;
            //arr3 = new int[] { 1, 2, 3 };

            int[] arr4 = [1, 2, 3, 4];  // .NET 8 collection init, like JS
        }

        public static bool IsSymmetric(int[] arr)
        {
            bool symmetric = true;

            //for (int i = 0; i < arr.Length / 2; i++)    // [1, 2, 3, 4, 5]
            //{
            //    if (arr[i] != arr[arr.Length - i]) {
            //        symmetric = false;
            //        break;
            //    }
            //}
            

            for (int i = 0, j = arr.Length; i < j; i++, j--)
            {
                if (arr[i] != arr[j])
                {
                    symmetric = false;
                    break;
                }
            }

            return symmetric;
        }
    }
}
