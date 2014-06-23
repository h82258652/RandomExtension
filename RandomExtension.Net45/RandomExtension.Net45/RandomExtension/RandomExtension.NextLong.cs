
namespace System
{
    public partial class RandomExtension
    {
        public long NextLong()
        {

        }

        public long NextLong(bool containNegative)
        {
        }

        public long NextLong(long maxValue)
        {
            if (maxValue < 0)
            {
                throw new ArgumentOutOfRangeException("maxValue", "");
            }
            return (long)Sample() * maxValue;
        }

        public long NextLong(long minValue, long maxValue)
        {
        }
    }
}
