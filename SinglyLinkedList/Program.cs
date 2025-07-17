using SinglyLinkedList.Model;

namespace SinglyLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SLList<int> mySSList = new();

            mySSList.InsertFirst(1);
            mySSList.InsertFirst(2);
            mySSList.InsertFirst(3);
            mySSList.InsertFirst(4);

            //mySSList.InsertLast(5);
            //mySSList.InsertLast(5);
            //mySSList.InsertFirst(7);

            mySSList.Traverse();

        }
    }
}
