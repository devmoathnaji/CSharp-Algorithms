using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Common
{
    public static class Helpers
    {
        public static void Swap<T>(this IList<T> list, int firstIndex, int secoundIndex)
        {
            if (list.Count < 2 || firstIndex == secoundIndex)
                return;
            var temp = list[firstIndex];
            list[firstIndex] = list[secoundIndex];
            list[secoundIndex] = temp;
        }
        public static void Swap<T>(this List<T> list, int firstIndex, int secoundIndex)
        {
            if (list.Count < 2 || firstIndex == secoundIndex)
                return;
            var temp = list[firstIndex];
            list[firstIndex] = list[secoundIndex];
            list[secoundIndex] = temp;
        }
        public static void Populates<T>(this IList<T> collection, T value)
        {
            if (collection == null)
                return;
            for (int i = 0; i < collection.Count; i++)
            {
                collection[i] = value;
            }
          
        }
    }
}
