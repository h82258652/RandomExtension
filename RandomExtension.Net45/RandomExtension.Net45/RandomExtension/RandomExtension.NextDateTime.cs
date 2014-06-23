
namespace System
{
    public partial class RandomExtension
    {
        public DateTime NextDateTime()
        {
            // TODO add comment
            return NextDateTime(DateTime.MinValue, DateTime.MaxValue);
        }

        public DateTime NextDateTime(DateTime minValue, DateTime maxValue)
        {
            // TODO add comment
            return new DateTime(NextLong(minValue.Ticks, maxValue.Ticks));
        }
    }
}
