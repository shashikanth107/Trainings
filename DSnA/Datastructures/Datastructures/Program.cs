using Datastructures.Sorting;
using System;

namespace Datastructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] a = new int[] { 5, 1, 53, 4, 2, 23, 12, 7, 34, 25, 99, 76, 82, 6 };
            //Selection.Sort(a);

            //Selection.RecSort(a);

            Insertion.Sort(a);

        }
    }
}
