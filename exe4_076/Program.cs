using System;

namespace Exe4_076
{

    class Node
    {
        public int info;
        public Node next;
        public Node (int i, Node n)
        {
            info = i;
            next = n;
        }
    }
    class Stacks
    {
        Node top;
        public Stacks()
        {
            top = null;
        }
        bool empty()
        {
            if (top == null)
                return (true);
            else
                return (false);
        }
        public void push(int element)
        {
            Node fresh;
            fresh = new Node(element, null);

            fresh.next = top;
            top = fresh;
            Console.WriteLine("\n" + element + " pushed.");
        }
        public void pop()
        {
            Console.WriteLine("\nThe popped element is: " + top.info);
        }
        public void display()
        {
            Node tmp;
            if (empty()) //If stack is empty
                Console.WriteLine("\nStack Empty");
            else
            {
                //Traverse the list from beginning till end
                for (tmp = top; tmp != null; tmp = tmp.next)
                {
                    Console.WriteLine(tmp.info);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {

        }
    }
}