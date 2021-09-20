using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListPractice
{
    class LinkedList<T> where T:IComparable
    {
        private Node<T> head;
        /// <summary>
        /// Adding new Node<T> in linklist
        /// </summary>
        /// <param name="data"></param>
        internal void Add(T data)
        {
            Node<T> node = new Node<T>(data);
            
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node<T> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
        }
        /// <summary>
        /// Add a node in particular position
        /// </summary>
        /// <param name="position"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        internal Node<T> AddInBetween(int position, T data)
        {
            //int index=1;
            Node<T> tempNode = this.head;
            if (position < 1)
            {
                Console.WriteLine("invalid position");
                
            }
            else if( position == 1)
            {
                Node<T> newNode = new Node<T>(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                
                while(position-- != 0)
                {
                    if(position == 1)
                    {
                        Node<T> node = new Node<T>(data);
                        node.next = tempNode.next;
                        tempNode.next = node;
                        break;
                    }
                    tempNode = tempNode.next;
                }
                if(position != 1)
                {
                    Console.WriteLine("Position out of range");
                }
            }
            Console.WriteLine("Inserted value is " + tempNode.data);
            return tempNode;
        }
        /// <summary>
        /// Display Node<T> data fron head to tail
        /// </summary>
        internal void Display()
        {
            //Console.WriteLine("head is :" + this.head.data);
            Node<T> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linklist is empty");
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
            Console.WriteLine("==============");
            
        }
        /// <summary>
        /// removes head.next link
        /// </summary>
        internal void Pophead()
        {
            Node<T> tempNode = this.head;
            head = tempNode.next;
            Console.WriteLine("Poped head Node");
        }
        /// <summary>
        /// Removes tail node using 
        /// </summary>
        internal void PopTail()
        {
            if(this.head == null)
            {
                Console.WriteLine("Linkedlist is empty");
            }
            else if (this.head.next == null){
                Console.WriteLine("Head is only Node");
            }
            else
            {
                Node<T> tempNode = this.head;
                while (tempNode.next.next != null)
                {
                    tempNode = tempNode.next;
                }
                tempNode.next = null;
                Console.WriteLine("Poped Tail Node");
            }
            
        }

        internal void SearchData(T data)
        {
            int position=1;
            bool notFound = true;
            if (this.head == null)
            {
                Console.WriteLine("Head is empty");
            }
            else if(this.head.data.Equals(data))
            {
                Console.WriteLine("Found {0} at Position {1}",data, position);
                notFound = false;
            }
            else
            {
                while(head.next != null)
                {
                    if(this.head.data.Equals(data))
                    {
                        Console.WriteLine("Found {0} at Position {1}", data, position);
                        notFound = false;
                    }
                    head = head.next;
                }
            }
            if(notFound)
            {
                Console.WriteLine("404: {0} not found",data);
            }
        }

    }
}
