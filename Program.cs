using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            //UC-2 Ability to create Linked List by adding 30 and 56 to 70
            Console.WriteLine("welcome to LinkedList");

            LinkedList linkedlist = new LinkedList();
            linkedlist.AddFirst(70);
            linkedlist.AddFirst(30);
            linkedlist.AddFirst(56);
            linkedlist.Display();
           Console.ReadLine();
        }
    }
}
