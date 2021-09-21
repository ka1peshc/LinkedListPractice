using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListPractice
{
    class Queue<T> where T:IComparable
    {
        private Node<T> Rear;
        private Node<T> Front;

        /// <summary>
        /// Constructor to null 
        /// </summary>
        public Queue()
        {
            this.Rear = this.Front = null;
        }
        /// <summary>
        /// Add new data at rear of the queue
        /// </summary>
        /// <param name="data"></param>
        internal void Enqueue(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if(this.Rear == null)
            {
                this.Rear = this.Front = newNode;
            }
            else
            {
                this.Rear.next = newNode;
                this.Rear = newNode;
            }
            Console.WriteLine("{0} inserted into Queue", data);
        }
        /// <summary>
        /// Remove one data from front side.
        /// </summary>
        internal void Dequeue()
        {
            if(this.Front == null)
            {
                Console.WriteLine("The queue is empty.");
                return;
            }
            Node<T> tempNode = this.Front;
            this.Front = this.Front.next;
            if(this.Front == null)
            {
                this.Rear = null;
            }
            Console.WriteLine("{0} is deleted",tempNode.data);
            
        }
        /// <summary>
        /// Check if queue is empty or not
        /// </summary>
        /// <returns>boolean value</returns>
        internal bool isEmpty()
        {
            if (this.Front == null)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// fetch size of queue
        /// </summary>
        /// <returns>integer size</returns>
        internal int Size()
        {
            int count = 0;
            Node<T> tempNode = this.Front;
            if (tempNode == null)
            {
                return 0;
            }
            else
            {
                while(tempNode != null)
                {
                    count++;
                    tempNode = tempNode.next;
                }
                return count;
            }
        }
    }
}
