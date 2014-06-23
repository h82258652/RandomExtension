
namespace System
{
    public static partial class RandomHelper
    {
        public static ulong NextUInt64()
        {
            return Rand.NextUInt64();
        }

        public static ulong NextUInt64(ulong maxValue)
        {
            return Rand.NextUInt64(maxValue);
        }

        public static ulong NextUInt64(ulong minValue, ulong maxValue)
        {
            return Rand.NextUInt64(minValue, maxValue);
        }
    }
}
