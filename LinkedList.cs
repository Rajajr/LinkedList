using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList
    {
        public Node Head;

        public void AddLast(int data)
        {
            Node node1 = new Node(data);
            if (this.Head == null)
            {
                this.Head = node1;

            }
            else
            {
                Node temp = Head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = node1;
            }
            Console.WriteLine("New Node Added in LinkedList: " + node1.data);
            Console.WriteLine("--------------------------------------------");
        }
        public void AddFirst(int data)
        {
            
            Node node2 = new Node(data);
            node2.Next = Head;
            Head = node2;
            Console.WriteLine("New Node Added in LinkedList: " + node2.data);
            Console.WriteLine("--------------------------------------------");
        }
        public void Display()
        {

            Node temp = Head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is Empty");
            }
            if (temp != null)
            {
                Console.WriteLine(temp.data + "");
                temp = temp.Next;
            }
        }
    }
}
