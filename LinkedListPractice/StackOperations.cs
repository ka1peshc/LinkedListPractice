using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListPractice
{
    class StackOperations
    {
        public static void Operations()
        {
            Stack<int> s = new Stack<int>(5);
            s.Push(10);
            s.Push(20);
            s.Push(30);
            s.DisplayStack();
        }
    }
}
