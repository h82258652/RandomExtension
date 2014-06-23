namespace System
{
    public partial class RandomExtension
    {
        public ushort NextUShort()
        {
            return NextUShort(ushort.MaxValue);
        }

        public ushort NextUShort(ushort maxValue)
        {
            return NextUShort(0, maxValue);
        }

        public ushort NextUShort(ushort minValue, ushort maxValue)
        {
        }
    }
}
