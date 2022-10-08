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
            //UC-1 Create a Simple Linked List of 56,30 and 70
            Console.WriteLine("welcome to LinkedList");

            LinkedList linkedlist = new LinkedList();
            linkedlist.AddLast(56);
            linkedlist.AddLast(30);
            linkedlist.AddLast(70);

            
           Console.ReadLine();
        }
    }
}
