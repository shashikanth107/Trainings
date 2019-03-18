using System;
using System.Collections.Generic;
using System.Text;

namespace Datastructures.Sorting
{
    /// <summary>
    /// Assume left side of array is sorted and pick the element from right
    /// and place in the left array (if the item is less than the heighest of sorted)
    /// and verify this till the begining of array
    /// 
    /// insertion sort is O(n) in best case - already sorted, because it wont verify the complete set while inserting
    /// new to left sorted array
    /// </summary>
    class Insertion
    {
        public static void Sort(int[] elements)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                int pos = i;
                while (pos > 0 && elements[pos] < elements[pos-1])// Does not enter in best case
                {
                    Helpers.Swap(ref elements[pos], ref elements[pos - 1]);
                    pos--;
                }
            }
        }
    }
}
