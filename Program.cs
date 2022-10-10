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
            //UC-5 Ability to Delete the First Element in the LinkedList
            Console.WriteLine("welcome to LinkedList");

            LinkedList linkedlist = new LinkedList();
            linkedlist.Append(56);
            linkedlist.Append(30);
            linkedlist.Append(70);

            linkedlist.DeleteTheFirst();
          
           Console.ReadLine();
        }
    }
}
