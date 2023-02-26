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
            Console.WriteLine("\nFirstNode Added ");
            st.AddFirst(70);
            st.AddFirst(30);
            st.AddFirst(56);
            Console.WriteLine("\nAppended ");
            st.Append(30);
            st.AddFirst(56);
            st.AddFirst(70);
            Console.WriteLine("\nInsert");
            st.Add(56);
            st.Add(70);
            st.Insert(30, 2);
            Console.WriteLine("Delete");
            st.Pop();
            Console.WriteLine("Delete Last Element");
            st.PopLastNode();
            Console.WriteLine("Search Element");
            st.Search(30);
            st.Display();
            Console.ReadLine();
        }
    }
}
