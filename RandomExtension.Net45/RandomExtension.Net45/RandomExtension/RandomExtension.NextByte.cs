
namespace System
{
    public partial class RandomExtension
    {
        public byte NextByte()
        {
            var buffer = new byte[1];
            this.NextBytes(buffer);
            return buffer[0];
        }
    }
}
