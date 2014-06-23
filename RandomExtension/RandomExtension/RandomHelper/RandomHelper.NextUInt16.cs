
namespace System
{
    public static partial class RandomHelper
    {
        public static ushort NextUInt16()
        {
            return Rand.NextUInt16();
        }

        public static ushort NextUInt16(ushort maxValue)
        {
            return Rand.NextUInt16(maxValue);
        }
        public static ushort NextUInt16(ushort minValue, ushort maxValue)
        {
            return Rand.NextUInt16(minValue, maxValue);
        }
    }
}
