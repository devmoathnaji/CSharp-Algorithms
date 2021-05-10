using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorter
{
    public static class MergeSorter
    {
        public static List<T> MergeSort<T>(this List<T> collection, Comparer<T> comparer = null)
        {
            comparer = comparer ?? Comparer<T>.Default;

            return InternalMergeSort(collection, comparer);
        }
        private static List<T> InternalMergeSort<T>(List<T> collection, Comparer<T> comparer)
        {
            if (collection.Count < 2)
            {
                return collection;
            }

            int midIndex = collection.Count / 2;

            var leftCollection = collection.GetRange(0, midIndex);
            var rightCollection = collection.GetRange(midIndex, collection.Count - midIndex);

            leftCollection = InternalMergeSort<T>(leftCollection, comparer);
            rightCollection = InternalMergeSort<T>(rightCollection, comparer);

            return InternalMerge<T>(leftCollection, rightCollection, comparer);
        }
        private static List<T> InternalMerge<T>(List<T> leftCollection, List<T> rightCollection, Comparer<T> comparer)
        {
            int left = 0;
            int right = 0;
            int index;
            int length = leftCollection.Count + rightCollection.Count;

            List<T> result = new List<T>(length);

            for (index = 0; right < rightCollection.Count && left < leftCollection.Count; ++index)
            {
                if (comparer.Compare(rightCollection[right], leftCollection[left]) <= 0) // rightElement <= leftElement
                {
                    //resultArray.Add(rightCollection[right]);
                    result.Insert(index, rightCollection[right++]);
                }
                else
                {
                    //result.Add(leftCollection[left]);
                    result.Insert(index, leftCollection[left++]);
                }
            }

            //
            // At most one of left and right might still have elements left

            while (right < rightCollection.Count)
            {
                result.Insert(index++, rightCollection[right++]);
            }

            while (left < leftCollection.Count)
            {
                result.Insert(index++, leftCollection[left++]);
            }

            return result;
        }
    }
}
