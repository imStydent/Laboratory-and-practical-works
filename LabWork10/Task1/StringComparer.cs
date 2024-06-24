using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class StringComparer : IComparer<Apartment>
    {
        public int Compare(Apartment? x, Apartment? y)
        {
            if (x is Apartment apartment1 && y is Apartment apartment2)
                return apartment1.Address.Length.CompareTo(apartment2.Address.Length);
            else
                return -1;
        }
    }
}
