using PointMonolithic.Model;

namespace PointMonolithic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new() { X = 1 };
            Point p2 = new() { X = 2 };
            Point p3 = new() { X = 3 };

            p1.InsertPoint();
            p2.InsertPoint();
            p3.InsertPoint();

            Point? deletePoint = p3.DeletePoint();
            p3.UpdatePoint(new Point { X = 55 });


            //Points Traversal:
            //1st way
            foreach (Point p in Point.GetAllPoints())
            {
                Console.WriteLine(p);
            }

            //2nd way
            Point.GetAllPoints().ForEach(p => Console.WriteLine(p));

            //3rd way
            Point.Points.ForEach(Console.WriteLine);

        }
    }
}
