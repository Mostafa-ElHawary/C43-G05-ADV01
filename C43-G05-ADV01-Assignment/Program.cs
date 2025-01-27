using System.Collections;

namespace C43_G05_ADV01_Assignment
{
    internal class Program
    {
        private static void PrintArrayList(ArrayList list)
        {
            Console.WriteLine($"ArrayList: {{ {string.Join(", ", list.ToArray())} }}");
        }
        static void Main(string[] args)
        {



            #region Q1


            //int[] arr = { 5, 3, 8, 4, 2 };
            //Console.WriteLine("Original array: " + string.Join(", ", arr));

            //BubbleSort.OptimizedSort(arr);

            //Console.WriteLine("Sorted array:   " + string.Join(", ", arr));


            #endregion


            #region q2


            // Integer range example
            //var intRange = new Range<int>(5, 10);
            //Console.WriteLine($"Integer Range: {intRange.Min}-{intRange.Max}");
            //Console.WriteLine($"Is 7 in range? {intRange.IsInRange(7)}");
            //Console.WriteLine($"Range length: {intRange.Length()}\n");



            #endregion

            #region Q3

            //ArrayList numbers = new ArrayList { 1, 2, 3, 4, 5 };


            //Console.WriteLine("Original lists:");
            //PrintArrayList(numbers);


            //ArrayListReverser.ReverseInPlace(numbers);


            //Console.WriteLine("\nReversed lists:");
            //PrintArrayList(numbers);


            #endregion

            #region Q4

            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //EvenNumberFilter filter = new EvenNumberFilter();

            //List<int> evenNumbers = filter.GetEvenNumbers(numbers);

            //Console.WriteLine("Original numbers: " + string.Join(", ", numbers));
            //Console.WriteLine("Even numbers:     " + string.Join(", ", evenNumbers));

            #endregion

            #region Q5

            //try
            //{
            //    var fixedList = new FixedSizeList<string>(3);

            //    fixedList.Add("First");
            //    fixedList.Add("Second");
            //    fixedList.Add("Third");

            //    Console.WriteLine("List contents:");
            //    for (int i = 0; i < fixedList.Count; i++)
            //    {
            //        Console.WriteLine($"Index {i}: {fixedList.Get(i)}");
            //    }

            //    fixedList.Add("Fourth");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}

            #endregion

            #region Q6

            Console.WriteLine(UniqueCharacterFinder.FirstUniqChar("leetcode"));
            Console.WriteLine(UniqueCharacterFinder.FirstUniqChar("loveleetcode"));
            Console.WriteLine(UniqueCharacterFinder.FirstUniqChar("aabbcc"));
            #endregion
        }


    }
}
