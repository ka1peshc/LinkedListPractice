using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListPractice
{
    class LinkedList
    {
        internal Node head;
        /// <summary>
        /// Adding new node in linklist
        /// </summary>
        /// <param name="data"></param>
        internal void Add(int data)
        {
            Node node = new Node(data);
            
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
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
        internal Node AddInBetween(int position, int data)
        {
            //int index=1;
            Node tempNode = this.head;
            if (position < 1)
            {
                Console.WriteLine("invalid position");
                
            }
            else if( position == 1)
            {
                Node newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                
                while(position-- != 0)
                {
                    if(position == 1)
                    {
                        Node node = new Node(data);
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
        internal void Display()
        {
            Console.WriteLine("head is :" + this.head.data);
            Node temp = this.head;
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
        internal void pophead()
        {
            Node tempNode = this.head;
            head = tempNode.next;
            Console.WriteLine("poped head");
        }
        
    }
}
