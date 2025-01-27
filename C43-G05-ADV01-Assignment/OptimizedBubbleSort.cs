using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_ADV01_Assignment
{
    public static class BubbleSort
    {
        public static void OptimizedSort(int[] array)
        {
            int end = array.Length - 1;
            bool swapped;

            do
            {
                swapped = false;
                int lastSwapIndex = 0;

                for (int i = 0; i < end; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(ref array[i], ref array[i + 1]);
                        swapped = true;
                        lastSwapIndex = i; 
                    }
                }

                end = lastSwapIndex; 
            }
            while (swapped && end > 0); 
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }

}
