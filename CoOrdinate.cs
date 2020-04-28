using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAssignment
{
    public class CoOrdinate
    {
        private int X;
        private int Y;

        public CoOrdinate(int x, int y)
        {
            X = x;
            Y = y;
        }

        List<int> x_y = new List<int>();

        public List<int> coOrdinates()
        {
            x_y.Add(X);
            x_y.Add(Y);
            return x_y;
        }
    }
}
