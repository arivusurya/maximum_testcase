using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaximum
{
    public class testCases5<T> where T : IComparable
    {
        T a, b, c;

        public T maxi(T a, T b, T c)
        {
            if (a.CompareTo(b) == 1 && a.CompareTo(c) == 1)
                return a;
            if (b.CompareTo(a) == 1 && b.CompareTo(c) == 1)
                return b;
            if (c.CompareTo(a) == 1 && c.CompareTo(b) == 1)
                return c;
            return a;

        }



    }
    public class maxy<T> : testCases<T> where T : IComparable
    {
        public T max(T a, T b, T c)
        {
            T mx = maxi(a, b, c);

            toPrint(mx);
            return mx;
        }
        public T toPrint(T mx)
        {
            System.Console.WriteLine(mx);
            return mx;
        }

    }

}