﻿
namespace System
{
    public partial class RandomHelper
    {
        /// <summary>
        /// 返回随机字节。
        /// </summary>
        /// <returns>小于 MaxValue 的无符号 8 位整数。</returns>
        public static byte NextByte()
        {
            return Rand.NextByte();
        }

        /// <summary>
        /// 返回一个小于所指定最大值的字节。
        /// </summary>
        /// <param name="maxValue">要生成的随机字节的上限（随机字节不能取该上限值）。</param>
        /// <returns>小于 maxValue 的无符号 8 位整数，即：返回值的范围通常包括零但不包括 maxValue。不过，如果 maxValue 等于零，则返回 maxValue。</returns>
        public static byte NextByte(byte maxValue)
        {
            return Rand.NextByte(maxValue);
        }

        /// <summary>
        /// 返回一个指定范围内的随机字节。
        /// </summary>
        /// <param name="minValue">返回的随机字节的下界（随机字节可取该下界值）。</param>
        /// <param name="maxValue">返回的随机字节的上界（随机字节不能取该上界值）。maxValue 必须大于或等于 minValue。</param>
        /// <returns>一个大于等于 minValue 且小于 maxValue 的无符号 8 位整数，即：返回的值范围包括 minValue 但不包括 maxValue。如果 minValue 等于 maxValue，则返回 minValue。</returns>
        /// <exception cref="System.ArgumentOutOfRangeException"><c>minValue</c> 大于 <c>maxValue</c>。</exception>
        public static byte NextByte(byte minValue, byte maxValue)
        {
            return Rand.NextByte(minValue, maxValue);
        }
    }
}
