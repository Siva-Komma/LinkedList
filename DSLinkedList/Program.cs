using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked list in data structure");
            LinkedList st = new LinkedList();
            st.Add(56);
            st.Add(30);
            st.Add(70);
            st.Display();
            Console.ReadLine();
        }
    }
}
