using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System
{
    public static partial class RandomHelper
    {
        public static decimal NextDecimal()
        {
            // TODO
            return Rand.NextDecimal();
        }

        public static decimal NextDecimal(bool containNegative)
        {
            // TODO
            return Rand.NextDecimal(containNegative);
        }

        public static decimal NextDecimal(decimal maxValue)
        {
            // TODO
            return Rand.NextDecimal(maxValue);
        }

        public static decimal NextDecimal(decimal minValue, decimal maxValue)
        {
            // TODO
            return Rand.NextDecimal(minValue, maxValue);
        }
    }
}
