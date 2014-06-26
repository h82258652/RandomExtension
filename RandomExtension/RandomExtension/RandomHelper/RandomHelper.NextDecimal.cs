
namespace System
{
    public static partial class RandomHelper
    {
        /// <summary>
        /// 返回非负随机数。
        /// </summary>
        /// <returns>返回一个非负随机的 Decimal。</returns>
        public static decimal NextDecimal()
        {
            return Rand.NextDecimal();
        }

        /// <summary>
        /// 返回随机数。
        /// </summary>
        /// <param name="containNegative">是否包含负数。</param>
        /// <returns>返回一个随机的 Decimal。</returns>
        public static decimal NextDecimal(bool containNegative)
        {
            return Rand.NextDecimal(containNegative);
        }

        public static decimal NextDecimal(decimal maxValue)
        {
            // TODO
            return Rand.NextDecimal(maxValue);
        }

        public static decimal NextDecimal(decimal minValue, decimal maxValue)
        {
            // TODO
            return Rand.NextDecimal(minValue, maxValue);
        }
    }
}
