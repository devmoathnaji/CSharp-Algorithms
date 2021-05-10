using Algorithms.Sorter;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace C_Sharp_Algorithms_Test
{
    public class HeapSorterTest
    {
        [Fact]
        public void Test1() 
        {
            var list = new List<int> { 5, 8, 4, 1, 2, 6, 4, 7, 9, 2 };
            HeapSorter.HeapSort<int>(list, null);
        }
        [Fact]
        public void Test2()
        {
            var list = new List<int> { 5, 8, 4, 1, 2, 6, 4, 7, 9, 2 };
            HeapSorter.HeapSortAscending<int>(list, null);
        }
        [Fact]
        public void Test3()
        {
            var list = new List<int> { 5, 8, 4, 1, 2, 6, 4, 7, 9, 2 };
            HeapSorter.HeapSortDescending<int>(list, null);
        }
    }
}
