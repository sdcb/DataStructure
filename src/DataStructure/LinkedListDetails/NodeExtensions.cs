using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStructure.LinkedListDetails
{
    public static class NodeExtensions
    {
        public static IEnumerable<T> ToEnumerable<T>(this Node<T> node)
        {
            while (node != null)
            {
                yield return node.Value;
                node = node.Next;
            }
            yield break;
        }
    }
}
