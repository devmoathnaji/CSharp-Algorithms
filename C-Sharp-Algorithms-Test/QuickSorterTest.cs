using Algorithms.Sorter;
using System.Collections.Generic;
using Xunit;

namespace C_Sharp_Algorithms_Test
{
    public class QuickSorterTest
    {
        [Fact]
        public void Test1()
        {
            var list = new List<int> { 5, 8, 4, 1, 2, 6, 4, 7, 9, 2 };
            QuickSorter.QuickSort<int>(list, Comparer<int>.Default);
        }
    }
}
