using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_ADV01_Assignment
{
    internal class EvenNumberFilter
    {
        public List<int> GetEvenNumbers(List<int> numbers)
        {
            List<int> evenNumbers = new List<int>();

            foreach (int num in numbers)
            {
                if (IsEven(num))
                {
                    evenNumbers.Add(num);
                }
            }

            return evenNumbers;
        }

        private bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }
}
