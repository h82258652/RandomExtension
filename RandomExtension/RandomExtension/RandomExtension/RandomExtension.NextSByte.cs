
namespace System
{
    public partial class RandomExtension
    {
        public sbyte NextSByte()
        {
            // TODO
            return (sbyte)Next(sbyte.MaxValue);
        }

        public sbyte NextSByte(bool containNegative)
        {
            // TODO
            if (containNegative)
            {
                return (sbyte)Next(sbyte.MinValue, sbyte.MaxValue);
            }
            else
            {
                return NextSByte();
            }
        }

        public sbyte NextSByte(sbyte maxValue)
        {
            // TODO
            if (maxValue < 0)
            {
                throw new ArgumentOutOfRangeException("maxValue", "maxValue 必须大于或等于零。");
            }
            return (sbyte)Next(maxValue);
        }

        public sbyte NextSByte(sbyte minValue, sbyte maxValue)
        {
            // TODO
            if (minValue > maxValue)
            {
                throw new ArgumentOutOfRangeException("minValue", "“minValue”不能大于 maxValue。");
            }
            return (sbyte)Next(minValue, maxValue);
        }
    }
}
