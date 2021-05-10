using Algorithms.Sorter;
using System.Collections.Generic;
using Xunit;

namespace C_Sharp_Algorithms_Test
{
    public  class CycleSorterTest
    {
        [Fact]
        public void Test1()
        {
            var list = new List<int>() { 8, 5, 5, 2, 1, 4, 8, 54, 5, 1, 5, 2, 21, 55 };
            CycleSorter.CycleSort<int>(list, null);
        }
    }
}
