using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class MyMath
    {
        public int GreatestCommonDivisor(int a, int b) {
            if (a < b) return GreatestCommonDivisor(b, a);
            if ((a % b) == 0) return b;
            return GreatestCommonDivisor(a - b, b);
        }
    }
}
