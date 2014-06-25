using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System
{
    public static partial class RandomHelper
    {
        public static float NextSingle()
        {
            // TODO
            return Rand.NextSingle();
        }

        public static float NextSingle(bool containNegative)
        {
            // TODO
            return Rand.NextSingle(containNegative);
        }

        public static float NextSingle(float maxValue)
        {
            // TODO
            return Rand.NextSingle(maxValue);
        }

        public static float NextSingle(float minValue, float maxValue)
        {
            // TODO
            return Rand.NextSingle(minValue, maxValue);
        }
    }
}
