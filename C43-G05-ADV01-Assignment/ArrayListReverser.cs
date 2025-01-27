using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_ADV01_Assignment
{

    public static class ArrayListReverser
    {
        public static void ReverseInPlace(ArrayList list)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list), "ArrayList cannot be null");

            int count = list.Count;
            for (int i = 0; i < count / 2; i++)
            {
                int swapIndex = count - 1 - i;
                (list[i], list[swapIndex]) = (list[swapIndex], list[i]);
            }
        }
    }
}
