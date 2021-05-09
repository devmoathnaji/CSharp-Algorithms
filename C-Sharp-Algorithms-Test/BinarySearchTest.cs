using Algorithms.Search;
using System;
using System.Collections.Generic;
using Xunit;

namespace C_Sharp_Algorithms_Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            IList<int> items = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
            BinarySearcher<int> binarySearcher = new BinarySearcher<int>(items, Comparer<int>.Default);
            var x = binarySearcher.BinarySearch(2);
        }
    }
}
