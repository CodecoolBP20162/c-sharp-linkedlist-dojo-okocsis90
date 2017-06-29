using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{
    public class Program
    {

        public static void Main(string[] args)
        {
            SinglyLinkedList singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.Add(4);
            singlyLinkedList.Add(3);
            singlyLinkedList.Add(2);
            singlyLinkedList.Add(5);

            Console.WriteLine(singlyLinkedList.Length);
            Console.WriteLine(singlyLinkedList);


            Console.ReadKey();
        }
    }
}
