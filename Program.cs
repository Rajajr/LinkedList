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
            //UC-3 Ability to create Linked List by appending 30 and 56 to 70
            Console.WriteLine("welcome to LinkedList");

            LinkedList linkedlist = new LinkedList();
            linkedlist.Append(56);
            linkedlist.Append(30);
            linkedlist.Append(70);
            linkedlist.Display();
           Console.ReadLine();
        }
    }
}
