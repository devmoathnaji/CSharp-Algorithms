using Algorithms.Sorter;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace C_Sharp_Algorithms_Test
{
    public class SelectionSorterTest
    {
        [Fact]
        public void Test1()
        {
            var list = new List<int> { 5, 8, 4, 1, 2, 6, 4, 7, 9, 2 };
            SelectionSorter.SelectionSort<int>(list, Comparer<int>.Default);
        }
        [Fact]
        public void Test2()
        {
            var list = new List<int> { 5, 8, 4, 1, 2, 6, 4, 7, 9, 2 };
            SelectionSorter.SelectionSortAscending<int>(list, Comparer<int>.Default);
        }
        [Fact]
        public void Test3()
        {
            var list = new List<int> { 5, 8, 4, 1, 2, 6, 4, 7, 9, 2 };
            SelectionSorter.SelectionSortDescending<int>(list, Comparer<int>.Default);
        }
    }
}
