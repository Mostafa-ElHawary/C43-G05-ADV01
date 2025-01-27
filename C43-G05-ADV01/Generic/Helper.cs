using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_ADV01.Generic
{
    public class Helper
    {

        public static void SWAP<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        // NONE GENERIC BubbleSort
        //public static void BubbleSort(int[] Arr)
        //{
        //    if (Arr?.Length > 0)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)
        //        {

        //            for (int j = 0; j < Arr.Length - i - 1 ; j++)
        //            {

        //                if (Arr[j] > Arr[j + 1])
        //                {

        //                    SWAP(ref Arr[j], ref Arr[j + 1]);

        //                }

        //            }
        //        }
        //    }
        //}


        public static void BubbleSort<T>(T[] Arr) where T : IComparable<T>
        {
            if (Arr?.Length > 0)
            {
                for (int i = 0; i < Arr.Length; i++)
                {

                    for (int j = 0; j < Arr.Length - i - 1; j++)
                    {

                        if (Arr[j].CompareTo(Arr[j + 1]) > 0)
                        {

                            SWAP(ref Arr[j], ref Arr[j + 1]);

                        }

                    }
                }
            }
        }



        public static void PrintArray<T>(T[] arr)
        {
            foreach (T i in arr)
            {
                Console.WriteLine($"{i}");
            }
            Console.WriteLine();

        }

        #region Generic linear search method

        public static int LinearSearch<T>(T[] Arr, T Value)
        {
            if (Arr?.Length > 0)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    if (Arr[i].Equals(Value)) return i;
                }
            }
            return -1; // Return -1 if the value is not found
        }
        #endregion
    }
}
