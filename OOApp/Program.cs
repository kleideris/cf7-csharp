using OOApp.Model;

namespace OOApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher alice = new Teacher();
            Teacher bob = new();    //  >= C#9
            var costas = new Teacher();

            Teacher anna = new Teacher()    // Object Initializer
            {
                Id = 1,
                Firstname = "Anna",
                Lastname = "Gianoutsou"
            };

            anna.Firstname = "Georgia"; // here it works as setter
            Console.WriteLine(anna.Firstname);  // here it works as getter

            Teacher andreas = new Teacher(1,"Andreas","Androutsos");
        }
    }
}
