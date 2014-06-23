
namespace System
{
    public partial class RandomExtension
    {
        /// <summary>
        /// 返回非负随机数。
        /// </summary>
        /// <returns>返回一个非负随机的 Decimal。</returns>
        public decimal NextDecimal()
        {
            return NextDecimal(false);
        }

        /// <summary>
        /// 返回随机数。
        /// </summary>
        /// <param name="containNegative">是否包含负数。</param>
        /// <returns>返回一个随机的 Decimal。</returns>
        public decimal NextDecimal(bool containNegative)
        {
            var buffer = new byte[4];
            // 96 位整数的低 32 位。
            NextBytes(buffer);
            var lo = BitConverter.ToInt32(buffer, 0);
            // 96 位整数的中间 32 位。
            NextBytes(buffer);
            var mid = BitConverter.ToInt32(buffer, 0);
            // 96 位整数的高 32 位。
            NextBytes(buffer);
            var hi = BitConverter.ToInt32(buffer, 0);
            // 正或负。
            var isNegative = containNegative && Next(2) == 0;
            // 10 的指数（0 到 28 之间）。
            var scale = (byte)Next(29);
            return new decimal(lo, mid, hi, isNegative, scale);
        }

        public decimal NextDecimal(decimal maxValue)
        {
            // TODO
            return 0;
        }

        public decimal NextDecimal(decimal minValue, decimal maxValue)
        {
            // TODO
            return 0;
        }
    }
}
