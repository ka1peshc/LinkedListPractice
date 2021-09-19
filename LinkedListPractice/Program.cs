using System;

namespace LinkedListPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linklist = new LinkedList();
            linklist.Add(56);
            linklist.Add(96);
            //linklist.Add(30);
            linklist.Add(70);
            linklist.Display();
            linklist.AddInBetween(2, 30);
            linklist.Display();
            linklist.AddInBetween(3, 100);
            linklist.Display();
            linklist.Pophead();
            linklist.Display();
            linklist.PopTail();
            linklist.Display();
            linklist.SearchData(30);
        }
    }
}
