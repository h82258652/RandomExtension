
namespace System
{
    public partial class RandomExtension
    {
        public override double NextDouble()
        {
            // TODO
            return base.NextDouble();
        }

        public double NextDouble(bool containNavigate)
        {
            // TODO
            return 0;
        }

        public double NextDouble(double maxValue)
        {
            // TODO
            if (maxValue < 0)
            {
                throw new ArgumentOutOfRangeException("maxValue", "maxValue 必须大于或等于零。");
            }
            return 0;
        }

        public double NextDouble(double minValue, double maxValue)
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
