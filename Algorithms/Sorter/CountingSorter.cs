using Algorithms.Common;
using System;
using System.Collections.Generic;

namespace Algorithms.Sorter
{
    public static class CountingSorter
    {
        public static void CountingSort(this IList<int> collection)
        {
            if (collection == null || collection.Count == 0)
                return;
            //get the max number in array
            int maxK = 0;
            int index = 0;
            while (true)
            {
                if (index >= collection.Count)
                    break;
                maxK = Math.Max(maxK, collection[index] + 1);
                index++;
            }
            int[] keys = new int[maxK];
            keys.Populates(0); //Populates it with zeros
            //assign the keys 
            for (int i = 0; i < collection.Count; i++)
            {
                keys[collection[i]] += 1;
            }
            //reset index
            index = 0;
            //sort the elements 
            for (int j = 0; j < keys.Length; j++)
            {
                var val = keys[j];
                if (val > 0)
                {
                    while (val-- > 0)
                    {
                        collection[index] = j;
                        index++;
                    }
                }
            }
        }
    }
}
