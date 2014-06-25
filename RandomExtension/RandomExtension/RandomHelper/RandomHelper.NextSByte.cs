using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System
{
    public static partial class RandomHelper
    {
        public static sbyte NextSByte()
        {
            // TODO
            return Rand.NextSByte();
        }

        public static sbyte NextSByte(bool containNegative)
        {
            // TODO
            return Rand.NextSByte(containNegative);
        }

        public static sbyte NextSByte(sbyte maxValue)
        {
            // TODO
            return Rand.NextSByte(maxValue);
        }

        public static sbyte NextSByte(sbyte minValue, sbyte maxValue)
        {
            // TODO
            return Rand.NextSByte(minValue, maxValue);
        }
    }
}
