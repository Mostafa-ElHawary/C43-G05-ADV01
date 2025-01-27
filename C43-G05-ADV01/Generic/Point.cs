using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_ADV01.Generic
{
    internal struct Point : IComparable
    {

        public int x { get; set; }
        public int y { get; set; }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return $"( {x} , {y} )";
        }


        public int CompareTo(object? other)
        {


            if (other is not null)
            {

                if (other is Point P)
                {

                    //Point P = (Point) obj;
                    if (x == P.x) return y.CompareTo(P.y);
                    return x.CompareTo(P.x);

                }

            }
            return 1;

        }

        //public int CompareTo(object? obj)
        //{
        // if (obj == null) return 1;
        // if (obj is Point other)
        // {
        //     int result = x.CompareTo(other.x);
        //     if (result == 0)
        //     {
        //         result = y.CompareTo(other.y);
        //     }
        //     return result;
        // }
        // else
        // {
        //     throw new ArgumentException("Object is not a Point");
        // }

        //throw new NotImplementedException();


        //}
    }
}
