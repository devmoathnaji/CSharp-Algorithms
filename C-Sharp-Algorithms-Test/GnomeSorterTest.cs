using Algorithms.Sorter;
using System.Collections.Generic;
using Xunit;

namespace C_Sharp_Algorithms_Test
{
    public class GnomeSorterTest
    {
        [Fact]
        public void Test1()
        {
            var list = new List<int>() { 8, 9, 6, 2, 41, 54, 69, 5, 9, 5, 99, 5, 55, 5, 5858, 100, 6 };
            GnomeSorter.GnomeSort<int>(list, Comparer<int>.Default);
        }

        [Fact]
        public void Test2()
        {
            var list = new List<int>() { 8, 9, 6, 2, 41, 54, 69, 5, 9, 5, 99, 5, 55, 5, 5858, 100, 6 };
            GnomeSorter.GnomeSortDescending<int>(list, Comparer<int>.Default);
        }

        [Fact]
        public void Test3()
        {
            var list = new List<int>() { 8, 9, 6, 2, 41, 54, 69, 5, 9, 5, 99, 5, 55, 5, 5858, 100, 6 };
            GnomeSorter.GnomeSortAscending<int>(list, Comparer<int>.Default);
        }
    }
}
