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
        public void Append(int data)
        {
            AddFirst(data);
        }
        public void Insert(int data, int position)
        {
            Node newNode = new Node(data);
            newNode.data = data;
            newNode.next = null;
            if (position < 1)
            {
                Console.Write("\nposition should be greater than");
            }
            else if (position == 1)
            {
                newNode.next = head;
                head = newNode;
            }
            else
            {
                Node temp = new Node(data);
                temp = head;
                for (int i = 1; i < position - 1; i++)
                {
                    if (temp != null)
                    {
                        temp = temp.next;
                    }
                }

                if (temp != null)
                {
                    newNode.next = temp.next;
                    temp.next = newNode;
                }
                else
                {
                    Console.Write("\nThe previous node is null.");
                }
            }
        }
        public void Pop()
        {
            if (head == null)
            {
                Console.WriteLine("LinkedList is empty");
            }
            else
            {
                head = head.next;
                Console.WriteLine("\nRemoved 1st node");
            }
        }
        public void PopLastNode()
        {
            if (head == null)
            {
                Console.WriteLine("Linked List empty");
            }
            else
            {
                if (head.next == null)
                    head = null;
                else
                {
                    Node temp = head;
                    while (temp.next.next != null)
                    {
                        temp = temp.next;
                    }
                    temp.next = null;
                }
            }
        }
        public void Search(int input)
        {
            bool isFound = false;
            if (head == null)
                Console.WriteLine("LinkedList is Empty");
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    if (temp.data == input)
                    {
                        isFound = true;
                        Console.WriteLine("Given node {0} is present", input);
                        break;
                    }
                    temp = temp.next;
                }
                if (!isFound)
                    Console.WriteLine("Given node {0} is not present", input);
            }
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
