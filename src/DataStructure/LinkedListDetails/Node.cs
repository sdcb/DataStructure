using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStructure.LinkedListDetails
{
    public class Node<T>
    {
        public T Value;

        public Node<T> Prev;

        public Node<T> Next;
    }

    public static class Node
    {
        public static Node<T> Create<T>(T value)
        {
            return new Node<T>
            {
                Value = value
            };
        }
    }
}
