
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
            return NextUInt64(0, maxValue);
            return 0;
        }

        /// <summary>
        /// 返回一个指定范围内的随机数。
        /// </summary>
        /// <param name="minValue">返回的随机数的下界（随机数可取该下界值）。</param>
        /// <param name="maxValue">返回的随机数的上界（随机数不能取该上界值）。maxValue 必须大于或等于 minValue。</param>
        /// <returns>一个大于等于 minValue 且小于 maxValue 的 64 位无符号长整数，即：返回的值范围包括 minValue 但不包括 maxValue。如果 minValue 等于 maxValue，则返回 minValue。</returns>
        /// <exception cref="System.ArgumentOutOfRangeException"><c>minValue</c> 大于 <c>maxValue</c>。</exception>
        public ulong NextUInt64(ulong minValue, ulong maxValue)
        {
            if (minValue > maxValue)
            {
                throw new ArgumentOutOfRangeException("minValue", "“minValue”不能大于 maxValue。");
            }
            return (ulong)NextDouble(minValue, maxValue);
        }
    }
}
