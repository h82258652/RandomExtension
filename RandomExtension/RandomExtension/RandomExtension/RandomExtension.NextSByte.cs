
namespace System
{
    public partial class RandomExtension
    {
        public sbyte NextSByte()
        {
            // TODO
            return 0;
        }

        public sbyte NextSByte(bool containNavigate)
        {
            // TODO
            return 0;
        }

        public sbyte NextSByte(sbyte maxValue)
        {
            // TODO
            if (maxValue < 0)
            {
                throw new ArgumentOutOfRangeException("maxValue", "maxValue 必须大于或等于零。");
            }
            return 0;
        }

        public sbyte NextSByte(sbyte minValue, sbyte maxValue)
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
