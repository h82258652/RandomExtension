
namespace System
{
    public static partial class RandomHelper
    {
        public static long NextInt64()
        {
            return Rand.NextInt64();
        }

        public static long NextInt64(bool containNavigate)
        {
            return Rand.NextInt64(containNavigate);
        }

        public static long NextInt64(long maxValue)
        {
            return Rand.NextInt64(maxValue);
        }

        public static long NextInt64(long minValue, long maxValue)
        {
            return Rand.NextInt64(minValue, maxValue);
        }
    }
}
