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

        [Fact]
        public void RemoveEmptyFirstWillThrow()
        {
            var list = new MyLinkedList<int>();
            Assert.Throws<InvalidOperationException>(() =>
            {
                list.RemoveFirst();
            });
        }

        [Fact]
        public void RemoveFirst()
        {
            var list = new MyLinkedList<int>();
            list.AddToEnd(1);
            list.AddToEnd(2);
            list.AddToEnd(3);

            list.RemoveFirst();
            Assert.Equal(new[] { 2, 3 }, list);
            Assert.Equal(2, list.Count);
        }

        [Fact]
        public void RemoveFirstWhenOnly1Element()
        {
            var list = new MyLinkedList<int>();
            list.AddToEnd(1);

            list.RemoveFirst();
            Assert.Equal(new int[] { }, list);
            Assert.Equal(0, list.Count);
        }

        [Fact]
        public void RemoveLastIsOk()
        {
            var list = new MyLinkedList<int>();
            list.AddToEnd(1);
            list.AddToEnd(2);
            list.AddToEnd(3);

            list.RemoveLast();
            Assert.Equal(new[] { 1, 2 }, list);
            Assert.Equal(2, list.Count);
        }

        [Fact]
        public void RemoveLastWhenCount1()
        {
            var list = new MyLinkedList<int>();
            list.AddToEnd(1);

            list.RemoveLast();
            Assert.Equal(new int[] { }, list);
            Assert.Equal(0, list.Count);
        }
    }
}
