using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_ADV01.Generic
{
    internal class Swapper
    {
        public void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        // Swap strings
        public void Swap(ref string a, ref string b)
        {
            string temp = a;
            a = b;
            b = temp;
        }
    }
}
