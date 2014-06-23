namespace System
{
    public partial class RandomExtension
    {
        public ushort NextUInt16()
        {
            return NextUInt16(ushort.MaxValue);
        }

        public ushort NextUInt16(ushort maxValue)
        {
            return NextUInt16(0, maxValue);
        }

        public ushort NextUInt16(ushort minValue, ushort maxValue)
        {
            // TODO
            return 0;
        }
    }
}
