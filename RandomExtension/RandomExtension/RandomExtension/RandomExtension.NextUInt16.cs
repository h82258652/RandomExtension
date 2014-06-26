﻿
namespace System
{
    public partial class RandomExtension
    {
        /// <summary>
        /// 返回非负随机数。
        /// </summary>
        /// <returns>大于等于零且小于 MaxValue 的 16 位无符号整数。</returns>
        public ushort NextUInt16()
        {
            return NextUInt16(ushort.MaxValue);
        }

        /// <summary>
        /// 返回一个小于所指定最大值的非负随机数。
        /// </summary>
        /// <param name="maxValue">要生成的随机数的上限（随机数不能取该上限值）。maxValue 必须大于或等于零。</param>
        /// <returns>大于等于零且小于 maxValue 的 16 位无符号整数，即：返回值的范围通常包括零但不包括 maxValue。不过，如果 maxValue 等于零，则返回 maxValue。</returns>
        public ushort NextUInt16(ushort maxValue)
        {
            return NextUInt16(0, maxValue);
        }

        /// <summary>
        /// 返回一个指定范围内的随机数。
        /// </summary>
        /// <param name="minValue">返回的随机数的下界（随机数可取该下界值）。</param>
        /// <param name="maxValue">返回的随机数的上界（随机数不能取该上界值）。maxValue 必须大于或等于 minValue。</param>
        /// <returns>一个大于等于 minValue 且小于 maxValue 的 16 位无符号整数，即：返回的值范围包括 minValue 但不包括 maxValue。如果 minValue 等于 maxValue，则返回 minValue。</returns>
        /// <exception cref="System.ArgumentOutOfRangeException"><c>minValue</c> 大于 <c>maxValue</c>。</exception>
        public ushort NextUInt16(ushort minValue, ushort maxValue)
        {
            if (minValue > maxValue)
            {
                throw new ArgumentOutOfRangeException("minValue", "“minValue”不能大于 maxValue。");
            }
            return (ushort)NextDouble(minValue, maxValue);
        }
    }
}
