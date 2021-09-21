using System;

namespace LinkedListPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select option number\n1. Linked list\n2. Stack\n3. Queue");
            int option = int.Parse(Console.ReadLine());
            switch (option){
                case 1:
                    LinkedlistOperation.Operation();
                    break;
                case 2:
                    StackOperations.Operations();
                    break;
                case 3:
                    QueueOperations.Operations();
                    break;
            }
            
        }
    }
}
