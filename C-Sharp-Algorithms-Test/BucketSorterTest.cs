using Algorithms.Sorter;
using System.Collections.Generic;
using Xunit;

namespace C_Sharp_Algorithms_Test
{
    public class BucketSorterTest
    {
        [Fact]
        public void Test1()
        {
            var list = new List<int> { 23, 42, 4, 16, 8, 15, 3, 9, 55, 0, 34, 12, 2, 46, 25 };
            BucketSorter.BucketSort(list);
        }
        [Fact]
        public void Test2()
        {
            var list = new List<int> { 23, 42, 4, 16, 8, 15, 3, 9, 55, 0, 34, 12, 2, 46, 25 };
            BucketSorter.BucketSortAscending(list);
        }
        [Fact]
        public void Test3()
        {
            var list = new List<int> { 23, 42, 4, 16, 8, 15, 3, 9, 55, 0, 34, 12, 2, 46, 25 };
            BucketSorter.BucketSortDescending(list);
        }
    }
}
