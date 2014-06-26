
namespace System
{
    public static partial class RandomHelper
    {
        /// <summary>
        /// 返回随机时间。
        /// </summary>
        /// <returns>随机时间。</returns>
        public static DateTime NextDateTime()
        {
            return Rand.NextDateTime();
        }

        /// <summary>
        /// 返回指定时间范围内的随机一个时间。
        /// </summary>
        /// <param name="minValue">起始时间。</param>
        /// <param name="maxValue">结束时间。</param>
        /// <returns>起始时间与结束时间之间的随机一个时间。如果 minValue 等于 maxValue，则返回 minValue。</returns>
        /// <exception><c>minValue</c> 大于 <c>maxValue</c>。</exception>
        public static DateTime NextDateTime(DateTime minValue, DateTime maxValue)
        {
            return Rand.NextDateTime(minValue, maxValue);
        }
    }
}
