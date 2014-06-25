#if !Portable
using System.Numerics;
#endif

namespace System
{
    public static partial class RandomHelper
    {
#if !Portable
        public static BigInteger NextBigInteger(BigInteger maxValue)
        {
            // TODO
            return Rand.NextBigInteger(maxValue);
        }

        public static BigInteger NextBigInteger(BigInteger minValue, BigInteger maxValue)
        {
            // TODO
            return Rand.NextBigInteger(minValue, maxValue);
        }
#endif
    }
}
