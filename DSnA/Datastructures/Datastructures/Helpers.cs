using System;
using System.Collections.Generic;
using System.Text;

namespace Datastructures
{
    static class Helpers
    {
        public static void Swap(ref int v1, ref int v2)
        {
            int temp = v1;
            v1 = v2;
            v2 = temp;
        }
    }
}
