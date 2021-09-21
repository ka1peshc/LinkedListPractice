using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListPractice
{
    class QueueOperations
    {
        public static void Operations()
        {
            Queue<int> que = new Queue<int>();
            que.Enqueue(10);
            que.Enqueue(20);
            que.Enqueue(40);
            que.Enqueue(80);
            que.Enqueue(160);
            Console.WriteLine("Size of queue {0}", que.Size());
            que.Dequeue();
            que.Dequeue();
            bool result = que.isEmpty();
            Console.WriteLine("is empty result {0}", result);
            Console.WriteLine("Size of queue {0}",que.Size());
            que.Dequeue();
            que.Dequeue();
            que.Dequeue();
            result = que.isEmpty();
            Console.WriteLine("is empty result {0}", result);
        }
    }
}
