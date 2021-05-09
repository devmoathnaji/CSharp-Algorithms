using Algorithms.Search;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace C_Sharp_Algorithms_Test
{
    public class BubbleSorterTest
    {
        [Fact]
        public void Test1()
        {
            var list = new List<int> { 23, 42, 4, 16, 8, 15, 3, 9, 55, 0, 34, 12, 2, 46, 25 };
            BubbleSorter.BubbleSort<int>(list, Comparer<int>.Default);
            Assert.Equal(
                new List<int> { 0, 2, 3, 4, 8, 9, 12, 15, 16, 23, 25, 34, 42, 46, 55 },
                list
                );
        }
    }
}
