
namespace System
{
    public partial class RandomExtension
    {
        public ulong NextUInt64()
        {
            // TODO
            return 0;
        }

        public ulong NextUInt64(ulong maxValue)
        {
            // TODO
            return 0;
        }

        public ulong NextUInt64(ulong minValue, ulong maxValue)
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
