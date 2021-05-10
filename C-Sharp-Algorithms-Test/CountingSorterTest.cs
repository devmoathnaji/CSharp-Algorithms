using Algorithms.Search;
using System.Collections.Generic;
using Xunit;

namespace C_Sharp_Algorithms_Test
{
    public class CountingSorterTest
    {
        [Fact]
        public void Test1()
        {
            var list = new List<int> { 8, 5, 1, 2, 5, 4, 7, 5, 2, 1, 2, 1 };
            CountingSorter.CountingSort(list);
        }
    }
}
