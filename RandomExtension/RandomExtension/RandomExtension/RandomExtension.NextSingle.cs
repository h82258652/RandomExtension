
namespace System
{
    public partial class RandomExtension
    {
        public float NextSingle()
        {
            // TODO
            return (float)NextDouble(float.MaxValue);
        }

        public float NextSingle(bool containNagivate)
        {
            // TODO
            return (float)NextDouble(float.MinValue, float.MaxValue);
        }

        public float NextSingle(float maxValue)
        {
            // TODO
            if (maxValue < 0)
            {
                throw new ArgumentOutOfRangeException("maxValue", "maxValue 必须大于或等于零。");
            }
            return (float)NextDouble(maxValue);
        }

        public float NextSingle(float minValue, float maxValue)
        {
            // TODO
            if (minValue > maxValue)
            {
                throw new ArgumentOutOfRangeException("minValue", "“minValue”不能大于 maxValue。");
            }
            return (float)NextDouble(minValue, maxValue);
        }
    }
}
