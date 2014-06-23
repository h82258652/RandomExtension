
namespace System
{
    public static partial class RandomHelper
    {
        public static short NextInt16()
        {
            return Rand.NextInt16();
        }

        public static short NextInt16(bool containNavigate)
        {
            return Rand.NextInt16(containNavigate);
        }

        public static short NextInt16(short maxValue)
        {
            return Rand.NextInt16(maxValue);
        }

        public static short NextInt16(short minValue, short maxValue)
        {
            return Rand.NextInt16(minValue, maxValue);
        }
    }
}
