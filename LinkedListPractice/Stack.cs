using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListPractice
{
    class Stack<T> where T : IComparable
    {
        private Node<T> Top;
        private int limit;
        /// <summary>
        /// Setting limit of stack
        /// </summary>
        /// <param name="limit"></param>
        public Stack(int limit)
        {
            this.limit = limit;
        }
        /// <summary>
        /// Add new node at top
        /// </summary>
        /// <param name="data"></param>
        internal void Push(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if(this.Top == null)
            {
                this.Top = newNode;
            }
            else
            {
                newNode.next = this.Top;
            }
            this.Top = newNode;
            Console.WriteLine("{0} is added", this.Top.data);
        }
        /// <summary>
        /// Display node data in the stack
        /// </summary>
        internal void DisplayStack()
        {
            if (this.Top.Equals(null))
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                Node<T> tempNode = this.Top;
                while(tempNode != null)
                {
                    Console.Write("{0} ", tempNode.data);
                    tempNode = tempNode.next;
                }
            }
        }
    }
}
