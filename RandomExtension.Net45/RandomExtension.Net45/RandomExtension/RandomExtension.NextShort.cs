
namespace RandomExtension
{
    public partial class RandomExtension
    {
        public short NextShort()
        {
            return (short)this.Next(short.MaxValue);
        }

        public short NextShort(short maxValue)
        {
            return (short)this.Next(maxValue);
        }

        public short NextShort(short minValue, short maxValue)
        {
            return (short)this.Next(minValue, maxValue);
        }
    }
}
