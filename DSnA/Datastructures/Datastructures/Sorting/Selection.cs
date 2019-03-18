using System;
using System.Collections.Generic;
using System.Text;

namespace Datastructures.Sorting
{
    public class Selection
    {
        /// <summary>
        /// complexity is n2 in all cases, as we've to compare all right side with an element of left sorted
        /// </summary>
        /// <param name="elements"></param>
        public static void Sort(int[] elements)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                for (int j = i + 1; j < elements.Length; j++)
                {
                    if (elements[i] > elements[j])
                        Helpers.Swap(ref elements[i], ref elements[j]);
                }
            }
        }

        public static void RecSort(int[] elements)
        {
            RecSortInternal(elements, 0);
        }

        private static void RecSortInternal(int[] elements, int v)
        {
            if (v >= elements.Length + 1)
                return;

            for (int j = v + 1; j < elements.Length; j++)
            {
                if (elements[v] > elements[j])
                    Helpers.Swap(ref elements[v], ref elements[j]);
            }

            RecSortInternal(elements, v + 1);
        }
    }
}
