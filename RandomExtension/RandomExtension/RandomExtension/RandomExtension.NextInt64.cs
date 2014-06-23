
namespace System
{
    public partial class RandomExtension
    {
        public long NextInt64()
        {
            // TODO
            return 0;
        }

        public long NextInt64(bool containNegative)
        {
            // TODO
            return 0;
        }

        public long NextInt64(long maxValue)
        {
            // TODO
            if (maxValue < 0)
            {
                throw new ArgumentOutOfRangeException("maxValue", "");
            }
            return (long)Sample() * maxValue;
        }

        public long NextInt64(long minValue, long maxValue)
        {
            // TODO
            return 0;
        }
    }
}
