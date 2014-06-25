using System.Numerics;

namespace System
{
    public partial class RandomExtension
    {
#if !Portable
        public BigInteger NextBigInteger(BigInteger maxValue)
        {
            // TODO
            return 0;
        }

        public BigInteger NextBigInteger(BigInteger minValue, BigInteger maxValue)
        {
            // TODO
            return 0;
        }
#endif
    }
}
