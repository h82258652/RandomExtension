
namespace System
{
    public partial class RandomExtension
    {
        public sbyte NextSByte()
        {
            return 0;
        }

        public sbyte NextSByte(bool containNavigate)
        {
            return 0;
        }

        public sbyte NextSByte(sbyte maxValue)
        {
            if (maxValue < 0)
            {
                throw new ArgumentOutOfRangeException("maxValue", "maxValue 必须大于或等于零。");
            }
            return 0;
        }

        public sbyte NextSByte(sbyte minValue, sbyte maxValue)
        {
            if (minValue > maxValue)
            {
                throw new ArgumentOutOfRangeException("minValue", "“minValue”不能大于 maxValue。");
            }
            return 0;
        }
    }
}
