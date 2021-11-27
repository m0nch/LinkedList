using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class SinglyLinkedList<T>
    {
        public SNode<T> Head { get; set; }

        public void InsertFront(T newData)
        {
            SNode<T> newSNode = new SNode<T>(newData);
            newSNode.Next = Head;
            Head = newSNode;
        }
        public void InsertLast(T newData)
        {
            SNode<T> newSNode = new SNode<T>(newData);
            if (Head == null)
            {
                Head = newSNode;
                return;
            }
            SNode<T> lastSNode = GetLastNode();
            lastSNode.Next = newSNode;
        }

        private SNode<T> GetLastNode()
        {
            SNode<T> temp = Head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            return temp;
        }

        public void InsertAfter(SNode<T> prevSNode, T newData)
        {
            if (prevSNode == null)
            {
                throw new NullReferenceException();
            }
            SNode<T> newSNode = new SNode<T>(newData);
            newSNode.Next = prevSNode.Next;
            prevSNode.Next = newSNode;
        }

        public void ReverseSinglyLinkedList()
        {
            SNode<T> prevSNode = null, temp = null, currentSNode = Head;
            while (currentSNode != null)
            {
                temp = currentSNode.Next;
                currentSNode.Next = prevSNode;
                prevSNode = currentSNode;
                currentSNode = temp;
            }
            Head = prevSNode;
        }

        public void DeleteNodebyKey(T data)
        {
            if (data != null)
            {
                SNode<T> prevSNode = null, temp = Head;
                if (temp != null && temp.Data.Equals(data))
                {
                    Head = temp.Next;
                    return;
                }
                while (temp != null && !temp.Data.Equals(data))
                {
                    prevSNode = temp;
                    temp = temp.Next;
                }
                if (temp == null)
                {
                    return;
                }
                prevSNode.Next = temp.Next;
            }
            else
            {
                throw new NullReferenceException();
            }
        }

    }
}
