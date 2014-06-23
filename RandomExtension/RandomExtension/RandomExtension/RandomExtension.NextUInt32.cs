
namespace System
{
    public partial class RandomExtension
    {
        public uint NextUInt32()
        {
            // TODO
            return 0;
        }

        public uint NextUInt32(uint maxValue)
        {
            // TODO
            return 0;
        }

        public uint NextUInt32(uint minValue, uint maxValue)
        {
            // TODO
            if (minValue > maxValue)
            {
                throw new ArgumentOutOfRangeException("minValue", "“minValue”不能大于 maxValue。");
            }
            return 0;
        }
    }
}
