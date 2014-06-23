
namespace System
{
    public static partial class RandomHelper
    {
        public static uint NextUInt32()
        {
            return Rand.NextUInt32();
        }

        public static uint NextUInt32(uint maxValue)
        {
            return Rand.NextUInt32(maxValue);
        }

        public static uint NextUInt32(uint minValue, uint maxValue)
        {
            return Rand.NextUInt32(minValue, maxValue);
        }
    }
}
