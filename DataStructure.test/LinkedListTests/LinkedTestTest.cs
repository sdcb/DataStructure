using DataStructure.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace DataStructure.test.LinkedListTests
{
    public class LinkedTestTest
    {
        [Fact]
        public void AddToFrontTest()
        {
            var list = new MyLinkedList<int>();
            list.AddToFront(3);
            list.AddToFront(2);
            list.AddToFront(1);

            Assert.Equal(new[] { 1, 2, 3 }, list.ToArray());
        }

        [Fact]
        public void AddToEndTest()
        {
            var list = new MyLinkedList<int>();
            list.AddToEnd(1);
            list.AddToEnd(2);
            list.AddToEnd(3);

            Assert.Equal(new[] { 1, 2, 3 }, list.ToArray());
        }
    }
}
