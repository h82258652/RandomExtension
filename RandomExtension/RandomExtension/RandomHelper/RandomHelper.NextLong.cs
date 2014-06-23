
namespace System
{
    public static partial class RandomHelper
    {
        public static long NextLong()
        {
            return Rand.NextLong();
        }

        public static long NextLong(bool containNavigate)
        {
            return Rand.NextLong(containNavigate);
        }

        public static long NextLong(long maxValue)
        {
            return Rand.NextLong(maxValue);
        }

        public static long NextLong(long minValue, long maxValue)
        {
            return Rand.NextLong(minValue, maxValue);
        }
    }
}
