using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSLinkedList
{
    class LinkedList
    {
        public Node head;
        public void Add(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
            Console.WriteLine("{0} is added into LinkedList", newNode.data);
        }
        public void AddFirst(int data)
        {
            Node newNode = new Node(data);
            newNode.next = head;
            head = newNode;
        }
        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("LinkedList is Empty");
            }
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    Console.WriteLine("Linked list is: "+temp.data);
                    temp = temp.next;
                }
            }
        }
    }
}
