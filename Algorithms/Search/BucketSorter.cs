using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Search
{
    public static class BucketSorter
    {
        public static void BucketSort(this IList<int> collection)
        {
            collection.BucketSortAscending();
        }
        public static void BucketSortAscending(this IList<int> collection)
        {
            int maxValue = collection.Max();
            int minValue = collection.Min();
            List<int>[] bucket = new List<int>[maxValue - minValue + 1];
            for (int i = 0; i < bucket.Length; i++)
            {
                bucket[i] = new List<int>();
            }
            foreach (int i in collection)
            {
                bucket[i - minValue].Add(i);
            }
            int k = 0;
            foreach (List<int> item in bucket)
            {
                if (item.Count > 0)
                {
                    foreach (var j in item)
                    {
                        collection[k] = j;
                        k++;
                    }
                }
            }
        }
        public static void BucketSortDescending(this IList<int> colloection)
        {
            int maxValue = colloection[0];
            int minValue = colloection[0];
            for (int i = 1; i < colloection.Count; i++)
            {
                if (colloection[i] > maxValue)
                    maxValue = colloection[i];
                if (colloection[i] < minValue)
                    minValue = colloection[i];
            }
            List<int>[] bucket = new List<int>[maxValue - minValue + 1];
            for (int i = 0; i < bucket.Length; i++)
            {
                bucket[i] = new List<int>();
            }
            int k = colloection.Count - 1;
            foreach (List<int> i in bucket)
            {
                if (i.Count > 0)
                {
                    foreach (int j in i)
                    {
                        colloection[k] = j;
                        k--;
                    }
                }
            }
        }
    }
}
