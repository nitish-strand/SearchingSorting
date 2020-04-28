using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAssignment
{
    public class CoOrdinate : IComparable<CoOrdinate>
    {
        public int X { get; set; }
        public int Y { get; set; }

        public CoOrdinate(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int CompareTo(CoOrdinate other)
        {
            if (this.X > other.X)
                return 1;
            else if (this.X < other.X)
                return -1;
            else return 0;
        }
    }

    public class CoOrdinateComparer : IComparer<CoOrdinate>
    {
        public int Compare(CoOrdinate obj1, CoOrdinate obj2)
        {
            if (obj1.Y > obj2.Y)
                return 1;
            else if (obj1.Y < obj2.Y)
                return -1;
            else
                return 0;
        }
    }
}
