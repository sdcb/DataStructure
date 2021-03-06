﻿using DataStructure.LinkedListDetails;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStructure
{
    public class MyLinkedList<T> : IEnumerable<T> where T : IEquatable<T>
    {
        public int Count { get; private set; }

        public Node<T> Head { get; private set; }

        public Node<T> Tail { get; private set; }

        public void AddToFront(T item)
        {
            var temp = Head;
            Head = Node.Create(item);
            Head.Next = temp;

            Count += 1;
            if (Count == 1)
            {
                Tail = Head;
            }
        }

        public void AddToEnd(T item)
        {
            var node = Node.Create(item);
            if (Count == 0)
            {
                Head = node;
            }
            else
            {
                Tail.Next = node;
            }
            node.Prev = Tail;
            Tail = node;
            Count += 1;
        }

        public void RemoveFirst()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("List cannot remove first when empty.");
            }
            if (Head == Tail)
            {
                Tail = null;
            }
            Head = Head.Next;
            Count -= 1;
        }

        public void RemoveLast()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("List cannot remove last when empty.");
            }
            if (Count == 1)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                var traveler = Head;
                while (traveler.Next != Tail)
                {
                    traveler = traveler.Next;
                }
                Tail = traveler;
                Tail.Next = null;
            }
            Count -= 1;
        }

        public bool RemoveElement(T v)
        {
            var traveler = Head;
            if (traveler == null)
            {
                return false;
            }
            while (traveler != Tail)
            {
                if (traveler.Value.Equals(v))
                {
                    traveler.Prev.Next = traveler.Next;
                    traveler.Next.Prev = traveler.Prev;
                    return true;
                }
                traveler = traveler.Next;
            }
            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return Head.ToEnumerable().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Head.ToEnumerable().GetEnumerator();
        }
    }
}
