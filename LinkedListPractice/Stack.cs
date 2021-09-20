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
            if (limit < 0)
            {
                Console.WriteLine("Reached stack limit");
            }
            else
            {
                Node<T> newNode = new Node<T>(data);
                if (this.Top == null)
                {
                    this.Top = newNode;
                }
                else
                {
                    newNode.next = this.Top;
                }
                this.Top = newNode;
                Console.WriteLine("{0} is added", this.Top.data);
                limit--;
            }
            
        }
        /// <summary>
        /// Get top value/Last inserted value from stack
        /// </summary>
        /// <returns>0 or data</returns>
        internal void Peek()
        {
            if (this.Top == null)
            {
                Console.WriteLine("stack is empty");
            }
            Console.WriteLine("Peek element {0}", this.Top.data); 
        }
        /// <summary>
        /// Deleting top value
        /// </summary>
        internal void Pop()
        {
            if(this.Top == null)
            {
                Console.WriteLine("stack is empty");
            }
            Console.WriteLine("Pop element {0}", this.Top.data);
            this.Top = this.Top.next;
        }
        /// <summary>
        /// Deleting all element
        /// </summary>
        internal void IsEmpty()
        {
            while (this.Top != null) {
                Peek();
                Pop();
            }
        }

        /// <summary>
        /// Display node data in the stack
        /// </summary>
        internal void DisplayStack()
        {
            if (this.Top == null)
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
            Console.WriteLine("");
        }
    }
}
