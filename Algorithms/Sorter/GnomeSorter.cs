using Algorithms.Common;
using System.Collections.Generic;

namespace Algorithms.Sorter
{
    public static class GnomeSorter
    {
        public static void GnomeSort<T>(this IList<T> collection, Comparer<T> comparer = null)
        {
            comparer = comparer ?? Comparer<T>.Default;
        }
        public static void GnomeSortAscending<T>(this IList<T> collection, Comparer<T> comparer)
        {
            int pos = 1;
            while (pos < collection.Count)
            {
                if (comparer.Compare(collection[pos], collection[pos - 1]) >= 1)
                {
                    pos++;
                }
                else
                {
                    collection.Swap(pos, pos - 1);
                    if (pos > 1)
                        pos--;
                }
            }
        }
        public static void GnomeSortDescending<T>(this IList<T> collection, Comparer<T> comparer)
        {
            int pos = 1;
            while (pos < collection.Count)
            {
                if (comparer.Compare(collection[pos], collection[pos - 1]) <= 0)
                {
                    pos++;
                }
                else
                {
                    collection.Swap(pos, pos - 1);
                    if (pos > 1)
                        pos--;
                }
            }
        }

    }
}
