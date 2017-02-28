using DataStructure.LinkedListDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace DataStructure.test.LinkedListTests
{
    public class NodeTests
    {
        [Fact]
        void EnumerableNodes()
        {
            var n1 = Node.Create(1);
            var n2 = Node.Create(2);
            var n3 = Node.Create(3);
            n1.Next = n2;
            n2.Next = n3;

            Assert.Equal(n1.ToEnumerable(), new[] { 1, 2, 3 });
        }
    }
}
