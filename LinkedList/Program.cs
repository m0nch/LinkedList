using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList<string> singlyLinkedList = new SinglyLinkedList<string>();
            singlyLinkedList.InsertFront("aaaa");
            singlyLinkedList.InsertFront("bbbb");
            singlyLinkedList.InsertFront("cccc");
            singlyLinkedList.ReverseSinglyLinkedList();
            singlyLinkedList.DeleteNodebyKey("bbbb");

            DoublyLinkedList<string> doublyLinkedList = new DoublyLinkedList<string>();
            doublyLinkedList.InsertFront("aaaaa");
            doublyLinkedList.InsertAfter(doublyLinkedList.Head, "bbbbb");
            doublyLinkedList.InsertAfter(doublyLinkedList.Head.Next, "ccccc");
            doublyLinkedList.InsertAfter(doublyLinkedList.Head.Next.Next, "ddddd");
            doublyLinkedList.InsertAfter(doublyLinkedList.GetLastNode(), "eeeee");
            doublyLinkedList.ReverseDoublyLinkedList();
            doublyLinkedList.DeleteNodebyKey("ddddd");

            Console.ReadKey();
        }
    }  
}