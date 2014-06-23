
namespace System
{
    public partial class RandomExtension
    {
        public float NextSingle()
        {
            // TODO
            return 0;
        }

        public float NextSingle(bool containNagivate)
        {
            // TODO
            return 0;
        }

        public float NextSingle(float maxValue)
        {
            // TODO
            if (maxValue < 0)
            {
                throw new ArgumentOutOfRangeException("maxValue", "maxValue 必须大于或等于零。");
            }
            return 0;
        }

        public float NextSingle(float minValue, float maxValue)
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
