using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    internal class Stack
    {
        public class Node
        {
            public int data;
            public Node next;
            public Node(int data)
            {
                this.data = data;
            }
        }
        public static Node head;

        public void Push(int data)
        {
            Stack stack = new Stack();
            stack.Add(data);
        }

        public bool Add(int data)
        {
            Node node = new Node(data);

            if(node==null)
            {
                head = node;
                return true;
            }
            node.next = head;
            head = node;
            return true;

        }

        public void Display()
        { 
            Node t = head;

            if(t==null)
            {
                Console.WriteLine("Node is empty");
            }
            while (t.next != null)
            {
                Console.WriteLine(t.data);
                t = t.next;
            }
        }
    }
}
