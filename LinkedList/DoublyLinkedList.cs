using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class DoublyLinkedList<T>
    {
        public DNode<T> Head { get; set; }

        public void InsertFront(T newData)
        {
            DNode<T> newDNode = new DNode<T>(newData);
            newDNode.Next = Head;
            if (Head != null)
            {
                Head.Prev = newDNode;
            }
            Head = newDNode;
        }
        public void InsertLast(T newData)
        {
            DNode<T> newDNode = new DNode<T>(newData);
            if (Head == null)
            {
                newDNode.Prev = null;
                Head = newDNode;
                return;
            }
            DNode<T> lastDNode = GetLastNode();
            lastDNode.Next = newDNode;
            newDNode.Prev = lastDNode;

        }
        private DNode<T> GetLastNode()
        {
            DNode<T> temp = Head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            return temp;
        }
        public void InsertAfter(DNode<T> prevDNode, T newData)
        {
            if (prevDNode == null)
            {
                throw new NullReferenceException();
            }
            DNode<T> newDNode = new DNode<T>(newData);
            newDNode.Next = prevDNode.Next;
            prevDNode.Next = newDNode;
            newDNode.Prev = prevDNode;
            if (newDNode.Next != null)
            {
                newDNode.Next.Prev = newDNode;
            }
        }
        public void ReverseDoublyLinkedList()
        {
            DNode<T> temp = null, currentDNode = Head;
            while (currentDNode != null)
            {
                temp = currentDNode.Prev;
                currentDNode.Prev = currentDNode.Next;
                currentDNode.Next = temp;
                currentDNode = currentDNode.Prev;
            }
            Head = temp.Prev;
        }
        public void DeleteNodebyKey(T data)
        {
            if (data != null)
            {
                DNode<T> temp = Head;
                if (temp != null && temp.Data.Equals(data))
                {
                    Head = temp.Next;
                    Head.Prev = null;
                    return;
                }
                while (temp != null && !temp.Data.Equals(data))
                {
                    temp = temp.Next;
                }
                if (temp == null)
                {
                    return;
                }
                if (temp.Next != null)
                {
                    temp.Next.Prev = temp.Prev;
                }
                if (temp.Prev != null)
                {
                    temp.Prev.Next = temp.Next;
                }
            }
            else
            {
                throw new NullReferenceException();
            }

        }
    }
}
